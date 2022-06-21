using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHand : MonoBehaviour, ICardPlacementBehaviour
{
    #region Constans
    internal float SCALE_FACTOR_HAND = 0.375f;
    internal float CARD_WIDTH = 222;
    private const float HIGHLIGTH_SCALE = 0.4125f;
    #endregion


    private List<GameObject> _hand;

    private void Awake()
    {
        _hand = new List<GameObject>();
    }
    public List<GameObject> Hand { get => _hand; }

    public void OnClick(CardObject cardObject)
    {
        if (cardObject.gameObject.layer != (int)LayerNumber.IgnoreRaycast)
            Debug.Log($"You are clicking {cardObject.name} in {this.name}");
    }

    public void OnHighlight(CardObject cardObject)
    {
        if (cardObject.gameObject.layer != (int)LayerNumber.IgnoreRaycast)
        {
            cardObject.transform.localScale = Vector3.one* HIGHLIGTH_SCALE;
            cardObject.GetComponentInChildren<Outline>().enabled = true;
        }
    }

    public void OnRemoveHighlight(CardObject cardObject)
    {
        if (cardObject.gameObject.layer != (int)LayerNumber.IgnoreRaycast)
        {
            cardObject.transform.localScale = Vector3.one * SCALE_FACTOR_HAND;
            cardObject.GetComponentInChildren<Outline>().enabled = false;
        }
    }
}
