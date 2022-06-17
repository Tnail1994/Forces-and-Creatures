using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ShuffleSystem : MonoBehaviour
{
    internal List<GameObject> Shuffle(List<GameObject> deck)
    {
        var rnd = new System.Random();
        var randomized = deck.OrderBy(item => rnd.Next());
        return randomized.ToList();
    }
}
