using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VersionUpdateControl
{
    public string _version;

    public bool VersionIsLatestUpdate()
    {
        return true;
    }

    public bool UpdateVersion()
    {
        Debug.Log("Is up to date. (Dummy)");
        return true;
    }
}
