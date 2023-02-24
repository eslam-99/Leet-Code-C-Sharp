public class VersionControl
{
    private int firstBadVersion;

    public VersionControl(int firstBadVersion)
    {
        this.firstBadVersion = firstBadVersion;
    }

    public bool IsBadVersion(int version)
    {
        return version >= firstBadVersion;
    }
}