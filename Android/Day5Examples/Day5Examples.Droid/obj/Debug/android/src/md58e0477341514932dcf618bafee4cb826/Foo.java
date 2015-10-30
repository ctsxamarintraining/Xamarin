package md58e0477341514932dcf618bafee4cb826;


public class Foo
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_Bar:(Ljava/lang/String;)V:__export__\n" +
			"";
		mono.android.Runtime.register ("Day5Examples.Droid.Foo, Day5Examples.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", Foo.class, __md_methods);
	}


	public Foo () throws java.lang.Throwable
	{
		super ();
		if (getClass () == Foo.class)
			mono.android.TypeManager.Activate ("Day5Examples.Droid.Foo, Day5Examples.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

	public Foo (android.content.Context p0) throws java.lang.Throwable
	{
		super ();
		if (getClass () == Foo.class)
			mono.android.TypeManager.Activate ("Day5Examples.Droid.Foo, Day5Examples.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0 });
	}


	public void bar (java.lang.String p0)
	{
		n_Bar (p0);
	}

	private native void n_Bar (java.lang.String p0);

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
