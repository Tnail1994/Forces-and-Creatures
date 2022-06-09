class Resource : Card
{
    private ResourceCategory _resourceCategory;       

    public Resource(int id, int cost, int stars, string name, string description, string storyDescription,  CardColor color, ResourceCategory category)
        : base(id,cost,stars,name,description,storyDescription,color)
    {       
        _resourceCategory = category;
    }
}
