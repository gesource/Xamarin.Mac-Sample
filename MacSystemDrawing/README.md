# Xamarin.MacでSystem.Drawingを使う

Xamarin.Macでプロジェクトのターゲットフレームワークに「Xamarin.Mac Modern」を選択していると、System.Drawingを使用できません。

System.Drawingの代わりに「ZKWeb.System.Drawing」を使ったサンプルアプリケーションです。

* [ZKWeb.System.Drawing][1]

## 導入方法

プロジェクトのターゲットフレームワークは「Xamarin.Mac Modern」を選択します。

メニューから「プロジェクト」-「NuGetパッケージの追加」を選択し、「ZKWeb.System.Drawing」をインストールします。

## 使用例

クラス名はSystem.Drawingと同じですが、パッケージ名はSystem.DrawingCoreになります。

サンプルアプリケーションでは、NSImageで楕円を描画し、Bitmapファイルに保存します。

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


[1]: https://github.com/zkweb-framework/ZKWeb.System.Drawing
