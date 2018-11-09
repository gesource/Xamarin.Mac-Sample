using System;
using AppKit;
using Foundation;

namespace CheckDeduplicateRunningSample
{
    [Register("AppDelegate")]
    public class AppDelegate : NSApplicationDelegate
    {
        public AppDelegate()
        {
        }

        public override void DidFinishLaunching(NSNotification notification)
        {
            var apps = NSRunningApplication.GetRunningApplications(NSBundle.MainBundle.BundleIdentifier);
            if (apps.Length > 1)
            {
                Console.WriteLine($"アプリケーションはすでに起動しています。");
                NSApplication.SharedApplication.Terminate(this);
            }
        }

        public override void WillTerminate(NSNotification notification)
        {
            // Insert code here to tear down your application
        }
    }
}
