# NSImageに画像を読み込む方法

NSImageに画像を読み込む方法を4つ紹介します。

## バンドルされた画像を読み込む

Resourcesフォルダーに配置された画像ファイルを読み込むには、NSImage.ImageNamed()を使用します。

    // Resourcesフォルダーの画像(sample.png)を読み込む
    var image = NSImage.ImageNamed("sample");

## ファイルのパスから画像を読み込む

ファイルのパスの文字列から画像を読み込むには、NSImageのコンストラクタに引数stringを渡します。

    // Resourcesフォルダーの画像(sample.png)のパス
    var path = NSBundle.MainBundle.PathForResource("sample", "png");
    // パスを指定して画像を読み込む
    var image = new NSImage(path);

## URLから画像を読み込む

URLから画像を読み込むには、NSImageのコンストラクタに引数NSUrlを渡します。

    var url = new NSUrl("https://www.gesource.jp/image/face.gif");
    // URLを指定して画像を読み込む
    var image = new NSImage(url);

## BASE64エンコードされた画像データから画像を読み込む

BASE64エンコードされた画像データから画像を読み込むには、デコードしたバイト配列をNSDataに変換して、NSImageのコンストラクタに渡します。

    // Base64エンコードされた画像データ
    var base64 = ToBase64String();
    NSData data = NSData.FromArray(Convert.FromBase64String(base64));
    var image = new NSImage(data);
    ImageView.Image = image;

