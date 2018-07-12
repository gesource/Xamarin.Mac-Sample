using System;
using System.Diagnostics;
using AppKit;
using CoreGraphics;
using Foundation;
using ImageIO;

namespace ImageResize
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
            TextFieldWidth.IntValue = 128;
            TextFieldHeight.IntValue = 128;
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

        partial void OpenImageFileButtonClick(NSObject sender)
        {
            var panel = new NSOpenPanel
            {
                AllowsMultipleSelection = false,
                CanChooseFiles = true,
                CanChooseDirectories = false,
                AllowedFileTypes = new[] { "png", "gif", "bmp", "jpg" }
            };
            if (panel.RunModal() == 1)
                ImageView.Image = new NSImage(panel.Url.Path);
        }

        partial void SaveImageButtonClick(NSObject sender)
        {
            if (ImageView.Image == null)
                return;

            var panel = new NSSavePanel
            {
                CanCreateDirectories = true,
                ReleasedWhenClosed = true,
                AllowedFileTypes = new[] { "png" },
            };
            if (panel.RunModal() == 1)
            {
                SaveImageFile(panel.Url.Path);
            }
        }

        /// <summary>
        /// 元画像sourceをnewSizeに拡縮したPNGデータを返します
        /// </summary>
        private static NSData Resize(CGImage source, CGSize newSize)
        {
            // メモリ内のピクセルの各コンポーネントに使用するビット数
            nint bitsPerComponent = 8;
            // ビットマップの1行あたりに使用するメモリのバイト数
            // 値0を渡すと、自動的に値が計算されます
            nint bytesPerRow = 0;
            // 色空間
            var colorSpace = CGColorSpace.CreateDeviceRGB();
            var bitmapInfo = CGImageAlphaInfo.PremultipliedLast;
            using (var bitmapContext = new CGBitmapContext(
                            IntPtr.Zero,
                            (nint)newSize.Width,
                            (nint)newSize.Height,
                            bitsPerComponent,
                            bytesPerRow,
                            colorSpace,
                            bitmapInfo))
            {
                var rect = new CGRect(new CGPoint(0, 0), newSize);
                bitmapContext.DrawImage(rect, source);
                var cgImage = bitmapContext.ToImage();
                return ConvertImageToPng(cgImage);
            }
        }

        /// <summary>
        /// imageをPNGデータに変換します
        /// </summary>
        private static NSData ConvertImageToPng(CGImage image)
        {
            var storage = new NSMutableData();
            var dest = CGImageDestination.Create(storage, MobileCoreServices.UTType.PNG, imageCount: 1);
            dest.AddImage(image);
            dest.Close();
            return storage;
        }

        /// <summary>
        /// 作成する画像のサイズ。
        /// 縦横比を維持するときは、指定サイズ内に収まる大きさにする
        /// </summary>
        private CGSize GetNewImageSize()
        {
            var width = TextFieldWidth.IntValue;
            var height = TextFieldHeight.IntValue; ;
            if (CheckBoxAspectRatio.State != NSCellStateValue.On)
                return new CGSize(width, height);

            var imageWidth = ImageView.Image.Size.Width;
            var imageHeight = ImageView.Image.Size.Height;
            var rate = Math.Min(width / imageWidth, height / imageHeight);

            return new CGSize(Math.Floor(imageWidth * rate), Math.Floor(imageHeight * rate));
        }

        private void SaveImageFile(string path)
        {
            var size = GetNewImageSize();
            var data = Resize(ImageView.Image.CGImage, size);
            data.Save(path, true);

            var alert = new NSAlert
            {
                AlertStyle = NSAlertStyle.Informational,
                InformativeText = "画像ファイルを保存しました。",
                MessageText = "保存しました",
            };
            alert.RunModal();
        }
    }
}
