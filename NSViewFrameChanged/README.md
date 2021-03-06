# NSViewFrameChanged

NSViewのサイズが変更された時に通知を受け取るサンプルアプリケーションです。

サイズが変更された時、現在のサイズを表示します。

![](NSViewFrameChanged.gif)

## 要点

NSView.Notifications.ObserveFrameChanged()で、NSViewのサイズが変更された時に実行する処理を登録します。

次のコードでは、OnFrameChangedイベントを実行しています。

    public partial class MainView : NSView
    {
        public event EventHandler OnFrameChagned;

        public MainView(IntPtr handle) : base(handle)
        {
            NSView.Notifications.ObserveFrameChanged(
                this,
                (sender, e) => OnFrameChagned?.Invoke(this, EventArgs.Empty));
        }
    }

ViewControllerでは、OnFrameChagnedイベントでPrintFrameSize()メソッドを実行してNSViewのサイズを表示します。

    public partial class ViewController : NSViewController
    {
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Do any additional setup after loading the view.
            (MainView as MainView).OnFrameChagned += (sender, e) => PrintFrameSize();
        }

