using Android.App;
using Android.OS;
using Android.Widget;
using Com.Xamarin;

namespace MyApp
{
	[Activity(Label = "MyApp", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);
			SetContentView(Resource.Layout.Main);

			Button button = FindViewById<Button>(Resource.Id.myButton);
			
			button.Click += delegate
				{
					double result = Pi.Calculate(1);

					button.Text = result.ToString();
				};
		}
	}
}