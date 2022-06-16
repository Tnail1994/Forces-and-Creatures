public class Magic : Card
{
    public int ManaCosts { get; set; }
    public MagicCategory Category { get; set; }
    public CardProperty Property { get; set; }

    public Magic(int id, int cost, int stars, string name, string description, string storyDescription, CardColor color, MagicCategory magicCategory, CardProperty property) 
        : base(id, cost, stars, name, description, storyDescription, color)
    {
        Category = magicCategory;
        Property = property;
    }
}
