using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SizeControl : MonoBehaviour
{
    internal GameObject RescaleGameObject(GameObject gameObjectToRescale, float scalefactor)
    {
        gameObjectToRescale.transform.localScale = new Vector3(scalefactor, scalefactor, scalefactor);
        return gameObjectToRescale;
    }

    internal List<GameObject> RescaleGameObjects(List<GameObject> gameObjectsToRescale, float scalefactor)
    {
        var rescaledGameObject = new List<GameObject>();

        foreach (GameObject gameObjectToRescale in gameObjectsToRescale)
        {
            rescaledGameObject.Add(RescaleGameObject(gameObjectToRescale, scalefactor));
        }

        return rescaledGameObject;
    }

    internal GameObject SetWidthOfGameObject(GameObject gameObject, float width)
    {
        var rectTransform = gameObject.GetComponent<RectTransform>();
        rectTransform.sizeDelta = new Vector2(width, rectTransform.sizeDelta.y);
        return gameObject;
    }  
    
    internal GameObject SetHeigthOfGameObject(GameObject gameObject, float heigth)
    {
        var rectTransform = gameObject.GetComponent<RectTransform>();
        rectTransform.sizeDelta = new Vector2(rectTransform.sizeDelta.x, heigth);
        return gameObject;
    }
}
