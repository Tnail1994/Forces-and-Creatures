public interface IPlayableSerive : IPlayerService
{
    void PlayCard(Card cardToPlay);

    void BlockAttack(Card cardToBlock);
}
