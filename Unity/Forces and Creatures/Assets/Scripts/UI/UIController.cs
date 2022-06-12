public class UIController
{
    private VersionUpdateControl _versionUpdateControl;

    public bool IsUpToDate { get; internal set; }

    public void UpdateVersion()
    {
        if (_versionUpdateControl == null)
            _versionUpdateControl = new VersionUpdateControl();

        if (_versionUpdateControl.VersionIsLatestUpdate())
        {
            IsUpToDate = _versionUpdateControl.UpdateVersion();
        }
    }
}
