using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using XamarinUniversity;

namespace instructor
{
	[Activity (Label = "Instructors!", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			SetContentView (Resource.Layout.Main);

			var instListView = FindViewById<ListView> (Resource.Id.instructorListView);

			//TODO 3: Fast Scroll
			instListView.FastScrollEnabled = true;


			instListView.ItemClick += (sender, e) => {
				var dialog = new AlertDialog.Builder(this);
				dialog.SetMessage(InstructorData.Instructors[e.Position].Name);
				dialog.SetNeutralButton("OK", delegate{});
				dialog.Show();					
			};

			InstructorAdapter adapter = new InstructorAdapter (this, InstructorData.Instructors);
			instListView.Adapter = adapter;
		}
	}
}


