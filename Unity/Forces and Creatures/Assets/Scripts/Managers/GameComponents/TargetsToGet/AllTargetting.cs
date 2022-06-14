using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class AllTargetting : MonoBehaviour, ITargetGetter
{
    public List<Transform> GetTargets(Transform transform)
    {
        return FindObjectsOfType<Transform>().ToList();
    }
}
