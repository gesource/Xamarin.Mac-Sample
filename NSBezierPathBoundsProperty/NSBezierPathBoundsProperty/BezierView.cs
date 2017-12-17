using System;
using AppKit;
using Foundation;

namespace NSBezierPathBoundsProperty
{
    public partial class BezierView : BaseView
    {
        #region Constructors

        // Called when created from unmanaged code
        public BezierView(IntPtr handle) : base(handle)
        {
            Initialize();
        }

        // Called when created directly from a XIB file
        [Export("initWithCoder:")]
        public BezierView(NSCoder coder) : base(coder)
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
            NSBezierPath path = new NSBezierPath();
            path.MoveTo(new CoreGraphics.CGPoint(200, 50));
            path.CurveTo(new CoreGraphics.CGPoint(300, 50),
                         new CoreGraphics.CGPoint(100, 300),
                         new CoreGraphics.CGPoint(400, 300));
            DrawPath(path);
        }
    }
}
