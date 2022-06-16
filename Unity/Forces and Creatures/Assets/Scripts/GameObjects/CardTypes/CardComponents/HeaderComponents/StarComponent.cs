using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarComponent : MonoBehaviour
{
    private Image _starImg;

    public bool IsActiveStar { get; set; }

    public Sprite Image { get => _starImg.sprite; set => _starImg.sprite = value; }

    private void Awake()
    {
        _starImg = GetComponent<Image>();
    }
}
