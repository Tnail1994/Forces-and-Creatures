public interface IMasaUseService : IPlayerService
{
    int Mana { get; }
    int ManaField { get; }
    void SpendMana(int manaToSpend);
    void StackManaField(Resource resourceCardToStack);
}

