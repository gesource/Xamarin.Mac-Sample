# NSBezierPathLineDash

NSBezierPathを使って点線を描画するサンプルアプリケーションです。

スライダーで線の太さ・点線の線・空白の長さを指定すると、点線を描画します。

![](NSBezierPathLineDash.gif)

## 説明

NSBezierPathのSetLineDash()メソッドに点線の設定をします。

SetLineDash()メソッドの最初の引数patternに、点線の線と空白の長さを指定します。

    private void DrawLine()
    {
        NSColor.Blue.Set();
        NSBezierPath path = NSBezierPath.FromRect(Bounds);
        path.LineWidth = (nfloat)LineWidth;

        nfloat[] pattern = { (nfloat)DashWidth, (nfloat)DashSpace };
        nfloat phase = 0;
        path.SetLineDash(pattern, phase);

        path.Stroke();
    }
