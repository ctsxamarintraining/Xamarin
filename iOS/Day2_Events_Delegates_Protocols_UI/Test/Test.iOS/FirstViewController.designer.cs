// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace Test.iOS
{
	[Register ("FirstViewController")]
	partial class FirstViewController
	{
		[Outlet]
		UIKit.UIButton Btn { get; set; }

		[Outlet]
		UIKit.UILabel lbl { get; set; }

		[Action ("OnButtonClicked:")]
		partial void OnButtonClicked (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (Btn != null) {
				Btn.Dispose ();
				Btn = null;
			}

			if (lbl != null) {
				lbl.Dispose ();
				lbl = null;
			}
		}
	}
}
