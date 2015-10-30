
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Day5Examples.Droid
{
	[Activity (Label = "HelloGridViewActivity")]			
	public class HelloGridViewActivity : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			SetContentView (Resource.Layout.HelloGridView);

			var gridview = FindViewById<GridView> (Resource.Id.gridview);
			gridview.Adapter = new ImageAdapter (this);

			gridview.ItemClick += delegate (object sender, AdapterView.ItemClickEventArgs args) {
				Toast.MakeText (this, args.Position.ToString (), ToastLength.Short).Show ();
			};
		}
	}
}

