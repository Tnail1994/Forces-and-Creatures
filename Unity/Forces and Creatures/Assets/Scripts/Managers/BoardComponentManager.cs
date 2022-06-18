using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardComponentManager : MonoBehaviour
{
    private GameObject _player1_Deck;
    private GameObject _player2_Deck;

    private void Awake()
    {
        FindGameComponents();
        EnableGameComponents();
    }

    private void FindGameComponents()
    {
        _player1_Deck = GameObject.Find(BoardComponent.Player1_Deck.ToString());
        _player2_Deck = GameObject.Find(BoardComponent.Player2_Deck.ToString());
    }

    private void EnableGameComponents()
    {
        Player1_Deck.enabled = true;
        Player2_Deck.enabled = true;
    }

    public PlayerDeck Player1_Deck
    {
        get
        {
            if (_player1_Deck == null)
                _player1_Deck = GameObject.Find(BoardComponent.Player1_Deck.ToString());
            return _player1_Deck.GetComponent<PlayerDeck>();
        }
    }
    public PlayerDeck Player2_Deck
    {
        get
        {
            if (_player2_Deck == null)
                _player2_Deck = GameObject.Find(BoardComponent.Player2_Deck.ToString());
            return _player2_Deck.GetComponent<PlayerDeck>();
        }
    }

}
