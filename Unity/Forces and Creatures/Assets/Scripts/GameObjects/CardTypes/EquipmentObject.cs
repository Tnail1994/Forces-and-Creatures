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
    private GameObject _attributes;

    public Equipment EquipmentCard { get; set; }

    private void Awake()
    {
        _header = GameObject.Find(CardObjects.Header.ToString());
        _image = GameObject.Find(CardObjects.Image.ToString());
        _shell = GameObject.Find(CardObjects.Shell.ToString());
        _attributes = GameObject.Find(CardObjects.Attributes.ToString());
    }
    public void SetCard(Equipment equipmentCard)
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
        throw new NotImplementedException();
    }

    private void CreateEquipmentLifeCard(Equipment equipmentCard)
    {
        throw new NotImplementedException();
    }
    #endregion  
}
