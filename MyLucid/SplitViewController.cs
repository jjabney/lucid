
using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace MyLucid
{
	public partial class SplitViewController : UISplitViewController
	{
		UIViewController masterView, detailView;

		public SplitViewController (IntPtr handle) : base (handle)
		{
			this.Title = NSBundle.MainBundle.LocalizedString ("Send", "Send");
			this.TabBarItem.Image = UIImage.FromBundle ("first");
			// create our master and detail view
		
			//	detailView = new DetailViewController ();
	
				// create an array of controllers from them and then

					// assign it to the controllers property

		
		}
		
		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}
		
		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			masterView = this.Storyboard.InstantiateViewController("masterViewCtrlr") as MasterViewController;
			detailView = this.Storyboard.InstantiateViewController("detailViewCtrlr") as DetailViewController;
			ViewControllers = new UIViewController[]{

				masterView,
				detailView
			};
			
			// Perform any additional setup after loading the view, typically from a nib.
		}
		
		public override void ViewDidUnload ()
		{
			base.ViewDidUnload ();
			
			// Clear any references to subviews of the main view in order to
			// allow the Garbage Collector to collect them sooner.
			//
			// e.g. myOutlet.Dispose (); myOutlet = null;
			
			ReleaseDesignerOutlets ();
		}
		
		public override bool ShouldAutorotateToInterfaceOrientation (UIInterfaceOrientation toInterfaceOrientation)
		{
			// Return true for supported orientations
			return true;
		}
	}
}

