class Magic : Card
{
    private MagicCategory _magicCategory;
    private CardProperty _property;

    public Magic(int id, int cost, int stars, string name, string description, string storyDescription, CardColor color, MagicCategory magicCategory, CardProperty property) 
        : base(id, cost, stars, name, description, storyDescription, color)
    {
        _magicCategory = magicCategory;
        _property = property;
    }
}
