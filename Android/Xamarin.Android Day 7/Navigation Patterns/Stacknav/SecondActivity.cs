using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace Stacknav
{
	[Activity (Label = "Stacknav", Icon = "@drawable/icon")]
	public class SecondActivity : Activity
	{
		int count = 1;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button> (Resource.Id.myButton);
			button.Text = "Third";
			button.Click += delegate {
				StartActivity(new Intent(this, typeof(ThirdActivity)));
			};
		}
	}
}


