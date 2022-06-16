using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameComponentManager : MonoBehaviour
{
    private GameObject _cardCreator;
    private GameObject _targetSystem;
    private GameObject _logger;

    private void Awake()
    {
        _cardCreator = GameObject.Find(GameComponent.CardCreator.ToString());
        _targetSystem = GameObject.Find(GameComponent.TargetSystem.ToString());
        _logger = GameObject.Find(GameComponent.Logger.ToString());
    }
}
