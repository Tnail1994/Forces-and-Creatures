using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManaAttributeComp : MonoBehaviour
{
    private Text _manaCosts;
    public string ManaCosts { get => _manaCosts.text; set => _manaCosts.text = value; }

    private void Awake()
    {
        _manaCosts = GetComponentInChildren<Text>();
    }
}
