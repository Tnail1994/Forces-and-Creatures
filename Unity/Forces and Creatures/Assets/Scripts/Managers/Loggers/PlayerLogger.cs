using UnityEngine;

public class PlayerLogger : Logable
{
    [SerializeField] private string _useText = "Do some Action!";

    public string UseText => _useText;

    internal override void DisplayText()
    {
        Debug.Log($"{name} : Click F To {UseText}");
    }
}
