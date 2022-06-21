using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class DeckField : MonoBehaviour, IClickBehaviour
{
    private GameObject _boardComponentManagerObject;
    private BoardComponentManager _boardComponentManager;

    private GameObject _gameComponentManagerObject;
    private GameComponentManager _gameComponentManager;

    private Button _deckButton;

  

    private void Awake()
    {
        _boardComponentManagerObject = GameObject.Find("Board");
        _boardComponentManager = _boardComponentManagerObject.GetComponent<BoardComponentManager>();

        _gameComponentManagerObject = GameObject.Find("GameComponentManager");
        _gameComponentManager = _gameComponentManagerObject.GetComponent<GameComponentManager>();

    }
  
    public void Click()
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

    public void Highlight()
    {
        Debug.Log("Hightlight Execute");
    }
}
