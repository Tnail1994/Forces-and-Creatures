class Creature : Card
{
    private CreatureCategory _creatureCategory;
    private CardProperty _property;

    public Creature(int id, int cost, int stars, string name, string description, string storyDescription, CardColor color, CreatureCategory creatureCategory, CardProperty property)
        : base(id, cost, stars, name, description, storyDescription, color)
    {
        _creatureCategory = creatureCategory;
        _property = property;
    }
}
