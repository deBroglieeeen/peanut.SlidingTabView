package md57732c86157a1ffcfdb2271e003979689;


public class TabSlidingViewRenderer
	extends md51558244f76c53b6aeda52c8a337f2c37.ViewRenderer_2
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("peanut.SlidingTabView.Droid.TabSlidingViewRenderer, peanut.SlidingTabView.Android", TabSlidingViewRenderer.class, __md_methods);
	}


	public TabSlidingViewRenderer (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == TabSlidingViewRenderer.class)
			mono.android.TypeManager.Activate ("peanut.SlidingTabView.Droid.TabSlidingViewRenderer, peanut.SlidingTabView.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
	}


	public TabSlidingViewRenderer (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == TabSlidingViewRenderer.class)
			mono.android.TypeManager.Activate ("peanut.SlidingTabView.Droid.TabSlidingViewRenderer, peanut.SlidingTabView.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
	}


	public TabSlidingViewRenderer (android.content.Context p0)
	{
		super (p0);
		if (getClass () == TabSlidingViewRenderer.class)
			mono.android.TypeManager.Activate ("peanut.SlidingTabView.Droid.TabSlidingViewRenderer, peanut.SlidingTabView.Android", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
	}

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
