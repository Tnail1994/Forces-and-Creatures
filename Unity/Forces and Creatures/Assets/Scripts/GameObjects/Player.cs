using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Player : MonoBehaviour
{
    private GameObject _deckCreator;
    private GameObject _shuffleSystem;

    private List<GameObject> _deck;

    private void Awake()
    {
        _deckCreator = GameObject.Find(GameComponent.DeckCreator.ToString());
        _deckCreator.GetComponent<DeckCreator>().StarterDecksCreated += CreateDeckDictionary;

        _shuffleSystem = GameObject.Find(GameComponent.ShuffleSystem.ToString());

        _deck = new List<GameObject>();
    }

    private void CreateDeckDictionary()
    {
        _deck = GameObject.FindGameObjectsWithTag($"{name}_Deck").ToList();
        _deck = _shuffleSystem.GetComponent<ShuffleSystem>().Shuffle(_deck);
    }
}
