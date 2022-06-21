using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardObject : MonoBehaviour, IClickBehaviour
{
    internal GameObject _header;
    internal GameObject _image;
    internal GameObject _shell;
    internal GameObject _backSide;

    [SerializeField] public bool _backIsVisible;

    internal bool BackIsVisible
    {
        get => _backIsVisible;
        set
        {
            _backIsVisible = value;
            FlipCard();
        }
    }

    internal void FlipCard()
    {
        _backSide.GetComponent<Image>().enabled = BackIsVisible;
        _image.GetComponent<Image>().enabled = !BackIsVisible;
    }

    public void Click()
    {
        if (this.gameObject.layer != (int)LayerNumber.IgnoreRaycast)
            Debug.Log($"You are clicking {this.name}");
    }

    public void Highlight()
    {
        if (this.gameObject.layer != (int)LayerNumber.IgnoreRaycast)
            Debug.Log($"You are over {this.name}");
    }
}
