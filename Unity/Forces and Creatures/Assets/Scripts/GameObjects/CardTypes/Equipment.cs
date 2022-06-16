public class Equipment : Card
{
    public EquipmentCategory Category { get; set; }    
    public int Value { get; set; }

    public Equipment(int id, int cost, int stars, string name, string description, string storyDescription, CardColor color, EquipmentCategory equipmentCategory) 
        : base(id, cost, stars, name, description, storyDescription, color)
    {
        Category = equipmentCategory;
    }
}
