using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AttributesComp : MonoBehaviour
{
    private Text _attackpoints;
    private Text _lifepoints;
    private Text _manaCosts;

    public string Attackpoints { get => _attackpoints.text; set => _attackpoints.text = value; }
    public string Lifepoints { get => _lifepoints.text; set => _lifepoints.text = value; }
    public string ManaCosts { get => _manaCosts.text; set => _manaCosts.text = value; }

    private void Awake()
    {
        var x = GetComponentsInChildren<Text>();

        _attackpoints = x[0];
        _lifepoints = x[1];
        _manaCosts = x[2];
    }
}
