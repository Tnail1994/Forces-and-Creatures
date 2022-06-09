using Assets.Scripts.GameObjects;
using UnityEngine;

class Card : MonoBehaviour, ICard
{
    internal int _id;
    internal int _cost;
    internal int _stars;
    internal string _name;
    internal string _description;
    internal string _storyDescription;
    internal CardColor _color;

    public Card(int id, int cost, int stars, string name, string description,string storyDescription, CardColor color)
    {
        _id = id;
        _cost = cost;
        _stars = stars;
        _name = name;
        _storyDescription = storyDescription;
        _color = color;
    }
}
