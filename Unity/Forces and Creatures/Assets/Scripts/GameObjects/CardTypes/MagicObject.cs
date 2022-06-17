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
    private GameObject _attribute;

    public Magic MagicCard { get; set; }

    private void Awake()
    {
        _header = GetComponentInChildren<HeaderComp>().gameObject;
        _image = GetComponentInChildren<ImageComp>().gameObject;
        _shell = GetComponentInChildren<ShellComp>().gameObject;
        _attribute = GetComponentInChildren<ManaAttributeComp>().gameObject;
    }
    public void Set(Magic magicCard)
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
        SetBase(magicCard);
        SetShellEffectNormal(magicCard);
        SetBackgroundNormal(magicCard);
    }

    private void CreatePermanentMagicCard(Magic magicCard)
    {
        SetBase(magicCard);
        SetShellEffectPermanent(magicCard);
        SetBackgroundPermanent(magicCard);

    }

    private void CreateReactionMagicCard(Magic magicCard)
    {
        SetBase(magicCard);
        SetShellEffectReaction(magicCard);
        SetBackgroundReaction(magicCard);

    }
    private void SetBase(Magic magicCard)
    {
        SetHeader(magicCard);
        SetImage(magicCard);
        SetAttribute(magicCard);
    }

    private void SetHeader(Magic magicCard)
    {
        var headerComp = _header.GetComponent<HeaderComp>();
        headerComp.Name = magicCard.Name;
        headerComp.Costs = magicCard.Cost.ToString();
        headerComp.SetStars(magicCard.Stars);
    }

    private void SetImage(Magic magicCard)
    {
        var imageComp = _image.GetComponent<ImageComp>();
        imageComp.Sprite = Resources.Load<Sprite>("Imgs/MagicPics/" + magicCard.Name);
    }

    private void SetAttribute(Magic magicCard)
    {
        var attributesComp = _attribute.GetComponent<ManaAttributeComp>();
        attributesComp.ManaCosts = magicCard.ManaCosts.ToString();
    }
    private void SetShellEffectNormal(Magic magicCard)
    {
        SetShell($"<b>[Normal, {magicCard.Property}]:</b>{magicCard.Description}");
    }
    private void SetShellEffectPermanent(Magic magicCard)
    {
        SetShell($"<b>[Permanent, {magicCard.Property}]:</b>{magicCard.Description}");
    }
    private void SetShellEffectReaction(Magic magicCard)
    {
        SetShell($"<b>[Reaktion, {magicCard.Property}]:</b>{magicCard.Description}");
    }

    private void SetShell(string description)
    {
        var shellComp = _shell.GetComponent<ShellComp>();
        shellComp.Description = description;
    }

    private void SetBackgroundNormal(Magic magicCard)
    {
        SetBackground(BackgroundImgName.MagicNormalBackgroundObject_E1.ToString());
    }
    private void SetBackgroundPermanent(Magic magicCard)
    {
        SetBackground(BackgroundImgName.MagicPermanentBackgroundObject_E1.ToString());
    }

    private void SetBackgroundReaction(Magic magicCard)
    {
        SetBackground(BackgroundImgName.MagicReactionBackgroundObject_E1.ToString());
    }

    private void SetBackground(string imgName)
    {
        var backgroundComp = GetComponent<Image>();
        backgroundComp.sprite = Resources.Load<Sprite>("Imgs/Objects/Backgrounds/" + imgName);
    }
    #endregion


}
