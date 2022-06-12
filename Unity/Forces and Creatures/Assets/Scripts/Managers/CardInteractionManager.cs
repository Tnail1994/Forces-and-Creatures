using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInteractionManager : MonoBehaviour
{
    private IPlayerInputService playerInputService = null;

    private void Awake()
    {
        playerInputService = GetComponent<IPlayerInputService>();
    }

    private void Update()
    {
        // if we select cards with horizontal and vertical cards, then use
        //playerInputService.Horizontal and playerInputService.Vertical
    }
}
