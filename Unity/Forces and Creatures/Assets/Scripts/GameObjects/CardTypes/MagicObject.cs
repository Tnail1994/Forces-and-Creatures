using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MagicObject : MonoBehaviour
{
    private GameObject _header;
    private GameObject _image;
    private GameObject _shell;
    private GameObject _attributes;

    public Magic MagicCard { get; set; }

    private void Awake()
    {
        _header = GameObject.Find(CardObjects.Header.ToString());
        _image = GameObject.Find(CardObjects.Image.ToString());
        _shell = GameObject.Find(CardObjects.Shell.ToString());
        _attributes = GameObject.Find(CardObjects.Attributes.ToString());
    }
    public void SetCard(Magic magicCard)
    {
        switch (magicCard.Category)
        {
            case MagicCategory.Normal:
                CreateNormalMagicCard(magicCard);
                break;
            case MagicCategory.Permanent:
                CreatePermanentMagicCard(magicCard);

                break;
            case MagicCategory.Reaction:
                CreateReactionMagicCard(magicCard);
                break;
            default:
                break;
        }  
    }

    #region Creating specific card

    private void CreateNormalMagicCard(Magic magicCard)
    {
        throw new NotImplementedException();
    }

    private void CreatePermanentMagicCard(Magic magicCard)
    {
        throw new NotImplementedException();
    }

    private void CreateReactionMagicCard(Magic magicCard)
    {
        throw new NotImplementedException();
    }

    #endregion


}
