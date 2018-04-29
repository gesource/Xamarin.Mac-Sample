using System;

using AppKit;
using Foundation;

namespace NSWindowWillClose
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

		public override void ViewDidLayout()
		{
            base.ViewDidLayout();
            View.Window.WillClose += Window_WillClose;
		}

		void Window_WillClose(object sender, EventArgs e)
        {
            if (CheckBox.State == NSCellStateValue.On)
            {
                NSApplication.SharedApplication.Terminate(this);
            }
        }

    }
}
