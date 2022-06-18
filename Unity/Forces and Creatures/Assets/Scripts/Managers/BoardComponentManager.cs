using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardComponentManager : MonoBehaviour
{
    private GameObject _player1_Deck;
    private GameObject _player2_Deck;
    private GameObject _playerHand;
    private GameObject _enemyHand;

    private void Awake()
    {
        FindGameComponents();
        EnableGameComponents();
    }

    private void FindGameComponents()
    {
        _player1_Deck = GameObject.Find(BoardComponent.Player1_Deck.ToString());
        _player2_Deck = GameObject.Find(BoardComponent.Player2_Deck.ToString());
        _playerHand = GameObject.Find(BoardComponent.PlayerHand.ToString());
        _enemyHand = GameObject.Find(BoardComponent.EnemyHand.ToString());
    }

    private void EnableGameComponents()
    {
        Player1_Deck.enabled = true;
        Player2_Deck.enabled = true;
        PlayerHand.enabled = true;
        EnemyHand.enabled = true;
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

    public PlayerHand PlayerHand
    {
        get
        {
            if (_playerHand == null)
                _playerHand = GameObject.Find(BoardComponent.PlayerHand.ToString());

            return _playerHand.GetComponent<PlayerHand>();
        }
    }

    public EnemyHand EnemyHand
    {
        get
        {
            if (_enemyHand == null)
                _enemyHand = GameObject.Find(BoardComponent.EnemyHand.ToString());

            return _enemyHand.GetComponent<EnemyHand>();
        }
    }

}
