using System;
using System.Text;
using AppKit;
using Foundation;

namespace MacVersion
{
    public partial class ViewController : NSViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Do any additional setup after loading the view.
            PrintVersion();

            ButtonCheckVersioni.Activated += CheckVersion;
        }

        public override NSObject RepresentedObject
        {
            get
            {
                return base.RepresentedObject;
            }
            set
            {
                base.RepresentedObject = value;
                // Update the view, if already loaded.
            }
        }

        private void PrintVersion()
        {
            TextView.InsertText(new NSString(GetVersion()));
        }

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

        private void CheckVersion(object sender, EventArgs e)
        {
            var major = TextFieldMajor.IntValue;
            var minor = TextFieldMinor.IntValue;
            var patch = TextFieldPatchVersion.IntValue;
            var result = IsLaterVersion(major, minor, patch);

            var alert = new NSAlert();
            alert.MessageText = result.ToString();
            alert.RunSheetModal(this.View.Window);
        }

        /// <summary>
        /// MacOSのバージョンが指定バージョンより新しければtrue
        /// </summary>
        private static bool IsLaterVersion(int major, int minor, int patchVersion)
        {
            var version = new NSOperatingSystemVersion(major, minor, patchVersion);
            return NSProcessInfo.ProcessInfo.IsOperatingSystemAtLeastVersion(version);
        }

    }
}
