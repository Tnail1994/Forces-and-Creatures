using System.Collections.Generic;

public interface ICardDatabaseService
{
    bool CardsCreated { get; }
    void CreateCards();

    IEnumerable<Card> GetAllCards();
    Card GetCardByName(string name);
    Card GetCardById(int id);

    void DeleteCards();
    void UpdateCard(Card card);
    void UpdateCard(Card card, string name);
    void DeleteCard(Card card);

}
