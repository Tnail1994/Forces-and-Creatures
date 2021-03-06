public class Resource : Card
{
    public ResourceCategory Category { get; set; }

    public int Value { get; set; }

    public Resource(int id, int cost, int stars, string name, string description, string storyDescription,  CardColor color, ResourceCategory category)
        : base(id,cost,stars,name,description,storyDescription,color)
    {       
        Category = category;
    }
}
