using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResourceObject : MonoBehaviour
{
    private GameObject _header;
    private GameObject _image;
    private GameObject _shell;

    public Resource ResourceCard { get; set; }

    private void Awake()
    {
        _header = GameObject.Find(CardObjects.Header.ToString());
        _image = GameObject.Find(CardObjects.Image.ToString());
        _shell = GameObject.Find(CardObjects.Shell.ToString());
    }
    public void SetCard(Resource resourceCard)
    {
        switch (resourceCard.Category)
        {
            case ResourceCategory.Gold:
                CreateGoldCard(resourceCard);
                break;
            case ResourceCategory.Mana:
                CreateManaCard(resourceCard);
                break;
            default:
                break;
        }
    }

    #region Creating specific card
    private void CreateManaCard(Resource resourceCard)
    {
        throw new NotImplementedException();
    }

    private void CreateGoldCard(Resource resourceCard)
    {
        throw new NotImplementedException();
    }

    #endregion
}
