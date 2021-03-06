// This file has been autogenerated from a class added in the UI designer.

using System;

using Foundation;
using AppKit;

namespace NSViewFrameChanged
{
    public partial class MainView : NSView
    {
        public event EventHandler OnFrameChagned;

        public MainView(IntPtr handle) : base(handle)
        {
            NSView.Notifications.ObserveFrameChanged(
                this,
                (sender, e) => OnFrameChagned?.Invoke(this, EventArgs.Empty));
        }

        public override void DrawRect(CoreGraphics.CGRect dirtyRect)
        {
            NSColor.Red.Set();
            NSBezierPath.StrokeRect(this.Bounds);
        }
    }
}
