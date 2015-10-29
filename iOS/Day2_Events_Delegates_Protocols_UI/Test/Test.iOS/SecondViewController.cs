using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace Test.iOS
{
	partial class SecondViewController : UIViewController
	{
		public string Data {
			get;
			set;
		}

		public SecondViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			lbl.Text = Data;
		}
	}
}
