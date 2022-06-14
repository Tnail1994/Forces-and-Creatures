using System;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine.SceneManagement;

public static class SceneLoader
{
    public enum Scene
    {
        GameScene,
        LoadingScene,
        InGameUIScene,
        MainMenuUIScene,
        OfflineStandardScene
    }

    private static Action onLoaderCallback;

    public static void Load(Scene scene)
    {
        // Set the loader callback action to load the target scene
        onLoaderCallback = () =>
        {
            SceneManager.LoadSceneAsync(scene.ToString());
        };

        //Load the loading scene
        SceneManager.LoadScene(Scene.LoadingScene.ToString());
    }

    public static void LoaderCallback()
    {
        // Triggered after the first Update which lets the sceen refresh
        // Execute the loader callback action which will load the target scene

        if (onLoaderCallback != null)
        {
            onLoaderCallback();
            onLoaderCallback = null;
        }
    }
}
