using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using UnityEngine;

public class CardDatabaseService : ICardDatabaseService
{
    #region Constant paths
    string RESOURCE_CARDS_JSON_FILE = @"C:\Users\Stefan\Documents\GitHub\Forces-and-Creatures\Data\Cards\ResourceCards.json";
    string EQUIPMENT_CARDS_JSON_FILE = @"C:\Users\Stefan\Documents\GitHub\Forces-and-Creatures\Data\Cards\EquipmentCards.json";
    string CREATURE_CARDS_JSON_FILE = @"C:\Users\Stefan\Documents\GitHub\Forces-and-Creatures\Data\Cards\CreatureCards.json";
    string MAGIC_CARDS_JSON_FILE = @"C:\Users\Stefan\Documents\GitHub\Forces-and-Creatures\Data\Cards\MagicCards.json";
    #endregion
    private CardDatabase _cards = null;

    public bool CardsCreated {get; private set;}    

    public void CreateCards()
    {
        if (_cards != null) return;

        _cards = new CardDatabase();

        CreateResourceCards();
        CreateEquipmentCards();
        CreateCreatureCards();
        CreateMagicCards();

        CardsCreated = true;
    }
    private void CreateResourceCards()
    {
        _cards.Resources =
            JsonConvert.DeserializeObject<List<Resource>>(File.ReadAllText(RESOURCE_CARDS_JSON_FILE));
    }
    private void CreateEquipmentCards()
    {
        _cards.Equipments =
            JsonConvert.DeserializeObject<List<Equipment>>(File.ReadAllText(EQUIPMENT_CARDS_JSON_FILE));
    }
    private void CreateCreatureCards()
    {
        _cards.Creatures=
            JsonConvert.DeserializeObject<List<Creature>>(File.ReadAllText(CREATURE_CARDS_JSON_FILE));
    }
    private void CreateMagicCards()
    {
        _cards.Magics =
            JsonConvert.DeserializeObject<List<Magic>>(File.ReadAllText(MAGIC_CARDS_JSON_FILE));
    }

    public IEnumerable<Card> GetAllCards()
    {
        return new List<Card>().Concat(_cards.Resources).Concat(_cards.Equipments).Concat(_cards.Creatures).Concat(_cards.Magics);
    }

    public Card GetCardByName(string name)
    {
        foreach (var card in GetAllCards())
        {
            if (card.Name == name)
            {
                return card;
            }
        }

        return null;
    }

    public Card GetCardById(int id)
    {
        throw new System.NotImplementedException();
    }

    public void DeleteCards()
    {
        _cards.Resources.Clear();
        _cards.Equipments.Clear();
        _cards.Creatures.Clear();
        _cards.Magics.Clear();

        CardsCreated = false;
    }

    public void UpdateCard(Card card)
    {
        throw new System.NotImplementedException();
    }

    public void UpdateCard(Card card, string name)
    {
        throw new System.NotImplementedException();
    }

    public void DeleteCard(Card card)
    {
        throw new System.NotImplementedException();
    }   
}
