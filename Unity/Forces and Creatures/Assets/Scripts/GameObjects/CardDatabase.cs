using System.Collections.Generic;
using System.Linq;

class CardDatabase
{
    public List<Resource> Resources { get; internal set; }
    public List<Equipment> Equipments { get; internal set; }
    public List<Creature> Creatures { get; internal set; }
    public List<Magic> Magics { get; internal set; }

    public CardDatabase()
    {
        Resources = new List<Resource>();
        Equipments = new List<Equipment>();
        Creatures = new List<Creature>();
        Magics = new List<Magic>(); 
    } 
}
