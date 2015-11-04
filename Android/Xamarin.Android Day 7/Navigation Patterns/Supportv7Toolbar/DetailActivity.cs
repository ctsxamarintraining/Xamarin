using Android.App;
using Android.OS;
using Android.Views;
using Android.Support.V7.App;
using Android.Support.V7.Widget;

namespace HelloToolbar
{
	[Activity (Label = "DetailActivity")]			
	public class DetailActivity : AppCompatActivity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			SetContentView (Resource.Layout.detail);
			var toolbar = FindViewById<Toolbar> (Resource.Id.toolbar);

			//Toolbar will now take on default actionbar characteristics
			SetSupportActionBar (toolbar);

			SupportActionBar.Title = "Hello from Toolbar";

			SupportActionBar.SetDisplayHomeAsUpEnabled (true);
		
		}

		public override bool OnOptionsItemSelected (IMenuItem item)
		{
			if (item.ItemId == Android.Resource.Id.Home)
				Finish ();
			else
				Android.Widget.Toast.MakeText(this, "Top ActionBar pressed: " + item.TitleFormatted, Android.Widget.ToastLength.Short).Show();

			return base.OnOptionsItemSelected (item);
		}
	
		public override bool OnCreateOptionsMenu (IMenu menu)
		{
			MenuInflater.Inflate (Resource.Menu.home, menu);
			return base.OnCreateOptionsMenu (menu);
		}
	}
}

