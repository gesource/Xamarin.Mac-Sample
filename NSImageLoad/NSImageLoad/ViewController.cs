using System;
using System.IO;
using AppKit;
using Foundation;

namespace NSImageLoad
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

        partial void Button1Click(NSObject sender)
        {
            // Resourcesフォルダーの画像を読み込む
            var image = NSImage.ImageNamed("sample");
            ImageView.Image = image;
        }

        partial void Button2Click(NSObject sender)
        {
            // Resourcesフォルダーの画像のパス
            var path = NSBundle.MainBundle.PathForResource("sample", "png");
            // パスを指定して画像を読み込む
            var image = new NSImage(path);
            ImageView.Image = image;
        }

        partial void Button3Click(NSObject sender)
        {
            var url = new NSUrl("https://www.gesource.jp/image/face.gif");
            // URLを指定して画像を読み込む
            var image = new NSImage(url);
            ImageView.Image = image;
        }

        partial void Button4Click(NSObject sender)
        {
            // Base64エンコードされた画像データ
            var base64 = ToBase64String();
            var data = NSData.FromArray(Convert.FromBase64String(base64));
            var image = new NSImage(data);
            ImageView.Image = image;
        }

        /// <summary>
        /// Resources/sample.pngをBASE64エンコードします
        /// </summary>
        private static string ToBase64String()
        {
            var path = NSBundle.MainBundle.PathForResource("sample", "png");
            var bytes = File.ReadAllBytes(path);
            return Convert.ToBase64String(bytes);
        }
    }
}
