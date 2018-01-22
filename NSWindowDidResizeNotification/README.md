# NSWindowDidResizeNotification

ウィンドウのサイズが変更された時に通知を受け取り、ウィンドウサイズを表示します。

![](NSWindowDidResizeNotification.gif)

## 要点

    NSNotificationCenter.DefaultCenter.AddObserver(
        NSWindow.DidResizeNotification,
        (obj) => { 実行する処理 });

で、ウィンドウサイズが変更された時に指定した処理が実行されます。

次のコードでは、ウィンドウサイズが変更された時に、PrintWindowSize()を実行して、ウィンドウサイズを表示しています。

    NSNotificationCenter.DefaultCenter.AddObserver(
        NSWindow.DidResizeNotification,
        (obj) =>
        {
            PrintWindowSize();
        });
