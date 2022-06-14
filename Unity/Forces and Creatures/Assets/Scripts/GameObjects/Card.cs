using UnityEngine;

public class Card
{
    public int Id { get; set; }
    public int Cost { get; set; }
    public int Stars { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string StoryDescription { get; set; }
    public CardColor Color { get; set; }

    public Card(int id, int cost, int stars, string name, string description,string storyDescription, CardColor color)
    {
        Id = id;
        Cost = cost;
        Stars = stars;
        Name = name;
        Description = description;
        StoryDescription = storyDescription;
        Color = color;
    }
}
