using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class PlayButtonBehaviour : MonoBehaviour
{
    private Button _playButton;
    
    private void Awake()
    {
        _playButton = GetComponent<Button>();
        _playButton.onClick.AddListener(StartGame);
    }

    private void StartGame()
    {
        // Which game?
        GameLoader.LoadGame(GameLoader.Game.Game);
    }
}
