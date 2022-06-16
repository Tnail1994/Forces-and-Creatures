using System.Linq;
using UnityEngine;

public class CardCreator : MonoBehaviour
{
    private ICardDatabaseService _cardDatabaseService = null;

    [SerializeField] GameObject Prefab;

    private void Awake()
    {
        if (_cardDatabaseService == null)
            _cardDatabaseService = new CardDatabaseService();
    }

    private void Start()
    {
        if (_cardDatabaseService == null) return;

        if (!_cardDatabaseService.CardsCreated)
        {
            _cardDatabaseService.CreateCards();
            var x = _cardDatabaseService.GetAllCards().ToList();

            var y = Instantiate(Prefab);
            var y1 = y.GetComponentInChildren<CreatureObject>();
            y1.Set((Creature)x[8]);
        }

    
    }
}
