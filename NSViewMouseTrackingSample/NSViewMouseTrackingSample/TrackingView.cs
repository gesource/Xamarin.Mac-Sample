using System;
using AppKit;
using CoreGraphics;
using Foundation;

namespace NSViewMouseTrackingSample
{
    /// <summary>
    /// マウスのトラッキング機能を追加したNSView
    /// </summary>
    public partial class TrackingView : AppKit.NSView
    {
        #region Constructors

        // Called when created from unmanaged code
        public TrackingView(IntPtr handle) : base(handle)
        {
            Initialize();
        }

        // Called when created directly from a XIB file
        [Export("initWithCoder:")]
        public TrackingView(NSCoder coder) : base(coder)
        {
            Initialize();
        }

        // Shared initialization code
        void Initialize()
        {
        }

        #endregion

        NSTrackingArea trackingArea;

        /// <summary>
        /// マウスイベント
        /// </summary>
        public event EventHandler<TrackingEventArgs> OnDragChange = delegate { };

        public override void AwakeFromNib()
        {
            base.AwakeFromNib();
            WantsLayer = true;
            Layer.BackgroundColor = new CGColor(1, 0, 0);
        }

        /// <summary>
        /// マウスカーソルをトラッキングしているときはtrue
        /// </summary>
        public bool IsTracking
        {
            get => (trackingArea != null);
            set
            {
                RemoveTracking();
                if (value) InitTracking();
            }
        }

        /// <summary>
        /// トラッキングの設定を行います
        /// </summary>
        private void InitTracking()
        {
            trackingArea = new NSTrackingArea(
                            Bounds,
                            NSTrackingAreaOptions.ActiveAlways | NSTrackingAreaOptions.MouseEnteredAndExited | NSTrackingAreaOptions.MouseMoved,
                            this,
                            null);
            AddTrackingArea(trackingArea);
        }

        /// <summary>
        /// トラッキングの設定を削除します
        /// </summary>
        private void RemoveTracking()
        {
            if (trackingArea != null)
            {
                this.RemoveTrackingArea(trackingArea);
                trackingArea = null;
            }
        }

        /// <summary>
        /// ビューの座標が変更され、トラッキングの範囲を再計算する必要が生じた時
        /// </summary>
        public override void UpdateTrackingAreas()
        {
            if (trackingArea != null)
            {
                RemoveTracking();
                InitTracking();
            }
        }

        public override void MouseEntered(NSEvent theEvent)
        {
            base.MouseEntered(theEvent);
            OnDragChange?.Invoke(this, TrackingEventArgs.CreateEnterd(theEvent.LocationInWindow, ConvertPointFromView(theEvent.LocationInWindow, null)));
        }

        public override void MouseExited(NSEvent theEvent)
        {
            base.MouseExited(theEvent);
            OnDragChange?.Invoke(this, TrackingEventArgs.CreateExited(theEvent.LocationInWindow, ConvertPointFromView(theEvent.LocationInWindow, null)));
        }

        public override void MouseMoved(NSEvent theEvent)
        {
            base.MouseMoved(theEvent);
            OnDragChange?.Invoke(this, TrackingEventArgs.CreateMoved(theEvent.LocationInWindow, ConvertPointFromView(theEvent.LocationInWindow, null)));
        }
    }

    /// <summary>
    /// マウスをトラッキングしたときのイベント
    /// </summary>
    public class TrackingEventArgs : EventArgs
    {
        public enum TrackingEventType
        {
            Entered,
            Exited,
            Moved,
        };
        /// <summary>
        /// イベントの種類
        /// </summary>
        public TrackingEventType EventType { get; }
        /// <summary>
        /// ウィンドウの座標
        /// </summary>
        public CGPoint EventLocation { get; }
        /// <summary>
        /// ビューの座標
        /// </summary>
        public CGPoint LocalPoint { get; }

        public TrackingEventArgs(TrackingEventType eventType, CGPoint eventLocation, CGPoint localPoint)
        {
            EventType = eventType;
            EventLocation = eventLocation;
            LocalPoint = localPoint;
        }

        public static TrackingEventArgs CreateEnterd(CGPoint eventLocation, CGPoint localPoint) => new TrackingEventArgs(TrackingEventType.Entered, eventLocation, localPoint);
        public static TrackingEventArgs CreateExited(CGPoint eventLocation, CGPoint localPoint) => new TrackingEventArgs(TrackingEventType.Exited, eventLocation, localPoint);
        public static TrackingEventArgs CreateMoved(CGPoint eventLocation, CGPoint localPoint) => new TrackingEventArgs(TrackingEventType.Moved, eventLocation, localPoint);

        public override string ToString()
        {
            return string.Format("[TrackingEventArgs: EventType={0}, EventLocation={1}, LocalPoint={2}]", EventType, EventLocation, LocalPoint);
        }
    }

}
