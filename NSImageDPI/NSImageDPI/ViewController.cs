using System;

using AppKit;
using CoreGraphics;
using Foundation;

namespace NSImageDPI
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

        partial void ButtonClick(NSButtonCell sender)
        {
            using (var panel = new NSOpenPanel())
            {
                panel.AllowsMultipleSelection = false;
                panel.CanChooseFiles = true;
                panel.CanChooseDirectories = false;
                panel.AllowedFileTypes = new[] { "png" };
                if (panel.RunModal() == 1)
                {
                    var filename = panel.Url.Path;
                    ShowImageInfo(filename);
                }
            }
        }

        private void ShowImageInfo(string filename)
        {
            var sb = new System.Text.StringBuilder();
            sb.AppendLine($"Filename: {filename}");

            var nsImage = new NSImage(filename);
            // 画像サイズ
            sb.AppendLine($"NSImage.Size: {nsImage.Size.Width} {nsImage.Size.Height}");

            //var nsImageRep = NSImageRep.ImageRepFromFile(filename);
            var nsImageRep = NSBitmapImageRep.ImageRepsWithData(nsImage.AsTiff())[0];
            // 画像サイズ
            sb.AppendLine($"NSImageRep.Size: {nsImageRep.Size.Width} {nsImageRep.Size.Height}");
            // ピクセル数
            sb.AppendLine($"NSImageRep.Pixels: {nsImageRep.PixelsWide} {nsImageRep.PixelsHigh}");

            // DPI
            var dpi = Math.Ceiling((72.0 * nsImageRep.PixelsWide) / nsImageRep.Size.Width);
            sb.AppendLine($"DPI = {dpi:F4}");

            Label.StringValue = sb.ToString();
        }
    }
}
