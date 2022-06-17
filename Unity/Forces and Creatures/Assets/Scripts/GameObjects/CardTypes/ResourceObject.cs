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
    public void Set(Resource resourceCard)
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
        SetBase(resourceCard);
        SetBackgroundMana(resourceCard);

    }

    private void CreateGoldCard(Resource resourceCard)
    {
        SetBase(resourceCard);
        SetBackgroundGold(resourceCard);
    }
    private void SetBase(Resource resourceCard)
    {
        SetHeader(resourceCard);
        SetImage(resourceCard);
        SetShell($"<b>[Ressource, {resourceCard.Category}]:</b>{ resourceCard.Description}");
    }

    private void SetBackgroundMana(Resource resourceCard)
    {
        SetBackground(BackgroundImgName.ManaBackgroundObject_E1.ToString());
    }

    private void SetBackgroundGold(Resource resourceCard)
    {
        SetBackground(BackgroundImgName.GoldBackgroundObject_E1.ToString());
    }

    private void SetHeader(Resource resourceCard)
    {
        var headerComp = _header.GetComponent<HeaderComp>();
        headerComp.Name = resourceCard.Name;
        headerComp.Costs = resourceCard.Cost.ToString();
        headerComp.SetStars(resourceCard.Stars);
    }

    private void SetImage(Resource resourceCard)
    {
        var imageComp = _image.GetComponent<ImageComp>();
        imageComp.Sprite = Resources.Load<Sprite>("Imgs/ResourcePics/" + resourceCard.Category);
    }
    private void SetShell(string description)
    {
        var shellComp = _shell.GetComponent<ShellComp>();
        shellComp.Description = description;
    }
    private void SetBackground(string imgName)
    {
        var backgroundComp = GetComponent<Image>();
        backgroundComp.sprite = Resources.Load<Sprite>("Imgs/Objects/Backgrounds/" + imgName);
    }
    #endregion
}
