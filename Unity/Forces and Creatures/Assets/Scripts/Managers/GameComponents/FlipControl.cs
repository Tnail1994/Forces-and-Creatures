using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipControl : MonoBehaviour
{
    internal List<GameObject> FlipDeck(List<GameObject> deck)
    {
        List<GameObject> flippedDeck = new List<GameObject>();

        foreach (var card in deck)
        {
            flippedDeck.Add(FlipCard(card));
        }

        return flippedDeck;
    }

    private GameObject FlipCard(GameObject card)
    {
        var cardObject = card.GetComponent<CardObject>();
        var backIsVisible = cardObject.BackIsVisible;
        cardObject.BackIsVisible = !backIsVisible;
        cardObject.FlipCard();
        return cardObject.gameObject;
    }
}
