package md58e0477341514932dcf618bafee4cb826;


public class HelloGridViewActivity
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("Day5Examples.Droid.HelloGridViewActivity, Day5Examples.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", HelloGridViewActivity.class, __md_methods);
	}


	public HelloGridViewActivity () throws java.lang.Throwable
	{
		super ();
		if (getClass () == HelloGridViewActivity.class)
			mono.android.TypeManager.Activate ("Day5Examples.Droid.HelloGridViewActivity, Day5Examples.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

	java.util.ArrayList refList;
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
