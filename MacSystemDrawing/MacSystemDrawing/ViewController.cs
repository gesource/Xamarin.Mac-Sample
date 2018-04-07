using System;
using System.DrawingCore;
using AppKit;
using CoreGraphics;
using Foundation;

namespace MacSystemDrawing
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
            Button.Activated += Button_Activated;
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

        void Button_Activated(object sender, EventArgs e)
        {
            var image = new NSImage(new CGSize(300, 100));
            image.LockFocus();
            var path = NSBezierPath.FromOvalInRect(new CGRect(new CGPoint(0, 0), new CGSize(300, 100)));
            NSColor.Red.Set();
            path.Fill();
            image.UnlockFocus();

            var bmprep = new NSBitmapImageRep(image.CGImage);
            var data = bmprep.RepresentationUsingTypeProperties(NSBitmapImageFileType.Bmp);
            var bitmap = new Bitmap(data.AsStream());

            var folder = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            var filename = System.IO.Path.Combine(folder, "test.bmp");
            bitmap.Save(filename);
        }

    }
}
