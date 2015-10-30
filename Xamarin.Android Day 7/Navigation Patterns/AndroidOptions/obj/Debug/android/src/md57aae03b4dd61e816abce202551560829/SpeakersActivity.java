package md57aae03b4dd61e816abce202551560829;


public class SpeakersActivity
	extends md57aae03b4dd61e816abce202551560829.BaseActivity
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("AndroidOptions.SpeakersActivity, Options, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", SpeakersActivity.class, __md_methods);
	}


	public SpeakersActivity () throws java.lang.Throwable
	{
		super ();
		if (getClass () == SpeakersActivity.class)
			mono.android.TypeManager.Activate ("AndroidOptions.SpeakersActivity, Options, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
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
