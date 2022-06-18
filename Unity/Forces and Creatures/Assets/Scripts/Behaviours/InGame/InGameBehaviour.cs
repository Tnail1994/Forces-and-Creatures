using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameBehaviour : MonoBehaviour
{
    private IBehaviourComponent _behaviourComponent = null;

    private void Start()
    {
        _behaviourComponent = GetComponent<IBehaviourComponent>();

        if (_behaviourComponent == null) return;

        var targets = _behaviourComponent.GetBehaviours(transform);

        foreach (Transform target in targets)
        {
            Debug.Log(target.name);
        }
    }
}
