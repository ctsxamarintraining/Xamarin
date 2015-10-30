package md58e0477341514932dcf618bafee4cb826;


public class TimePickerFragment
	extends android.app.DialogFragment
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreateDialog:(Landroid/os/Bundle;)Landroid/app/Dialog;:GetOnCreateDialog_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("Day5Examples.Droid.TimePickerFragment, Day5Examples.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", TimePickerFragment.class, __md_methods);
	}


	public TimePickerFragment () throws java.lang.Throwable
	{
		super ();
		if (getClass () == TimePickerFragment.class)
			mono.android.TypeManager.Activate ("Day5Examples.Droid.TimePickerFragment, Day5Examples.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public android.app.Dialog onCreateDialog (android.os.Bundle p0)
	{
		return n_onCreateDialog (p0);
	}

	private native android.app.Dialog n_onCreateDialog (android.os.Bundle p0);

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
