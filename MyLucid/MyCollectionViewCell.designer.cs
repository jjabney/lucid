// WARNING
//
// This file has been generated automatically by MonoDevelop to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;

namespace MyLucid
{
	[Register ("MyCollectionViewCell")]
	partial class MyCollectionViewCell
	{
		[Outlet]
		public MonoTouch.UIKit.UILabel title { get; set; }

		[Outlet]
		public MonoTouch.UIKit.UIImageView imageView { get; set; }

		[Outlet]
		public MonoTouch.UIKit.UILabel subTitle { get; set; }

		[Outlet]
		public MonoTouch.UIKit.UILabel count { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (title != null) {
				title.Dispose ();
				title = null;
			}

			if (imageView != null) {
				imageView.Dispose ();
				imageView = null;
			}

			if (subTitle != null) {
				subTitle.Dispose ();
				subTitle = null;
			}

			if (count != null) {
				count.Dispose ();
				count = null;
			}
		}
	}
}
