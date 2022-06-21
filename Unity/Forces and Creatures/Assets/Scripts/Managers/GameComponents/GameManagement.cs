using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagement : MonoBehaviour
{
    private State _currentState;

    private void Awake()
    {
        _currentState = new State();

        AddCustomAction();
       
    }

    private void AddCustomAction()
    {
        _currentState.AddAction(new MouseOverDetection());
        _currentState.AddAction(new MouseClickDetection());
    }

    private void Update()
    {
        _currentState.Tick(Time.deltaTime);
    }
}
