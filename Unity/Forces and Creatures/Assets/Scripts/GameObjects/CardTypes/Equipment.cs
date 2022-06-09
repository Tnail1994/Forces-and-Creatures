class Equipment : Card
{
    private EquipmentCategory _equipmentCategory;

    public Equipment(int id, int cost, int stars, string name, string description, string storyDescription, CardColor color, EquipmentCategory equipmentCategory) 
        : base(id, cost, stars, name, description, storyDescription, color)
    {
        _equipmentCategory = equipmentCategory;
    }
}
