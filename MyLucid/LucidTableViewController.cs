
using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.Collections.Generic;
using MonoTouch.AddressBook;
using MonoTouch.MessageUI;

namespace MyLucid
{
	public partial class LucidTableViewController : UITableViewController
	{

		private List<String> _content = new List<string>();
		MFMailComposeViewController _mailController = null;

		public LucidTableViewController (IntPtr handle) : base(handle)
		{
			this.Title = NSBundle.MainBundle.LocalizedString ("Send", "Second");
			this.TabBarItem.Image = UIImage.FromBundle ("second");
			_content.Add("Shit");
			_content.Add("Fuck");
			_content.Add("Pussy");

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
		   NextButton.Clicked += OnNext;
			// Perform any additional setup after loading the view, typically from a nib.
		}

	
		void OnNext (object sender, EventArgs e)
		{
			if(_mailController == null)
			{
				_mailController  = new MFMailComposeViewController();
			}
		
			_mailController.SetMessageBody("<br /><br /><br /><br /><br /><br />Video<br />Video<br />Video<br />",true);
			this.PresentViewController(_mailController,true,null);
		}
	}
}

