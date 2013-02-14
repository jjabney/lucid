// WARNING
//
// This file has been generated automatically by MonoDevelop to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;

namespace MyLucid
{
	[Register ("LucidTableViewCell")]
	partial class LucidTableViewCell
	{
		[Outlet]
		public MonoTouch.UIKit.UILabel TitleLabel { get; set; }

		[Outlet]
		public MonoTouch.UIKit.UIImageView UIImageView { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (TitleLabel != null) {
				TitleLabel.Dispose ();
				TitleLabel = null;
			}

			if (UIImageView != null) {
				UIImageView.Dispose ();
				UIImageView = null;
			}
		}
	}
}
