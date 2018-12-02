using System;
using Foundation;
using UIKit;
using System.Diagnostics;
namespace peanut.SlidingTabView.iOS
{
    public class TouchDetectingScrollView : UIScrollView
    {
        public override void TouchesBegan(NSSet touches, UIEvent evt)
        {
            base.TouchesBegan(touches, evt);
            try
            {
                //Superview?.TouchesBegan(touches, evt);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }

        }
        public override void LayoutSubviews()
        {
            base.LayoutSubviews();

        }
    }
}
