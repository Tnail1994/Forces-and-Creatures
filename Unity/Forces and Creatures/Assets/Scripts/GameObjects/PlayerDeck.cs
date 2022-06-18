using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PlayerDeck : MonoBehaviour
{
    #region Start Constants
    private const float SCALE_FACTOR_DECK = 0.2f;
    #endregion

    private GameObject _gameComponentManagerObject;
    private GameComponentManager _gameComponentManager;

    private List<GameObject> _deck;

    private void Awake()
    {
        _gameComponentManagerObject = GameObject.Find("GameComponentManager");
        _gameComponentManager = _gameComponentManagerObject.GetComponent<GameComponentManager>();

        _gameComponentManager.DeckCreator.StarterDecksCreated += CreateDeckList;

        _deck = new List<GameObject>();
    }

    private void CreateDeckList()
    {
        _deck = GameObject.FindGameObjectsWithTag($"{name}").ToList();
        _deck = _gameComponentManager.ShuffleSystem.Shuffle(_deck);
        _deck = _gameComponentManager.FlipControl.FlipDeck(_deck);
        _deck = _gameComponentManager.SizeControl.RescaleGameObjects(_deck, SCALE_FACTOR_DECK);
    }

    public List<GameObject> Deck { get => _deck; }
}
