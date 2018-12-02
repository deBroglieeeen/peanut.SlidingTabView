using System;
using Xamarin.Forms;
using System.Collections;
namespace peanut.SlidingTabView
{
    public class TabSlidingView : View
    {
        public static readonly BindableProperty ItemsSourceProperty =
            BindableProperty.Create(propertyName: nameof(ItemsSource),
                      returnType: typeof(IEnumerable),
                                    declaringType: typeof(TabSlidingView),
                                    defaultValue: null,
                                    propertyChanged: OnItemsSourceChanged);

        public IEnumerable ItemsSource
        {
            get { return (IEnumerable)GetValue(ItemsSourceProperty); }
            set { SetValue(ItemsSourceProperty, value); }
        }
        public static readonly BindableProperty FontSizeProperty =
                  BindableProperty.Create(propertyName: nameof(FontSize),
                                          returnType: typeof(double),
                                          declaringType: typeof(TabSlidingView),
                      defaultValue: 14d);

        public double FontSize
        {
            get { return (double)GetValue(FontSizeProperty); }
            set { SetValue(FontSizeProperty, value); }
        }
        public static readonly BindableProperty UIColorProperty =
                  BindableProperty.Create(propertyName: nameof(UIColor),
                      returnType: typeof(Color),
                                          declaringType: typeof(TabSlidingView),
                      defaultValue: Color.White);

        public Color UIColor
        {
            get { return (Color)GetValue(UIColorProperty); }
            set { SetValue(UIColorProperty, value); }
        }
        public static readonly BindableProperty DefaultColorProperty =
                  BindableProperty.Create(propertyName: nameof(DefaultColor),
                      returnType: typeof(Color),
                                          declaringType: typeof(TabSlidingView),
                      defaultValue: Color.White);

        public Color DefaultColor
        {
            get { return (Color)GetValue(DefaultColorProperty); }
            set { SetValue(DefaultColorProperty, value); }
        }
        public static readonly BindableProperty TabHeightProperty =
          BindableProperty.Create(propertyName: nameof(TabHeight),
              returnType: typeof(double),
                                  declaringType: typeof(TabSlidingView),
              defaultValue: 25d);

        public double TabHeight
        {
            get { return (double)GetValue(TabHeightProperty); }
            set { SetValue(TabHeightProperty, value); }
        }
        public static readonly BindableProperty TabMarginProperty =
                  BindableProperty.Create(propertyName: nameof(TabMargin),
                      returnType: typeof(double),
                                          declaringType: typeof(TabSlidingView),
                      defaultValue: 35d);

        public double TabMargin
        {
            get { return (double)GetValue(TabMarginProperty); }
            set { SetValue(TabMarginProperty, value); }
        }
        public static readonly BindableProperty TabBackgroundColorProperty =
                  BindableProperty.Create(propertyName: nameof(TabBackgroundColor),
                      returnType: typeof(Color),
                                          declaringType: typeof(TabSlidingView),
                      defaultValue: Color.White);

        public Color TabBackgroundColor
        {
            get { return (Color)GetValue(TabBackgroundColorProperty); }
            set { SetValue(TabBackgroundColorProperty, value); }
        }
        public static readonly BindableProperty TabTextColorProperty =
                  BindableProperty.Create(propertyName: nameof(TabTextColor),
                      returnType: typeof(Color),
                                          declaringType: typeof(TabSlidingView),
                      defaultValue: Color.Black);

        public Color TabTextColor
        {
            get { return (Color)GetValue(TabTextColorProperty); }
            set { SetValue(TabTextColorProperty, value); }
        }
        public static readonly BindableProperty CurrentBarHeightProperty =
                  BindableProperty.Create(propertyName: nameof(CurrentBarHeight),
                      returnType: typeof(double),
                                          declaringType: typeof(TabSlidingView),
                      defaultValue: 40d);

        public double CurrentBarHeight
        {
            get { return (double)GetValue(CurrentBarHeightProperty); }
            set { SetValue(CurrentBarHeightProperty, value); }
        }
        public static readonly BindableProperty PageBackgroundColorProperty =
                  BindableProperty.Create(propertyName: nameof(PageBackgroundColor),
                      returnType: typeof(Color),
                                          declaringType: typeof(TabSlidingView),
                      defaultValue: Color.White);

        public Color PageBackgroundColor
        {
            get { return (Color)GetValue(PageBackgroundColorProperty); }
            set { SetValue(PageBackgroundColorProperty, value); }
        }
        public static readonly BindableProperty IsTranslucentProperty =
                  BindableProperty.Create(propertyName: nameof(IsTranslucent),
                      returnType: typeof(bool),
                                          declaringType: typeof(TabSlidingView),
                      defaultValue: false);

        public bool IsTranslucent
        {
            get { return (bool)GetValue(IsTranslucentProperty); }
            set { SetValue(IsTranslucentProperty, value); }
        }
        public static readonly BindableProperty HidesTabBarOnSwipeProperty =
                  BindableProperty.Create(propertyName: nameof(HidesTabBarOnSwipe),
                      returnType: typeof(bool),
                                          declaringType: typeof(TabSlidingView),
                      defaultValue: false);

        public bool HidesTabBarOnSwipe
        {
            get { return (bool)GetValue(HidesTabBarOnSwipeProperty); }
            set { SetValue(HidesTabBarOnSwipeProperty, value); }
        }
        static void OnItemsSourceChanged(BindableObject bindable, object oldvalue, object newvalue)
        {
            var element = newvalue as Element;
            if (element == null)
            {
                return;
            }
            element.Parent = (Element)bindable;
        }
    }
}
