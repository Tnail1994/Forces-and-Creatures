class Equipment : Card
{
    public EquipmentCategory EquipmentCategory { get; set; }    
    public int Value { get; set; }

    public Equipment(int id, int cost, int stars, string name, string description, string storyDescription, CardColor color, EquipmentCategory equipmentCategory) 
        : base(id, cost, stars, name, description, storyDescription, color)
    {
        EquipmentCategory = equipmentCategory;
    }
}
