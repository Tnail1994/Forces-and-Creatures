using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHand : MonoBehaviour
{
    internal float SCALE_FACTOR_HAND = 0.375f;

    private List<GameObject> _hand;

    private void Awake()
    {
        _hand = new List<GameObject>();
    }

    public List<GameObject> Hand { get => _hand; }

}
