using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IBehaviourComponent
{
    List<Transform> GetBehaviours(Transform transform);

}
