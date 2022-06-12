using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UILoader : MonoBehaviour
{
    private IUILoader _uiLoader = null;
    private void Start()
    {
        _uiLoader = GetComponent<IUILoader>();

        if (_uiLoader != null) return;

        var uis = _uiLoader.GetUIs(transform);

        foreach (Transform ui in uis)
        {
            Debug.Log($"Getting UI: {ui.name}");
        }
    }
}