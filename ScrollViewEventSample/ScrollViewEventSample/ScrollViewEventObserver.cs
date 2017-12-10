using System;
using AppKit;
using Foundation;
using ObjCRuntime;

namespace ScrollViewEventSample
{
    /// <summary>
    /// NSScrollViewのスクロールイベントを受け取る
    /// </summary>
    public class ScrollViewEventObserver : NSObject
    {
        /// <summary>
        /// スクロールイベント対象
        /// </summary>
        public NSScrollView ScrollView { get; private set; }

        /// <summary>
        /// スクロールイベント
        /// </summary>
        public event ScrollChangedEventHandler ScrollChanged;

        /// <summary>
        /// スクロールバーのスクロールイベントの受信を開始します
        /// </summary>
        public void Start(NSScrollView scrollview)
        {
            ScrollView = scrollview;
            var contentView = scrollview.ContentView;
            contentView.PostsBoundsChangedNotifications = true;
            NSNotificationCenter.DefaultCenter.AddObserver(
                this,
                new Selector("boundsDidChangeNotification:"),
                NSView.BoundsChangedNotification,
                contentView);
        }

        /// <summary>
        /// スクロールバーのスクロールイベントの通知
        /// </summary>
        /// <param name="o">O.</param>
        [Export("boundsDidChangeNotification:")]
        public void BoundsDidChangeNotification(NSObject o)
        {
            var notification = o as NSNotification;
            var view = notification.Object as NSView;
            var position = view.Bounds.Location;
            Console.WriteLine("Scroll position: " + position.ToString());

            ScrollChanged?.Invoke(this, new ScrollChangedEventArgs(position.X, position.Y));
        }

        /// <summary>
        /// スクロールバーのスクロールイベントの受信を終了します
        /// </summary>
        public void Stop()
        {
            if (ScrollView == null) return;

            NSNotificationCenter.DefaultCenter.RemoveObserver(
                this,
                NSView.BoundsChangedNotification,
                ScrollView.ContentView);
        }
    }

    public delegate void ScrollChangedEventHandler(object sender, ScrollChangedEventArgs e);
    public class ScrollChangedEventArgs : EventArgs
    {
        public double X { get;  }
        public double Y { get;  }
        public ScrollChangedEventArgs(double x, double y)
        {
            X = x;
            Y = y;
        }
    }

}
