using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPlayerInputService 
{
    float Horizontal { get; }
    float Vertical { get; }
}
