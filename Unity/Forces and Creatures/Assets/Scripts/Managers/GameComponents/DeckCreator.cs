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
        _cardCreator.InstatiateCopy("Ein wenig Gold", "Player1_Deck");
        _cardCreator.InstatiateCopy("Ein wenig Gold", "Player1_Deck");
        _cardCreator.InstatiateCopy("Ein wenig Gold", "Player1_Deck");
        _cardCreator.InstatiateCopy("Ein wenig Gold", "Player1_Deck");
        _cardCreator.InstatiateCopy("Ein wenig Gold", "Player1_Deck");
        _cardCreator.InstatiateCopy("Ein wenig Gold", "Player1_Deck");
        _cardCreator.InstatiateCopy("Ein wenig Gold", "Player1_Deck");
        _cardCreator.InstatiateCopy("Kleine Manaessenz", "Player1_Deck");
        _cardCreator.InstatiateCopy("Kleine Manaessenz", "Player1_Deck");
        _cardCreator.InstatiateCopy("Kleine Manaessenz", "Player1_Deck");
        _cardCreator.InstatiateCopy("Schutzsphäre", "Player1_Deck");
        _cardCreator.InstatiateCopy("Schutzsphäre", "Player1_Deck");

        _cardCreator.InstatiateCopy("Ein wenig Gold", "Player2_Deck");
        _cardCreator.InstatiateCopy("Ein wenig Gold", "Player2_Deck");
        _cardCreator.InstatiateCopy("Ein wenig Gold", "Player2_Deck");
        _cardCreator.InstatiateCopy("Ein wenig Gold", "Player2_Deck");
        _cardCreator.InstatiateCopy("Ein wenig Gold", "Player2_Deck");
        _cardCreator.InstatiateCopy("Ein wenig Gold", "Player2_Deck");
        _cardCreator.InstatiateCopy("Ein wenig Gold", "Player2_Deck");
        _cardCreator.InstatiateCopy("Kleine Manaessenz", "Player2_Deck");
        _cardCreator.InstatiateCopy("Kleine Manaessenz", "Player2_Deck");
        _cardCreator.InstatiateCopy("Kleine Manaessenz", "Player2_Deck");
        _cardCreator.InstatiateCopy("Schutzsphäre", "Player2_Deck");
        _cardCreator.InstatiateCopy("Schutzsphäre", "Player2_Deck");

        StarterDecksCreated?.Invoke();
    }
}
