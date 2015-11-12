using Android.App;
using Android.Widget;
using Android.OS;

namespace MyApp
{
	[Activity(Label = "MyApp", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);
			SetContentView(Resource.Layout.Main);

			string pn = Com.Xamarin.Info.PhoneNumber;

			FindViewById<TextView>(Resource.Id.phoneNumber).Text = pn;
		}
	}
}