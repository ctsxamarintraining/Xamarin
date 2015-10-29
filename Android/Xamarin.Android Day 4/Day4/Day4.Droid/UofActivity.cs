using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace Day4.Droid
{
	[Activity (Label = "Day4.Droid",  Icon = "@drawable/icon")]
	public class UofActivity : Activity
	{
		int count = 1;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Uof);

//			Button btn = FindViewById<Button> (Resource.Id.btnFirst);
//			btn.Click += (object sender, EventArgs e) => 
//			{
//				var t =Toast.MakeText(this,"testing",ToastLength.Long);
//				t.Show();
//			};
		}
	}
}


