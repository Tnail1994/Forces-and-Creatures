using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageComp : MonoBehaviour
{
    private Image _image;

    public Sprite Sprite { get => _image.sprite; set => _image.sprite = value; }

    private void Awake()
    {
        _image = GetComponent<Image>();
    }
}
