using System;
using AppKit;
using Foundation;

namespace NSBezierPathBoundsProperty
{
    public class BaseView : AppKit.NSView
    {
        #region Constructors

        // Called when created from unmanaged code
        public BaseView(IntPtr handle) : base(handle)
        {
            Initialize();
        }

        // Called when created directly from a XIB file
        [Export("initWithCoder:")]
        public BaseView(NSCoder coder) : base(coder)
        {
            Initialize();
        }

        // Shared initialization code
        void Initialize()
        {
        }

        #endregion

        public override bool IsFlipped { get => true; }

        protected void DrawPath(NSBezierPath path)
        {
            NSColor.Black.SetStroke();
            path.LineWidth = 3;
            path.Stroke();

            NSColor.Red.SetStroke();
            var boundsPath = NSBezierPath.FromRect(path.Bounds);
            boundsPath.LineWidth = 4;
            boundsPath.Stroke();

            NSColor.Green.SetStroke();
            var controlPointBoundsPath = NSBezierPath.FromRect(path.ControlPointBounds);
            controlPointBoundsPath.LineWidth = 2;
            controlPointBoundsPath.Stroke();
        }
    }
}
