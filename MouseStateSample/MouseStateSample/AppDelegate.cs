using AppKit;
using Foundation;

namespace MouseStateSample
{
    [Register("AppDelegate")]
    public partial class AppDelegate : NSApplicationDelegate
    {
        public ViewController ViewController { get; set; }
        public AppDelegate()
        {
        }

        public override void DidFinishLaunching(NSNotification notification)
        {
            // Insert code here to initialize your application
        }

        public override void WillTerminate(NSNotification notification)
        {
            // Insert code here to tear down your application
        }

        partial void MenuItemUpdateClick(AppKit.NSMenuItem sender)
        {
            ViewController?.ShowMouseState();
        }

    }
}
