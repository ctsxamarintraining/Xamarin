using System;
using UIKit;
using CoreGraphics;

namespace Test.iOS
{
	public class ThirdViewController : UIViewController
	{
		public ThirdViewController ()
		{
			
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			this.View = new UIView (UIApplication.SharedApplication.Delegate.GetWindow ().Bounds);

			View.BackgroundColor = UIColor.White;

			UILabel label = new UILabel (new CGRect (50, 100, 200, 20));
			label.Text = "Third View Controller";

			Add (label);
		}
	}
}

