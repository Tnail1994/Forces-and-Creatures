using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameComponentManager : MonoBehaviour
{
    private GameObject _cardCreator;
    private GameObject _targetSystem;
    private GameObject _logger;
    private GameObject _deckCreator;
    private GameObject _shuffleSystem;
    private GameObject _sizeControl;
    private GameObject _flipControl;

    private void Awake()
    {
        FindGameComponents();
        EnableGameComponents();
    }

    private void FindGameComponents()
    {
        _cardCreator = GameObject.Find(GameComponent.CardCreator.ToString());
        _deckCreator = GameObject.Find(GameComponent.DeckCreator.ToString());
        _targetSystem = GameObject.Find(GameComponent.TargetSystem.ToString());
        _logger = GameObject.Find(GameComponent.Logger.ToString());
        _shuffleSystem = GameObject.Find(GameComponent.ShuffleSystem.ToString());
        _sizeControl = GameObject.Find(GameComponent.SizeControl.ToString());
        _flipControl = GameObject.Find(GameComponent.FlipControl.ToString());
    }

    private void EnableGameComponents()
    {
        CardCreator.enabled = true;
        DeckCreator.enabled = true;
        SizeControl.enabled = true;
        ShuffleSystem.enabled = true;
        Logger.enabled = true;
        TargetSystem.enabled = true;
        FlipControl.enabled = true;
    }

    public CardCreator CardCreator
    {
        get
        {
            if (_cardCreator == null)
                _cardCreator = GameObject.Find(GameComponent.CardCreator.ToString());
            return _cardCreator.GetComponent<CardCreator>();
        }
    }
    public DeckCreator DeckCreator
    {
        get
        {
            if (_deckCreator == null)
                _deckCreator = GameObject.Find(GameComponent.DeckCreator.ToString());
            return _deckCreator.GetComponent<DeckCreator>();
        }
    }
    public SizeControl SizeControl
    {
        get
        {
            if (_sizeControl == null)
                _sizeControl = GameObject.Find(GameComponent.SizeControl.ToString());
            return _sizeControl.GetComponent<SizeControl>();
        }
    }
    public FlipControl FlipControl
    {
        get
        {
            if (_flipControl == null)
                _flipControl = GameObject.Find(GameComponent.FlipControl.ToString());
            return _flipControl.GetComponent<FlipControl>();
        }
    }
    public ShuffleSystem ShuffleSystem
    {
        get
        {
            if (_shuffleSystem == null)
                _shuffleSystem = GameObject.Find(GameComponent.ShuffleSystem.ToString());
            return _shuffleSystem.GetComponent<ShuffleSystem>();
        }
    }
    public Logger Logger
    {
        get
        {
            if (_logger == null)
                _logger = GameObject.Find(GameComponent.Logger.ToString());
            return _logger.GetComponent<Logger>();
        }
    }
    public TargetSystem TargetSystem
    {
        get
        {
            if (_targetSystem == null)
                _targetSystem = GameObject.Find(GameComponent.TargetSystem.ToString());
            return _targetSystem.GetComponent<TargetSystem>();

        }
    }
    private void Start()
    {
        //_deckCreator.GetComponent<DeckCreator>().InstantiateStarterDecks();
    }
}
