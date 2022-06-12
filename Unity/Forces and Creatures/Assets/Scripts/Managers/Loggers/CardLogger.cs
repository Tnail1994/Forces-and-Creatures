using UnityEngine;

public class CardLogger : Logable
{
    [SerializeField] private string _useText = "Play Card!";

    public string UseText => _useText;

    internal override void DisplayText()
    {
        Debug.Log($"{name} : Click E To {UseText}");
    }
}
