using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGameService : MonoBehaviour
{
    private UIController _uiController = null;
    private void Awake()
    {
        // Here is the beginning of all!
        // Load GameUI, MainMenu
        _uiController = new UIController();

        if (_uiController == null) return;
        
        _uiController.UpdateVersion();

        Debug.Log("Loading Main Menu Scene");
        SceneLoader.Load(SceneLoader.Scene.MainMenuUIScene);       
    }
}
