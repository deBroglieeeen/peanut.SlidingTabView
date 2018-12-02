using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Widget;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using AViews = Android.Views;
using Android.Content;
using Android.App;
using Xamarin.Forms.Platform.Android.AppCompat;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using Android.Support.V4.View;
using Android.Support.V7.Widget;
using peanut.SlidingTabView.Droid;
using peanut.SlidingTabView;
using Android.Views;

[assembly: ExportRenderer(typeof(TabSlidingView), typeof(TabSlidingViewRenderer))]
namespace peanut.SlidingTabView.Droid
{
    //public class TabSlidingViewRenderer :Xamarin.Forms.Platform.Android.ViewRenderer<TabSlidingView,AViews.View>
    // Viewに投影してたから今まで表示されなかったのか？ axmlもactivityも書かずにandroidコントロールを作ることに成功
    public class TabSlidingViewRenderer : Xamarin.Forms.Platform.Android.ViewRenderer<TabSlidingView,HorizontalScrollView>
    {
        AViews.View nativeView;
        ViewPager viewPager;
        //private Android.Widget.HorizontalScrollView _scrollView;
        /// <summary>
        /// Used for registration for dependency service
        /// </summary>
        public async static void Init()
        {
            var temp = DateTime.Now;
            System.Diagnostics.Debug.WriteLine("イニシャライズ");
        }
        private TabSlidingView _tabSlidingView;
        private Context _context;
        public TabSlidingViewRenderer(Context context) : base(context)
        {
            _context = context;
        }
        protected override void OnElementChanged(ElementChangedEventArgs<TabSlidingView> e)
        {
            base.OnElementChanged(e);
            _tabSlidingView = e.NewElement;
            // コンテクストは継承されたものをそのまま使った
            var horizontalScrollView = new HorizontalScrollView(_context);
            var linerLayout = new LinearLayout(_context);
            for (int i = 0; i < 20; i++)
            {
                // ボタンのレイアウトを整えるiOSでもこのような機能があるといいな
                var layoutParams = new LinearLayout.LayoutParams
                                                   (LinearLayout.LayoutParams.MatchParent
                                                    , LinearLayout.LayoutParams.WrapContent);
                // コンテクストの為に親が決まる訳ではない(この前の親をとり除けというエラーは一体何だったのだろうか)
                var btn = new Android.Widget.Button(_context);
                btn.Id = i;
                btn.Text = i.ToString();
                btn.SetBackgroundColor(Android.Graphics.Color.White);
                btn.SetTextColor(Android.Graphics.Color.LightGray);
                linerLayout.AddView(btn, layoutParams);
            }
            horizontalScrollView.AddView(linerLayout);
            base.SetNativeControl(horizontalScrollView);
        }
        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);
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
                    //_scrollView.SetBackgroundColor(Element.BackgroundColor.ToAndroid());
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
            base.Dispose(disposing);
        }

    }
}
