using System.Collections.Generic;
using UnityEngine;

public interface IUILoader 
{
    List<Transform> GetUIs(Transform transform);
}
