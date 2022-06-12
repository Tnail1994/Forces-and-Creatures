using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class MainMenuStartPageLoader : MonoBehaviour, IUILoader
{
    public List<Transform> GetUIs(Transform transform)
    {
        return FindObjectsOfType<Transform>().ToList();
    }
}
