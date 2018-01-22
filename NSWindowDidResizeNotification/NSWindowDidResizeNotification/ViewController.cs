using System;

using AppKit;
using Foundation;

namespace NSWindowDidResizeNotification
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
            NSNotificationCenter.DefaultCenter.AddObserver(
                NSWindow.DidResizeNotification,
                (obj) =>
                {
                    PrintWindowSize();
                });
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

        public override void ViewWillAppear()
        {
            base.ViewWillAppear();
            PrintWindowSize();
        }

        /// <summary>
        /// ウィンドウサイズを表示します
        /// </summary>
        void PrintWindowSize()
        {
            var window = this.View.Window;
            LabelLeft.StringValue = $"Left:  {window.Frame.Left}";
            LabelTop.StringValue = $"Top:   {window.Frame.Top}";
            LabelWidth.StringValue = $"Width: {window.Frame.Width}";
            LabelHeight.StringValue = $"Height:{window.Frame.Height}";
        }

    }
}
