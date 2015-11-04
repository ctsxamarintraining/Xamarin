using System;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Views;
using Android.Widget;

namespace AndroidStack
{
	[Activity (Label = "Android Stack", MainLauncher = true, Icon="@drawable/ic_launcher")]			
	public class MenuActivity : ListActivity
	{
		string[] items;
		
		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);

			items = new string[] { "Sessions", "Speakers", "About" };
			ListAdapter = new ArrayAdapter<String>(this, Android.Resource.Layout.SimpleListItem1, items);
		}
		
		protected override void OnListItemClick(ListView l, View v, int position, long id)
		{
			Intent nextActivityIntent = null;

			if (position == 0) {
				nextActivityIntent = new Intent(this, typeof(SessionsActivity));
			} else if (position == 1) {
				nextActivityIntent = new Intent (this, typeof(SpeakersActivity));
			} else if (position == 2) {
				nextActivityIntent = new Intent (this, typeof(AboutActivity));
			}

			StartActivity(nextActivityIntent);
		}
	}
}