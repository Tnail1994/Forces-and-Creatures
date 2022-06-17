using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EquipmentObject : MonoBehaviour
{
    private GameObject _header;
    private GameObject _image;
    private GameObject _shell;
    private GameObject _attribute;

    public Equipment EquipmentCard { get; set; }

    private void Awake()
    {
        _header = GameObject.Find(CardObjects.Header.ToString());
        _image = GameObject.Find(CardObjects.Image.ToString());
        _shell = GameObject.Find(CardObjects.Shell.ToString());
        _attribute = GameObject.Find(CardObjects.Attributes.ToString());
    }
    public void Set(Equipment equipmentCard)
    {
        switch (equipmentCard.Category)
        {
            case EquipmentCategory.Attackpoint:
                CreateEquipmentAttackCard(equipmentCard);
                break;
            case EquipmentCategory.Lifepoint:
                CreateEquipmentLifeCard(equipmentCard);
                break;
        }
    }

    #region Creating specific card

    private void CreateEquipmentAttackCard(Equipment equipmentCard)
    {
        SetBase(equipmentCard);
        SetAttributeAttack(equipmentCard);
        SetShellAttack(equipmentCard);
    }

    private void CreateEquipmentLifeCard(Equipment equipmentCard)
    {
        SetBase(equipmentCard);
        SetAttributeLife(equipmentCard);
        SetShellLife(equipmentCard);
    }

    private void SetBase(Equipment equipmentCard)
    {
        SetHeader(equipmentCard);
        SetImage(equipmentCard);
        SetBackground(BackgroundImgName.EquipmentBackgroundObject_E1.ToString());
    }

    private void SetImage(Equipment equipmentCard)
    {
        var imageComp = _image.GetComponent<ImageComp>();
        imageComp.Sprite = Resources.Load<Sprite>("Imgs/EquipmentPics/Equipment");
    }

    private void SetHeader(Equipment equipmentCard)
    {
        var headerComp = _header.GetComponent<HeaderComp>();
        headerComp.Name = equipmentCard.Name;
        headerComp.Costs = equipmentCard.Cost.ToString();
        headerComp.SetStars(equipmentCard.Stars);
    }
    private void SetShell(string description)
    {
        var shellComp = _shell.GetComponent<ShellComp>();
        shellComp.Description = description;
    }

    private void SetShellLife(Equipment equipmentCard)
    {
        SetShell($"<b>[Ausrüstung, Verteidigung]:</b>{equipmentCard.Description}");
    }

    private void SetShellAttack(Equipment equipmentCard)
    {
        SetShell($"<b>[Ausrüstung, Angriff]:</b>{equipmentCard.Description}");
    }
    private void SetAttributeAttack(Equipment equipmentCard)
    {
        var attributesComp = _attribute.GetComponent<AttackpointsAttributeComp>();
        attributesComp.Attackpoints = equipmentCard.Value.ToString();

        DeactivateAttribute(equipmentCard);
    }

    private void SetAttributeLife(Equipment equipmentCard)
    {
        var attributesComp = _attribute.GetComponent<LifepointsAttributeComp>();
        attributesComp.Lifepoints = equipmentCard.Value.ToString();

        DeactivateAttribute(equipmentCard);
    }

    private void DeactivateAttribute(Equipment equipmentCard)
    {
        switch (equipmentCard.Category)
        {
            case EquipmentCategory.Attackpoint:
                var lifepointComp = _attribute.GetComponent<LifepointsAttributeComp>();
                lifepointComp.SetVisibilityMode(false);
                break;
            case EquipmentCategory.Lifepoint:
                var attackpointComp = _attribute.GetComponent<AttackpointsAttributeComp>();
                attackpointComp.SetVisibilityMode(false);
                break;
            default:
                break;
        }
    }
    private void SetBackground(string imgName)
    {
        var backgroundComp = GetComponent<Image>();
        backgroundComp.sprite = Resources.Load<Sprite>("Imgs/Objects/Backgrounds/" + imgName);
    }
    #endregion
}
