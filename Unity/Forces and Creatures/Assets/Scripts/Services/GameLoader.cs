using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameLoader
{
    public enum Game
    {
        Game,
        OfflineStandard,
        OnlineStandard
    }
    public static void LoadGame(Game game)
    {
        if(Enum.TryParse(game.ToString() + "Scene", out SceneLoader.Scene scene))
            SceneLoader.Load(scene);
    }   
}
