using System;
using System.Diagnostics;
using System.ComponentModel;
using Xamarin.Forms.Platform.iOS;
using Xamarin.Forms;
using UIKit;
using CoreGraphics;
using Foundation;
using peanut.SlidingTabView;
using peanut.SlidingTabView.iOS;
[assembly: ExportRenderer(typeof(TabSlidingView), typeof(TabSlidingViewRenderer))]
namespace peanut.SlidingTabView.iOS
{
    public class TabSlidingViewRenderer : ViewRenderer<TabSlidingView, UIView>
    {
        /// <summary>
        /// Used for registration for dependency service
        /// </summary>
        public async static void Init()
        {
            var temp = DateTime.Now;
        }
        private UIScrollView _scrollView;
        private UICollectionView _collectionView;
        private UICollectionViewCell _collectionViewCell;
        private double _pageTabItemWidth = 0.0;
        protected override void OnElementChanged(ElementChangedEventArgs<TabSlidingView> e)
        {
            base.OnElementChanged(e);

            if (this.Control == null)
            {
                _collectionView = new UICollectionView(new CGRect(0, 0, 40, 40), new UICollectionViewLayout());
                //_scrollView = new UIScrollView(new CGRect(0, 0, 400, 400));
                //_scrollView = new UIScrollView(new CGRect(0, 0, 280, 44));
                _scrollView = new TouchDetectingScrollView();
                _scrollView.Frame = new CGRect(0, 0, 280, 44);
                _scrollView.BackgroundColor = UIColor.White;
                Debug.WriteLine("描画開始");
                CreateTabSliding();
            }

            //if (e.NewElement != null)
            //{

            //}
            if (Element == null)
            {
                return;
            }

        }
        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);
            //if (e.PropertyName == TabSlidingView.TabHeightProperty.PropertyName 
            //    || e.PropertyName == TabSlidingView.TabBackgroundColorProperty.PropertyName
            //    || e.PropertyName == TabSlidingView.TabMarginProperty.PropertyName
            //    || e.PropertyName == TabSlidingView.TabTextColorProperty.PropertyName
            //    || e.PropertyName == TabSlidingView.FontSizeProperty.PropertyName)
            //{

            //}
            switch (e.PropertyName)
            {
                case "ItemsSource":

                    break;
                case "TabHeight":
                    break;
                case "TabMargin":
                    break;
                case "TabTextColor":
                    break;
                case "FontSize":
                    break;
                case "UIColor":
                    break;
                case "DefaultColor":
                    break;
                case "CurrentBarHeight":
                    break;
                case "PageBackgroundColor":
                    break;
                case "IsTranslucent":
                    break;
                case "HidesTabBarOnSwipe":
                    break;
                default:
                    break;
            }
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                //this.Control.Subviews. -= this.OnTouchDown;
                // このコードではイベントの解放がなされてない
                //foreach (var item in this.Control.Subviews)
                //{
                //    if (item.Tag != 0)
                //    {
                //        (item as UIButton).TouchDown -= this.OnTouchDown;
                //        Debug.WriteLine($"イベント解除{item.Tag}");
                //    }
                //}
                // ちなみにこのコードでもだめ
                foreach (var item in _scrollView.Subviews)
                {
                    if (item.Tag != 0)
                    {
                        (item as UIButton).TouchDown -= this.OnTouchDown;
                        Debug.WriteLine($"イベント解除{item.Tag}");
                    }
                }
            }
            base.Dispose(disposing);
        }
        private void CreateTabSliding()
        {
            try
            {
                NSString tabSlidingViewCellId = new NSString("TabSlidingViewCell");
                NSString headerID = new NSString("Header");
                //_collectionView.RegisterClassForCell(typeof(TabSlidingViewCell), tabSlidingViewCellId);
                //_collectionView.RegisterClassForCell(typeof(TabSlidingViewCell),"4");
                Debug.WriteLine("セル追加");
                //_collectionView.RegisterClassForSupplementaryView(typeof(Header), UICollectionElementKindSection.Header, headerID);

                UIMenuController.SharedMenuController.MenuItems = new UIMenuItem[]
                {
                    new UIMenuItem("Custom",new ObjCRuntime.Selector("custom"))
                };
                //_collectionView.DataSource = new UICollectionViewSource();
                //_collectionView.DataSource.GetCell(_collectionView, new NSIndexPath());
                //SetNativeControl(_collectionView);
                for (int i = 0; i < 20; i++)
                {
                    var uIView = new UIView();
                    uIView.Frame = new CGRect(0, 0, i.ToString().Length * 15, 70);
                    uIView.BackgroundColor = UIColor.White;
                    var uIButton = new UIButton(UIButtonType.System);

                    //var uILabel = new UILabel();
                    //// スクロールの一番最初の要素であれば
                    //if (i==0)
                    //{
                    //    uIButton.Frame = new CGRect(20, 0, i.ToString().Length * 40, 44);
                    //}
                    //else
                    //{
                    //    uIButton.Frame = new CGRect(i * 40, 0, i.ToString().Length * 40, 44);

                    //}
                    uIButton.Frame = new CGRect(20 + (i * 40), 0, i.ToString().Length * 20, 35);
                    //uILabel.Frame = new CGRect(i * 30, 0, 280, 44);
                    uIButton.SetTitle(i.ToString(), UIControlState.Normal);
                    //uILabel.Text = i.ToString();
                    uIButton.BackgroundColor = UIColor.White;
                    uIButton.HorizontalAlignment = UIControlContentHorizontalAlignment.Leading;
                    //uILabel.BackgroundColor = UIColor.Orange;
                    //uILabel.TextColor = UIColor.White;
                    uIButton.SetTitleColor(UIColor.FromRGB(164, 164, 164), UIControlState.Normal);
                    uIButton.Tag = (i + 1);
                    Debug.WriteLine($"イベント購読{uIButton.Tag}");
                    var uILabel = new UILabel();
                    uILabel.Frame = new CGRect(i * 20, 40, i.ToString().Length * 200, 1);
                    uILabel.BackgroundColor = UIColor.FromRGB(222, 222, 222);
                    //uILabel.
                    uIButton.TouchDown += OnTouchDown;
                    //uIView.AddSubview(uIButton);

                    uIView.InsertSubview(uIButton, 0);
                    //uIView.AddSubview(uILabel);
                    //uIView.InsertSubviewBelow(uIButton,uILabel);
                    uIView.InsertSubview(uILabel, 1);
                    uIView.SendSubviewToBack(uIButton);
                    //_scrollView.AddSubview(uIButton);

                    //_scrollView.AddSubview(uIView);
                    _scrollView.InsertSubview(uIButton, 0);
                    _scrollView.InsertSubview(uILabel, 1);

                }
                _scrollView.UserInteractionEnabled = true;
                //_scrollView.SetContentOffset(new CGPoint(Bounds.GetMaxX(),0), true);
                //_scrollView.SetContentHuggingPriority(float.Parse(Bounds.GetMaxX().ToString()), UILayoutConstraintAxis.Horizontal);
                _scrollView.ContentSize = new CGSize(850, 0);
                _scrollView.ShowsHorizontalScrollIndicator = false;

                //_scrollView.Draw(new CGRect(0, 0, 400, 400));

                SetNativeControl(_scrollView);

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }
        private void OnTouchDown(object sender, EventArgs e)
        {
            (sender as UIButton).SetTitleColor(UIColor.Black, UIControlState.Highlighted);
            Debug.WriteLine((sender as UIButton).CurrentTitle);
            //_scrollView.
        }
    }
}
