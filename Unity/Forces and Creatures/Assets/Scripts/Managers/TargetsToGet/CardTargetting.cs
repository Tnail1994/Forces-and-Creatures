using Assets.Scripts.GameObjects;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardTargetting : MonoBehaviour, ITargetGetter
{
    public List<Transform> GetTargets(Transform transform)
    {
        var targets = new List<Transform>();

        var cards = transform.GetComponentsInChildren<Card>();

        foreach (var card in cards)
        {
            targets.Add(card.transform);
        }

        return targets;
    }
}
