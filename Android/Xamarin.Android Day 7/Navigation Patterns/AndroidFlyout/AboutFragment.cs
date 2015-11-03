using Android.OS;
using Android.App;
using Android.Views;
using Android.Webkit;

namespace AndroidFlyout
{
	public class AboutFragment : Fragment
	{
		public override View OnCreateView (LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			if (container == null) {
				// Currently in a layout without a container, so no reason to create our view.
				return null;
			}

			var view = inflater.Inflate (Resource.Layout.about, container, false);

			var web = view.FindViewById<WebView> (Resource.Id.aboutwebview);
			web.LoadUrl ("file:///android_asset/about.html");

			return view;
		}
	}
}