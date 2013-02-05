// WARNING
//
// This file has been generated automatically by MonoDevelop to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;

namespace MyLucid
{
	[Register ("LucidCollectionViewController")]
	partial class LucidCollectionViewController
	{
		[Outlet]
		MonoTouch.UIKit.UISegmentedControl videoFilteringSegmentedControl { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (videoFilteringSegmentedControl != null) {
				videoFilteringSegmentedControl.Dispose ();
				videoFilteringSegmentedControl = null;
			}
		}
	}
}
