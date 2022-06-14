using UnityEngine;

public class Logger : MonoBehaviour
{
    private void Start()
    {
        var logable = GetComponent<Logable>();

        if (logable == null) return;

        logable.DisplayText();
    }
}
