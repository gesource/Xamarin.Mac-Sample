# NSViewChangeCursor

NSViewの上にマウスポインタが移動したらマウスカーソルを変更するサンプルアプリケーションです。

![](NSViewChangeCursor.gif)

緑色のNSViewの上にマウスポインタが移動すると、マウスカーソルはシステムの十字カーソルになります。

黄色のNSViewの上にマウスポインタが移動すると、マウスカーソルは画像のカーソルになります。

青色のNSViewの上にマウスポインタが移動すると、マウスカーソルはシステムの上下カーソルになります。

マゼンダのNSViewの上でマウスボタンを押すとマウスカーソルが変わり、マウスボタンを放すと元に戻ります。

プロジェクトで使用しているマウスカーソルの画像には、「[カーソル付きのノートPCのアイコン素材][3]」を使用させていただきました。

* [カーソル付きのノートPCのアイコン素材][3]

## NSViewのMouseEntered/MouseExitedを使用するには

マウスポインタがNSView上に入ったときのイベント(MouseEnteredイベント)や、NSView上から出たときのイベント(MouseExited)を使用するには、トラッキングの設定が必要です。

トラッキングを行うには、[NSViewMouseTrackingSample][1]をご覧ください。

## マウスカーソルをシステムのカーソルに変更するには

NSCursorのSet()を使用します。

    public override void MouseEntered(NSEvent theEvent)
    {
        base.MouseEntered(theEvent);
        NSCursor.CrosshairCursor.Set();
    }


### システムカーソル

利用できるシステムカーソルの一覧は次のページで確認できます。

* [NSCursor][2]

## マウスカーソルを画像のカーソルに変更するには

### MouseEntered/MouseExitedを使う方法

NSCursorの引数に、マウスカーソルに使用する画像を指定します。

    imageCursor = new NSCursor(
        NSImage.ImageNamed("cursor.png"),
        new CoreGraphics.CGPoint(7, 7));

NSView上にマウスポインタが移動したら、NSCursorのSet()でマウスカーソルを変更します。

    public override void MouseEntered(NSEvent theEvent)
    {
        base.MouseEntered(theEvent);
        imageCursor.Set();
    }

NSViewの外にマウスポインタが移動したら、元に戻します。

    public override void MouseExited(NSEvent theEvent)
    {
        base.MouseExited(theEvent);
        NSCursor.ArrowCursor.Set();
    }

### AddCursorRect/ResetCursorRectsを使う方法

AddCursorRect()の引数に、範囲とマウスカーソルを指定します。

指定した範囲にマウスポインタが入ると、マウスカーソルは指定したカーソルになります。

    public override void ResetCursorRects()
    {
        AddCursorRect(Bounds, NSCursor.ResizeUpDownCursor);
    }

### 任意のタイミングでNSViewのResetCursorRects()を実行する方法

マウスボタンが押されたタイミングでNSViewのResetCursorRects()を実行するには、
Window.ResetCursorRects()を使用します。

    public override void MouseDown(NSEvent theEvent)
    {
        UpdateCursor(true);
    }

    public override void MouseUp(NSEvent theEvent)
    {
        UpdateCursor(false);
    }

    private void UpdateCursor(bool value)
    {
        changeCursor = value;
        Window.ResetCursorRects();
    }

    public override void ResetCursorRects()
    {
        if (changeCursor)
            AddCursorRect(Bounds, NSCursor.OperationNotAllowedCursor);
    }




[1]: https://github.com/gesource/Xamarin.Mac-Sample/tree/master/NSViewMouseTrackingSample
[2]: https://developer.apple.com/documentation/appkit/nscursor?language=objc#overview
[3]: http://icon-rainbow.com/%E3%82%AB%E3%83%BC%E3%82%BD%E3%83%AB%E4%BB%98%E3%81%8D%E3%81%AE%E3%83%8E%E3%83%BC%E3%83%88pc%E3%81%AE%E3%82%A2%E3%82%A4%E3%82%B3%E3%83%B3%E7%B4%A0%E6%9D%90/
