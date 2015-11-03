using Android.App;
using Android.OS;
using Android.Util;
using Android.Content.PM;

namespace AndroidActionBarTabs
{
	[Activity (Label = "@string/app_name", MainLauncher = true, Icon = "@drawable/ic_launcher")]
	public class MainActivity : Activity, ActionBar.ITabListener
	{
		static readonly string Tag = "ActionBarTabs";
		Fragment[] _fragments;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			this.ActionBar.NavigationMode = ActionBarNavigationMode.Tabs;
			SetContentView (Resource.Layout.Main);

			_fragments = new Fragment[] {
				new SessionListFragment (),
				new SpeakerListFragment (),
				new AboutFragment ()
			};

			AddTabToActionBar (Resource.String.sessions_tab_label, Resource.Drawable.ic_action_sessions);
			AddTabToActionBar (Resource.String.speakers_tab_label, Resource.Drawable.ic_action_speakers);
			AddTabToActionBar (Resource.String.about_tab_label, Resource.Drawable.ic_action_whats_on);
		}

		void AddTabToActionBar (int labelResourceId, int iconResourceId)
		{
			ActionBar.Tab tab = this.ActionBar.NewTab ()
                                           .SetText (labelResourceId)
                                           .SetIcon (iconResourceId)
                                           .SetTabListener (this);
			this.ActionBar.AddTab (tab);
		}

		public void OnTabSelected (ActionBar.Tab tab, FragmentTransaction ft)
		{
			FragmentManager.PopBackStack (null, FragmentManager.PopBackStackInclusive);

			Log.Debug (Tag, "The tab {0} has been selected.", tab.Text);
			Fragment frag = _fragments [tab.Position];
			ft.Replace (Resource.Id.content_frame, frag);
		}

		public void OnTabReselected (ActionBar.Tab tab, FragmentTransaction ft)
		{
			Log.Debug (Tag, "The tab {0} was re-selected.", tab.Text);
		}

		public void OnTabUnselected (ActionBar.Tab tab, FragmentTransaction ft)
		{
			// perform any extra work associated with saving fragment state here.
			Log.Debug (Tag, "The tab {0} as been unselected.", tab.Text);
		}
	}
}
