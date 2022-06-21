using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;


public class PlayerHand : MonoBehaviour, ICardPlacementBehaviour
{
    #region Constans
    internal float SCALE_FACTOR_HAND = 0.375f;
    internal float CARD_WIDTH = 222;
    private const float HIGHLIGTH_SCALE = 0.4125f;
    private const float HIGHLIGTH_AND_CLICK_SCALE = 0.8125f;
    private Vector3 MOVE_Y_VEKTOR = new Vector3(0, 68.645f, 0);
    #endregion


    private List<GameObject> _hand;
    private bool _cardClicked = false;
    private int _currentSiblingIndex;

    private void Awake()
    {
        _hand = new List<GameObject>();
    }
    public List<GameObject> Hand { get => _hand; }

    public void OnClick(CardObject cardObject)
    {
        if (_cardClicked)
        {
            // Open context menu for playing this card out
            //Debug.Log($"You selected {cardObject.name}");
        }
        else
        {
            cardObject.transform.localScale = Vector3.one * HIGHLIGTH_AND_CLICK_SCALE;
            _currentSiblingIndex = cardObject.transform.GetSiblingIndex();
            this.GetComponent<HorizontalLayoutGroup>().enabled = false;
            cardObject.transform.SetAsLastSibling();
            cardObject.transform.position = cardObject.transform.position + MOVE_Y_VEKTOR;
        }

        _cardClicked = true;      

        if (cardObject.gameObject.layer != (int)LayerNumber.IgnoreRaycast)
            Debug.Log($"You are clicking {cardObject.name} in {this.name}");
    }

    public void OnHighlight(CardObject cardObject)
    {
        if (cardObject.gameObject.layer != (int)LayerNumber.IgnoreRaycast && !_cardClicked)
        {
            cardObject.transform.localScale = Vector3.one * HIGHLIGTH_SCALE;

            cardObject.GetComponentInChildren<Outline>().enabled = true;
        }
    }

    public void OnRemoveHighlight(CardObject cardObject)
    {
        if (cardObject.gameObject.layer != (int)LayerNumber.IgnoreRaycast)
        {
            cardObject.transform.localScale = Vector3.one * SCALE_FACTOR_HAND;
            cardObject.GetComponentInChildren<Outline>().enabled = false;

            if (_cardClicked)
            {
                cardObject.transform.position = cardObject.transform.position - MOVE_Y_VEKTOR;
                cardObject.transform.SetSiblingIndex(_currentSiblingIndex);
                this.GetComponent<HorizontalLayoutGroup>().enabled = true;
            }

            _cardClicked = false;
        }
    }
}
