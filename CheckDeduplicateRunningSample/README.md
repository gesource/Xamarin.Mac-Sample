# 多重起動をチェックする

Xamarin.Macで、アプリケーションの多重起動をチェックするサンプルアプリケーションです。

すでにアプリケーションが起動しているときはコンソールにメッセージを出力して、アプリケーションを終了します。

## 説明

NSRunningApplicationクラスのGetRunningApplications()メソッドは、起動している指定したバンドルIDのアプリケーションの配列(NSRunningApplication[])を返します。

## ソースコード

AppDeleteのDidFinishLaunchingメソッドで多重起動をチェックします。

すでに起動していれば、アプリケーションを終了します。

    public override void DidFinishLaunching(NSNotification notification)
    {
        var apps = NSRunningApplication.GetRunningApplications(NSBundle.MainBundle.BundleIdentifier);
        if (apps.Length > 1)
        {
            Console.WriteLine($"アプリケーションはすでに起動しています。");
            NSApplication.SharedApplication.Terminate(this);
        }
    }