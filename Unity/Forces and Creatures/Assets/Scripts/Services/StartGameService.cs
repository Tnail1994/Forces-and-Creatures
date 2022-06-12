using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGameService : MonoBehaviour
{
    private UIController _uiController = null;
    private void Awake()
    {
        // Here is the beginning of all!
        _uiController = new UIController();

        if (_uiController == null) return;
        
        _uiController.UpdateVersion();

        if (_uiController.IsUpToDate)
        {
            Debug.Log("Loading Main Menu Scene");
            SceneLoader.Load(SceneLoader.Scene.MainMenuUIScene);
        }
    }
}
