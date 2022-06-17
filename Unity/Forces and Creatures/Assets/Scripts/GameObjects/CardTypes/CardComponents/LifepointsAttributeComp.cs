using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifepointsAttributeComp : MonoBehaviour
{
    private Text _lifepoints;
    public string Lifepoints { get => _lifepoints.text; set => _lifepoints.text = value; }

    private void Awake()
    {
        _lifepoints = GetComponentInChildren<Text>();
    }
    public void SetVisibilityMode(bool isActive)
    {
        gameObject.SetActive(isActive);
    }
}
