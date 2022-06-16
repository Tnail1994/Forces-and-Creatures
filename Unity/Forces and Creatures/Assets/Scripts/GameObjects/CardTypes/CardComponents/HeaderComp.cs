using UnityEngine;
using UnityEngine.UI;

public class HeaderComp : MonoBehaviour
{
    private Text _name;
    private Text _costs;
    private StarComponent[] _stars;

    public string Name { get => _name.text; set => _name.text = value; }
    public string Costs { get => _costs.text; set => _costs.text = value; }

    private void Awake()
    {
        var x = GetComponentsInChildren<Text>();

        _name = x[0];
        _costs= x[1];       

        _stars = GetComponentsInChildren<StarComponent>();
    }

    public void SetStars(int stars)
    {
        for (int i = 0; i < stars; i++)
        {
            _stars[i].IsActiveStar = true;
            _stars[i].Image = Resources.Load<Sprite>("Imgs/Objects/StarActiveObject");
        }
    }
}
