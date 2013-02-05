
using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.Collections.Generic;
using MonoTouch.AddressBook;

namespace MyLucid
{
	public partial class LucidTableViewController : UITableViewController
	{

		private List<String> _content = new List<string>();

		public LucidTableViewController (IntPtr handle) : base(handle)
		{
			this.Title = NSBundle.MainBundle.LocalizedString ("Send", "Second");
			this.TabBarItem.Image = UIImage.FromBundle ("second");
			_content.Add("Shit");
			_content.Add("Fuck");
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
			base.TableView.Source = new LucidTableSource(_content);
		
			// Perform any additional setup after loading the view, typically from a nib.
		}

	
	}
}

