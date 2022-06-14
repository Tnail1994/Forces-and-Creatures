using UnityEngine;
using UnityEngine.UI;

public class HeaderComp : MonoBehaviour
{
    private Text Name;
    private Text Costs;
    private Text Stars;

    private void Awake()
    {
        var x = GetComponentsInChildren<TMP_Text>();

        Name = x[0];
        Costs = x[1];
        Stars = x[2];
    }
}
