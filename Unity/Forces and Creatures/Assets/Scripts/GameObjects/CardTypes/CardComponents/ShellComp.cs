using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShellComp : MonoBehaviour
{
    private Text _description;

    public string Description { get => _description.text; set => _description.text = value; }
    public int FontSize { get; set; }

    private void Awake()
    {
        _description = GetComponentInChildren<Text>();
        FontSize = _description.cachedTextGenerator.fontSizeUsedForBestFit;
    }
}
