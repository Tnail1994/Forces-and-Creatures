using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardObject : MonoBehaviour, IClickBehaviour
{
    private GameObject _gameComponentManagerObject;
    private GameComponentManager _gameComponentManager;

    internal GameObject _header;
    internal GameObject _image;
    internal GameObject _shell;
    internal GameObject _backSide;

    [SerializeField] public bool _backIsVisible;

    ICardPlacementBehaviour _currentCardPlacementBehaviour;

    internal bool BackIsVisible
    {
        get => _backIsVisible;
        set
        {
            _backIsVisible = value;
            FlipCard();
        }
    }

    private void Awake()
    {
        _gameComponentManagerObject = GameObject.Find("GameComponentManager");
        _gameComponentManager = _gameComponentManagerObject.GetComponent<GameComponentManager>();
    }


    internal void FlipCard()
    {
        _backSide.GetComponent<Image>().enabled = BackIsVisible;
        _image.GetComponent<Image>().enabled = !BackIsVisible;
    }

    public virtual void Click()
    {
        _currentCardPlacementBehaviour = GetComponentInParent<ICardPlacementBehaviour>();
        _currentCardPlacementBehaviour.OnClick(this);
    }

    public virtual void Highlight()
    {
        _currentCardPlacementBehaviour = GetComponentInParent<ICardPlacementBehaviour>();
        _currentCardPlacementBehaviour.OnHighlight(this);       
    }

    public void OnMouseExit()
    {
        RemoveHighlight();
    }

    public void RemoveHighlight()
    {
        _currentCardPlacementBehaviour = GetComponentInParent<ICardPlacementBehaviour>();
        _currentCardPlacementBehaviour.OnRemoveHighlight(this);
    }   
}
