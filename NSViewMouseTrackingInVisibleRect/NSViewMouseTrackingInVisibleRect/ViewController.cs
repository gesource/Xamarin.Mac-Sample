using System;

using AppKit;
using Foundation;

namespace NSViewMouseTrackingInVisibleRect
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
            var mainView = MainView as MainView;
            mainView.InVisibleRect = false;
            CheckBox.State = NSCellStateValue.Off;
            CheckBox.Activated += (sender, e) => mainView.InVisibleRect = (CheckBox.State == NSCellStateValue.On);
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
    }
}
