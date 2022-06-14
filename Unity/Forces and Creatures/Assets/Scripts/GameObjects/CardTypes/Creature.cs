public class Creature : Card
{
    public int Attackpoints { get; set; }
    public int Lifepoints { get; set; }
    public int ManaCosts { get; set; }
    public CreatureCategory Category { get; set; }
    public CardProperty Property { get; set; }

    public Creature(int id, int cost, int stars, string name, string description, string storyDescription, CardColor color, CreatureCategory creatureCategory, CardProperty property)
        : base(id, cost, stars, name, description, storyDescription, color)
    {
        Category = creatureCategory;
        Property = property;
    }
}
