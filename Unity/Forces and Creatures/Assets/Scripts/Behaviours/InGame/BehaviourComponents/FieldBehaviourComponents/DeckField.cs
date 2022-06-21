using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class DeckField : MonoBehaviour, ICardPlacementBehaviour
{
    private GameObject _boardComponentManagerObject;
    private BoardComponentManager _boardComponentManager;

    private GameObject _gameComponentManagerObject;
    private GameComponentManager _gameComponentManager;

    private Outline _outline;
    private Image _image;

    private void Awake()
    {
        _boardComponentManagerObject = GameObject.Find("Board");
        _boardComponentManager = _boardComponentManagerObject.GetComponent<BoardComponentManager>();

        _gameComponentManagerObject = GameObject.Find("GameComponentManager");
        _gameComponentManager = _gameComponentManagerObject.GetComponent<GameComponentManager>();

        _outline = GetComponentInChildren<Outline>();
        _image = GetComponentInChildren<Image>();
    }

    public void OnClick(CardObject cardObject)
    {
        var deck = _boardComponentManager.Player1_Deck.Deck;
        var hand = _boardComponentManager.PlayerHand.Hand;

        var scaleFactor = _boardComponentManager.PlayerHand.SCALE_FACTOR_HAND;
        var cardWidth = _boardComponentManager.PlayerHand.CARD_WIDTH;

        var cardOnTopObject = deck.Last();
        cardOnTopObject = _gameComponentManager.SizeControl.RescaleGameObject(cardOnTopObject, scaleFactor);
        cardOnTopObject = _gameComponentManager.SizeControl.SetWidthOfGameObject(cardOnTopObject, cardWidth);
        cardOnTopObject.transform.SetParent(GameObject.Find(BoardComponent.PlayerHand.ToString()).transform, false);
        cardOnTopObject.layer = (int)LayerNumber.UI;

        var cardOnTop = cardOnTopObject.GetComponent<CardObject>();
        var backIsVisible = cardOnTop.BackIsVisible;
        cardOnTop.BackIsVisible = !backIsVisible;
        cardOnTop.FlipCard();

        hand.Add(deck.Last());
        deck.RemoveAt(deck.Count - 1);
    }

    public void OnHighlight(CardObject cardObject)
    {
        _outline.enabled = true;
        _image.enabled = true;
    }

    public void OnRemoveHighlight(CardObject cardObject)
    {
        _outline.enabled = false;
        _image.enabled = false;
    } 
}
