using System;
using AppKit;
using Foundation;

namespace NSViewDrawSample
{
    public partial class SampleView : AppKit.NSView
    {
        #region Constructors

        // Called when created from unmanaged code
        public SampleView(IntPtr handle) : base(handle)
        {
            Initialize();
        }

        // Called when created directly from a XIB file
        [Export("initWithCoder:")]
        public SampleView(NSCoder coder) : base(coder)
        {
            Initialize();
        }

        // Shared initialization code
        void Initialize()
        {
        }

        #endregion

        public override void DrawRect(CoreGraphics.CGRect dirtyRect)
        {
            var rect = this.Bounds;
            var x1 = rect.Left;
            var y1 = rect.Top;
            var x2 = rect.Right;
            var y2 = rect.Bottom;

            NSBezierPath path = new NSBezierPath();
            path.MoveTo(new CoreGraphics.CGPoint(x1, y1));
            path.CurveTo(new CoreGraphics.CGPoint(x2, y1),
                         new CoreGraphics.CGPoint(x1, y2),
                         new CoreGraphics.CGPoint(x2, y2));
            path.LineWidth = 5;
            NSColor.Red.SetStroke();
            path.Stroke();
        }
    }
}
