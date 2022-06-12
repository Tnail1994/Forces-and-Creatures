public interface IDamageableService : IPlayerService
{
    int Health { get; }
    void DealDamage(int damageToDeal);

    void AddHealth(int healthToAdd);
}
