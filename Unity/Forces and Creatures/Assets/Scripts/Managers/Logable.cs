using System;
using UnityEngine;

public abstract class Logable : MonoBehaviour
{
    [SerializeField] private new string name = "New Logable Name";
    [SerializeField] private string _description = "New Logable Description";

    internal abstract void DisplayText();
}
