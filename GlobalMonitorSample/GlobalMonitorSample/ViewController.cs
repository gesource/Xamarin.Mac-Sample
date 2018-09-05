using System;
using System.Diagnostics;
using System.Text;
using AppKit;
using CoreGraphics;
using Foundation;

namespace GlobalMonitorSample
{
    public partial class ViewController : NSViewController
    {
        private NSObject globalEventMonitor;
        private NSObject localEventMonitor;

        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Do any additional setup after loading the view.
            CheckBoxMonitoring.Activated += (sender, e) =>
            {
                if (CheckBoxMonitoring.State == NSCellStateValue.On)
                    StartMonitoring();
                if (CheckBoxMonitoring.State == NSCellStateValue.Off)
                    StopMonitoring();
            };
            CheckBoxMonitoring.State = NSCellStateValue.Off;
        }

        public override NSObject RepresentedObject
        {
            get
            {
                return base.RepresentedObject;
            }
            set
            {
                base.RepresentedObject = value;
                // Update the view, if already loaded.
            }
        }

        private void StopMonitoring()
        {
            NSEvent.RemoveMonitor(globalEventMonitor);
            NSEvent.RemoveMonitor(localEventMonitor);
        }

        private void StartMonitoring()
        {
            globalEventMonitor = NSEvent.AddGlobalMonitorForEventsMatchingMask(
                NSEventMask.MouseMoved,
                (theEvent) => PrintMouseLocation("Global", theEvent.LocationInWindow));

            localEventMonitor = NSEvent.AddLocalMonitorForEventsMatchingMask(
                NSEventMask.MouseMoved,
                (theEvent) =>
                {
                    CGPoint p;
                    if (theEvent.Window != null)
                    {
                        var rect = theEvent.Window.ConvertRectToScreen(new CGRect(theEvent.LocationInWindow, new CGSize(0, 0)));
                        p = rect.Location;
                    }
                    else
                    {
                        p = theEvent.LocationInWindow;
                    }
                    PrintMouseLocation("Local", p);
                    return theEvent;
                });
        }

        private void PrintMouseLocation(string monitor, CGPoint p)
        {
            LabelMonitor.StringValue = $"Monitor: {monitor}";
            LabelScreen.StringValue = $"Screen Pos: {p.X:F4} {p.Y:F4}";
            var localPoint = this.View.Window.ConvertScreenToBase(p);
            LabelWindow.StringValue = $"Window Pos: {localPoint.X:F4} {localPoint.Y:F4}";
        }
    }
}
