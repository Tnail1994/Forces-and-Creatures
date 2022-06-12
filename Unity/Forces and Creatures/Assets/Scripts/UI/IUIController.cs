using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IUIController 
{
    List<Transform> GetUIControls(Transform transform);
}
