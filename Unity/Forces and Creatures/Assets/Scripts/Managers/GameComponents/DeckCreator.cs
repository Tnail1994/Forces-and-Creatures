using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeckCreator : MonoBehaviour
{
    private CardCreator _cardCreator;

    public Action StarterDecksCreated { get; set; }

    private void Awake()
    {
        _cardCreator =
            GameObject.Find(GameComponent.CardCreator.ToString())
            .GetComponent<CardCreator>();
    }

    void Start()
    {
        if (_cardCreator == null) return;

        InstantiateStarterDecks();
    }

    public void InstantiateStarterDecks()
    {
        _cardCreator.InstatiateCopy("Ein wenig Gold", "Player1");
        _cardCreator.InstatiateCopy("Ein wenig Gold", "Player1");
        _cardCreator.InstatiateCopy("Ein wenig Gold", "Player1");
        _cardCreator.InstatiateCopy("Ein wenig Gold", "Player1");
        _cardCreator.InstatiateCopy("Ein wenig Gold", "Player1");
        _cardCreator.InstatiateCopy("Ein wenig Gold", "Player1");
        _cardCreator.InstatiateCopy("Ein wenig Gold", "Player1");
        _cardCreator.InstatiateCopy("Kleine Manaessenz", "Player1");
        _cardCreator.InstatiateCopy("Kleine Manaessenz", "Player1");
        _cardCreator.InstatiateCopy("Kleine Manaessenz", "Player1");
        _cardCreator.InstatiateCopy("Schutzsphäre", "Player1");
        _cardCreator.InstatiateCopy("Schutzsphäre", "Player1");

        _cardCreator.InstatiateCopy("Ein wenig Gold", "Player2");
        _cardCreator.InstatiateCopy("Ein wenig Gold", "Player2");
        _cardCreator.InstatiateCopy("Ein wenig Gold", "Player2");
        _cardCreator.InstatiateCopy("Ein wenig Gold", "Player2");
        _cardCreator.InstatiateCopy("Ein wenig Gold", "Player2");
        _cardCreator.InstatiateCopy("Ein wenig Gold", "Player2");
        _cardCreator.InstatiateCopy("Ein wenig Gold", "Player2");
        _cardCreator.InstatiateCopy("Kleine Manaessenz", "Player2");
        _cardCreator.InstatiateCopy("Kleine Manaessenz", "Player2");
        _cardCreator.InstatiateCopy("Kleine Manaessenz", "Player2");
        _cardCreator.InstatiateCopy("Schutzsphäre", "Player2");
        _cardCreator.InstatiateCopy("Schutzsphäre", "Player2");

        StarterDecksCreated?.Invoke();
    }
}
