using UnityEngine;

public class DeckCreator : MonoBehaviour
{
    private GameObject _gameComponentManagerObject;
    private GameComponentManager _gameComponentManager;

    public System.Action StarterDecksCreated { get; set; }

    private void Awake()
    {
        _gameComponentManagerObject = GameObject.Find("GameComponentManager");
        _gameComponentManager = _gameComponentManagerObject.GetComponent<GameComponentManager>();
    }

    void Start()
    {
        if (_gameComponentManager.CardCreator == null) return;

        InstantiateStarterDecks();
    }

    public void InstantiateStarterDecks()
    {
        _gameComponentManager.CardCreator.InstatiateCopy("Ein wenig Gold", "Player1_Deck");
        _gameComponentManager.CardCreator.InstatiateCopy("Ein wenig Gold", "Player1_Deck");
        _gameComponentManager.CardCreator.InstatiateCopy("Ein wenig Gold", "Player1_Deck");
        _gameComponentManager.CardCreator.InstatiateCopy("Ein wenig Gold", "Player1_Deck");
        _gameComponentManager.CardCreator.InstatiateCopy("Ein wenig Gold", "Player1_Deck");
        _gameComponentManager.CardCreator.InstatiateCopy("Ein wenig Gold", "Player1_Deck");
        _gameComponentManager.CardCreator.InstatiateCopy("Ein wenig Gold", "Player1_Deck");
        _gameComponentManager.CardCreator.InstatiateCopy("Kleine Manaessenz", "Player1_Deck");
        _gameComponentManager.CardCreator.InstatiateCopy("Kleine Manaessenz", "Player1_Deck");
        _gameComponentManager.CardCreator.InstatiateCopy("Kleine Manaessenz", "Player1_Deck");
        _gameComponentManager.CardCreator.InstatiateCopy("Schutzsph�re", "Player1_Deck");
        _gameComponentManager.CardCreator.InstatiateCopy("Schutzsph�re", "Player1_Deck");

        _gameComponentManager.CardCreator.InstatiateCopy("Ein wenig Gold", "Player2_Deck");
        _gameComponentManager.CardCreator.InstatiateCopy("Ein wenig Gold", "Player2_Deck");
        _gameComponentManager.CardCreator.InstatiateCopy("Ein wenig Gold", "Player2_Deck");
        _gameComponentManager.CardCreator.InstatiateCopy("Ein wenig Gold", "Player2_Deck");
        _gameComponentManager.CardCreator.InstatiateCopy("Ein wenig Gold", "Player2_Deck");
        _gameComponentManager.CardCreator.InstatiateCopy("Ein wenig Gold", "Player2_Deck");
        _gameComponentManager.CardCreator.InstatiateCopy("Ein wenig Gold", "Player2_Deck");
        _gameComponentManager.CardCreator.InstatiateCopy("Kleine Manaessenz", "Player2_Deck");
        _gameComponentManager.CardCreator.InstatiateCopy("Kleine Manaessenz", "Player2_Deck");
        _gameComponentManager.CardCreator.InstatiateCopy("Kleine Manaessenz", "Player2_Deck");
        _gameComponentManager.CardCreator.InstatiateCopy("Schutzsph�re", "Player2_Deck");
        _gameComponentManager.CardCreator.InstatiateCopy("Schutzsph�re", "Player2_Deck");

        StarterDecksCreated?.Invoke();
    }
}
