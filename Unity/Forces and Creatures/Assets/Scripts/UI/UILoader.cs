using UnityEngine;
using UnityEngine.SceneManagement;

public class UILoader : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F1))
        {
            if (SceneManager.GetSceneByName("UI").isLoaded == false)
                SceneManager.LoadSceneAsync("UI", LoadSceneMode.Additive);
            else
                SceneManager.UnloadSceneAsync("UI");
        }       
    }
}