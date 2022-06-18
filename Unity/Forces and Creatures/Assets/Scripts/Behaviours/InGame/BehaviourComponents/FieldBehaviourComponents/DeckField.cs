using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeckField : MonoBehaviour
{
    private Button _deckButton;

    private void Awake()
    {
        _deckButton = GetComponent<Button>();
        _deckButton.onClick.AddListener(OnDeckClicked);
    }

    private void OnDeckClicked()
    {
        throw new NotImplementedException();
    }
}
