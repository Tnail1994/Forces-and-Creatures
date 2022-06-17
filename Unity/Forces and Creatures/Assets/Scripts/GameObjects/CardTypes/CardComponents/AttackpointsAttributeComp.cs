using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AttackpointsAttributeComp : MonoBehaviour
{
    private Text _attackpoints;
    public string Attackpoints { get => _attackpoints.text; set => _attackpoints.text = value; }

    private void Awake()
    {
        _attackpoints = GetComponentInChildren<Text>();
    }

    public void SetVisibilityMode(bool isActive)
    {
        gameObject.SetActive(isActive);
    }
}
