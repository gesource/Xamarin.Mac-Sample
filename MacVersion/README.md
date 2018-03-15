# MacVersion

OSのバージョンによって使用するAPIを変えたいとき、OSのバージョンを確認する必要があります。

MacOSのバージョンを確認する方法を紹介します。

![](screen.png)

## MacOSのバージョンを取得する

    /// <summary>
    /// MacOSのバージョンを取得します
    /// </summary>
    private static string GetVersion()
    {
        var version = NSProcessInfo.ProcessInfo.OperatingSystemVersion;
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"Major: {version.Major}");
        sb.AppendLine($"Minor: {version.Minor}");
        sb.AppendLine($"PatchVersion: {version.PatchVersion}");
        return sb.ToString();
    }

## MacOSのバージョンが指定バージョンより新しいか

    /// <summary>
    /// MacOSのバージョンが指定バージョンより新しければtrue
    /// </summary>
    private static bool IsLaterVersion(int major, int minor, int patchVersion)
    {
        var version = new NSOperatingSystemVersion(major, minor, patchVersion);
        return NSProcessInfo.ProcessInfo.IsOperatingSystemAtLeastVersion(version);
    }
