using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CardCreator : MonoBehaviour
{
    private GameObject _gameComponentManagerObject;
    private GameComponentManager _gameComponentManager;

    private ICardDatabaseService _cardDatabaseService = null;

    private GameObject _prefabCreature;
    private GameObject _prefabMagic;
    private GameObject _prefabResource;
    private GameObject _prefabEquipment;

    private Dictionary<string, GameObject> _allCardsDictionary;

    private void Awake()
    {
        _gameComponentManagerObject = GameObject.Find("GameComponentManager");
        _gameComponentManager = _gameComponentManagerObject.GetComponent<GameComponentManager>();

        _cardDatabaseService = new CardDatabaseService();
        _allCardsDictionary = new Dictionary<string, GameObject>();

        _prefabCreature = Resources.Load<GameObject>("Prefabs/CreatureCard");
        _prefabMagic = Resources.Load<GameObject>("Prefabs/MagicCard");
        _prefabResource = Resources.Load<GameObject>("Prefabs/ResourceCard");
        _prefabEquipment = Resources.Load<GameObject>("Prefabs/EquipmentCard");

        _cardDatabaseService.CreateCards();

        foreach (var card in _cardDatabaseService.GetAllCards())
        {
            var cardObj = InstantiateCard(card, "AllCards");
            cardObj.name = card.Name;
            _allCardsDictionary.Add(card.Name, cardObj);
        }
    }


    private void Start()
    {
    }

    public GameObject InstantiateCard(string cardName, string position)
    {
        var cardFound = _cardDatabaseService.GetCardByName(cardName);

        return InstantiateCard(cardFound, position);
    }

    private GameObject InstantiateCard(Card card, string position)
    {
        if (card == null) return null;

        switch (card.Color)
        {
            case CardColor.Gold:
                return InstantiateResourceCard(card, position);
            case CardColor.Blue:
                return InstantiateMagicCard(card, position);
            case CardColor.LightBlue:
                return InstantiateResourceCard(card, position);
            case CardColor.White:
                return InstantiateMagicCard(card, position);
            case CardColor.Red:
                return InstantiateEquipmentCard(card, position);
            case CardColor.Brown:
                return InstantiateCreatureCard(card, position);
            case CardColor.LightBrown:
                return InstantiateCreatureCard(card, position);
            case CardColor.Green:
                return InstantiateMagicCard(card, position);
            default:
                return null;
        }
    }

    private GameObject InstantiateCreatureCard(Card cardFound, string position)
    {
        var card = Instantiate(_prefabCreature);

        card.transform.SetParent(GameObject.Find(position).transform, false);

        card.GetComponentInChildren<CreatureObject>().Set((Creature)cardFound);

        return card;
    }

    private GameObject InstantiateEquipmentCard(Card cardFound, string position)
    {
        var card = Instantiate(_prefabEquipment);

        card.transform.SetParent(GameObject.Find(position).transform, false);

        var equipmentObject = card.GetComponentInChildren<EquipmentObject>();
        equipmentObject.Set((Equipment)cardFound);

        return card;
    }

    private GameObject InstantiateMagicCard(Card cardFound, string position)
    {
        var card = Instantiate(_prefabMagic);

        card.transform.SetParent(GameObject.Find(position).transform, false);

        var magicObject = card.GetComponentInChildren<MagicObject>();
        magicObject.Set((Magic)cardFound);

        return card;
    }

    private GameObject InstantiateResourceCard(Card cardFound, string position)
    {
        var card = Instantiate(_prefabResource);

        card.transform.SetParent(GameObject.Find(position).transform, false);

        var resourceObject = card.GetComponentInChildren<ResourceObject>();
        resourceObject.Set((Resource)cardFound);

        return card;
    }

    internal void InstatiateCopy(string cardName, string position)
    {
        var cardCopy = Instantiate(_allCardsDictionary[cardName]);
        cardCopy.transform.SetParent(GameObject.Find(position).transform, false);
        cardCopy.tag = $"{position}";
    }
}
