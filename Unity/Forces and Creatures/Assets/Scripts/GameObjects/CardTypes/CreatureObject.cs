using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreatureObject : CardObject
{
    private GameObject _attributes;

    private Creature _creatureCard;

    private void Awake()
    {
        _header = GetComponentInChildren<HeaderComp>().gameObject;
        _image = GetComponentInChildren<ImageComp>().gameObject;
        _shell = GetComponentInChildren<ShellComp>().gameObject;
        _attributes = GetComponentInChildren<AttributesComp>().gameObject;
        _backSide = GetComponentInChildren<BackSideComp>().gameObject;
        _backSide.GetComponent<Image>().enabled = false;
    }

    public void Set(Creature creatureCard)
    {
        _creatureCard = creatureCard;

        switch (creatureCard.Category)
        {
            case CreatureCategory.Effect:
                CreateCreatureEffectCard(creatureCard);
                break;
            case CreatureCategory.NoneEffect:
                CreateCreatureNoneEffectCard(creatureCard);
                break;
            default:
                break;
        }
    }

    #region Creating specific card

    private void CreateCreatureEffectCard(Creature creatureCard)
    {
        SetBase(creatureCard);
        SetShellEffect(creatureCard);
        SetBackgroundEffect(creatureCard);
    }

    private void CreateCreatureNoneEffectCard(Creature creatureCard)
    {
        SetBase(creatureCard);
        SetShellNoneEffect(creatureCard);
        SetBackgroundNoneEffect(creatureCard);
    }

    private void SetBase(Creature creatureCard)
    {
        SetHeader(creatureCard);
        SetImage(creatureCard);
        SetAttributes(creatureCard);
    }

    private void SetHeader(Creature creatureCard)
    {
        var headerComp = _header.GetComponent<HeaderComp>();
        headerComp.Name = creatureCard.Name;
        headerComp.Costs = creatureCard.Cost.ToString();
        headerComp.SetStars(creatureCard.Stars);
    }
    private void SetImage(Creature creatureCard)
    {
        var imageComp = _image.GetComponent<ImageComp>();
        imageComp.Sprite = Resources.Load<Sprite>("Imgs/CreaturePics/" + creatureCard.Name);
    }
    private void SetAttributes(Creature creatureCard)
    {
        var attributesComp = _attributes.GetComponent<AttributesComp>();
        attributesComp.Attackpoints = creatureCard.Attackpoints.ToString();
        attributesComp.Lifepoints = creatureCard.Lifepoints.ToString();
        attributesComp.ManaCosts = creatureCard.ManaCosts.ToString();
    }

    private void SetShellEffect(Creature creatureCard)
    {
        SetShell($"<b>[Kreatur, {creatureCard.Property}]:</b>{creatureCard.Description}");
    }

    private void SetShellNoneEffect(Creature creatureCard)
    {
        SetShell($"<b>[Kreatur, {creatureCard.Property}]:</b><i>{creatureCard.StoryDescription}</i>");
    }

    private void SetShell(string description)
    {
        var shellComp = _shell.GetComponent<ShellComp>();

        shellComp.Description = description;
    }

    private void SetBackgroundEffect(Creature creatureCard)
    {
        SetBackground(BackgroundImgName.CreatureEffectBackgroundObject_E1.ToString());
    }

    private void SetBackgroundNoneEffect(Creature creatureCard)
    {
        SetBackground(BackgroundImgName.CreatureNoneEffectBackgroundObject_E1.ToString());
    }
    private void SetBackground(string imgName)
    {
        var backgroundComp = GetComponent<Image>();
        backgroundComp.sprite = Resources.Load<Sprite>("Imgs/Objects/Backgrounds/" + imgName);
    }


    #endregion

    #region Behaviours
   
    #endregion

}
