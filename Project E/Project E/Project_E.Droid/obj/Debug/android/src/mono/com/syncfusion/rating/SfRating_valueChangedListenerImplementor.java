package mono.com.syncfusion.rating;


public class SfRating_valueChangedListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.syncfusion.rating.SfRating.valueChangedListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onValueChanged:(Ljava/lang/Object;D)V:GetOnValueChanged_Ljava_lang_Object_DHandler:Com.Syncfusion.Rating.SfRating/IValueChangedListenerInvoker, Syncfusion.SfRating.Android\n" +
			"";
		mono.android.Runtime.register ("Com.Syncfusion.Rating.SfRating+IValueChangedListenerImplementor, Syncfusion.SfRating.Android, Version=14.2451.0.26, Culture=neutral, PublicKeyToken=null", SfRating_valueChangedListenerImplementor.class, __md_methods);
	}


	public SfRating_valueChangedListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == SfRating_valueChangedListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Syncfusion.Rating.SfRating+IValueChangedListenerImplementor, Syncfusion.SfRating.Android, Version=14.2451.0.26, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onValueChanged (java.lang.Object p0, double p1)
	{
		n_onValueChanged (p0, p1);
	}

	private native void n_onValueChanged (java.lang.Object p0, double p1);

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
