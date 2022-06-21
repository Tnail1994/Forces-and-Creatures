using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class State 
{
    public List<CustomAction> _actions;

    

    public void Tick(float d)
    {
        for (int i = 0; i < _actions.Count; i++)
        {
            _actions[i].Execute(d);
        }
    }

    internal void AddAction(CustomAction customAction)
    {
        if (_actions == null) _actions = new List<CustomAction>();
        
        _actions.Add(customAction); 
    }
}
