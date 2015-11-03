using Android.App;
using Android.Content.PM;
using Android.Content.Res;
using Android.OS;
using Android.Util;
using Android.Views;
using Android.Widget;
using Android.Support.V4.Widget;
using Android.Support.V4.App;

namespace AndroidFlyout
{
	[Activity (Label = "@string/app_name", MainLauncher = true, LaunchMode = LaunchMode.SingleTop, Icon = "@drawable/ic_launcher")]
	public class MainActivity : Activity
	{
		static readonly string Tag = "Flyout";
		DrawerLayout drawerLayout;
		ActionBarDrawerToggle drawerToggle;
		ListView drawerList;
		static string[] sections = new[] { "Sessions", "Speakers", "About" };

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			SetContentView (Resource.Layout.Main);

			drawerLayout = FindViewById<DrawerLayout> (Resource.Id.drawer_layout);
			drawerLayout.SetDrawerShadow (Resource.Drawable.drawer_shadow, (int)GravityFlags.Start);

			drawerToggle = new ActionBarDrawerToggle (this, drawerLayout, Resource.Drawable.ic_drawer, Resource.String.drawer_open, Resource.String.drawer_close);
			drawerLayout.SetDrawerListener (drawerToggle);

			drawerList = FindViewById<ListView> (Resource.Id.flyout);
			drawerList.Adapter = new ArrayAdapter<string> (this, Resource.Layout.drawer_list_item, sections);

			drawerList.ItemClick += (sender, e) => ListItemClicked (e.Position);
			ListItemClicked (0);

			// Enabling the home button as "up" will show a "go back button" by default. This will be changed by the drawer into a "hamburger" button.
			// This will also implicitly enable the home button (http://developer.android.com/reference/android/support/v7/app/ActionBar.html#setHomeButtonEnabled(boolean)).
			ActionBar.SetDisplayHomeAsUpEnabled (true);
		}

		void ListItemClicked (int position)
		{
			FragmentManager.PopBackStack (null, PopBackStackFlags.Inclusive);

			Log.Debug (Tag, "Item {0} has been selected.", position);

			Android.App.Fragment fragment = null;
			switch (position) {
			case 0:
				fragment = new SessionListFragment ();
				break;
			case 1:
				fragment = new SpeakerListFragment ();
				break;
			case 2:
				fragment = new AboutFragment ();
				break;
			}

			// Insert the fragment by replacing any existing fragment
			FragmentManager.BeginTransaction ()
				.Replace (Resource.Id.content_frame, fragment)
				.Commit ();

			// Highlight the selected item, update the title, and close the drawer
			drawerList.SetItemChecked (position, true);
			Title = sections [position];
			drawerLayout.CloseDrawer (drawerList);
		}

		protected override void OnPostCreate (Bundle savedInstanceState)
		{
			base.OnPostCreate (savedInstanceState);
			drawerToggle.SyncState ();
		}

		public override void OnConfigurationChanged (Configuration newConfig)
		{
			base.OnConfigurationChanged (newConfig);
			drawerToggle.OnConfigurationChanged (newConfig);
		}
		// Pass the event to ActionBarDrawerToggle, if it returns
		// true, then it has handled the app icon touch event
		public override bool OnOptionsItemSelected (IMenuItem item)
		{
			if (drawerToggle.OnOptionsItemSelected (item))
				return true;

			return base.OnOptionsItemSelected (item);
		}

		public override bool OnPrepareOptionsMenu (IMenu menu)
		{
			var drawerOpen = drawerLayout.IsDrawerOpen (drawerList);
			//when open don't show anything
			for (int i = 0; i < menu.Size (); i++)
				menu.GetItem (i).SetVisible (!drawerOpen);

			return base.OnPrepareOptionsMenu (menu);
		}
	}
}


