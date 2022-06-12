using UnityEngine;

public class TargetSystem : MonoBehaviour
{
    private ITargetGetter _targetGetter = null;

    private void Start()
    {
        _targetGetter = GetComponent<ITargetGetter>();

        if (_targetGetter != null) return;

        var targets = _targetGetter.GetTargets(transform);

        foreach (Transform target in targets)
        {
            Debug.Log(target.name);
        }
    }
}
