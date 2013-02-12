using System;
using MonoTouch.UIKit;
using System.Collections.Generic;

namespace MyLucid
{
	public class LucidTableSource : UITableViewSource {
		List<String> tableItems;
		string cellIdentifier = "TableCell";
		public LucidTableSource (List<String> items)
		{
			tableItems = items;
		}
		public override int RowsInSection (UITableView tableview, int section)
		{
			return tableItems.Count;
		}
		public override UITableViewCell GetCell (UITableView tableView, MonoTouch.Foundation.NSIndexPath indexPath)
		{
			LucidTableViewCell cell = tableView.DequeueReusableCell (cellIdentifier) as LucidTableViewCell;
			cell.titleLabel.Text = tableItems[indexPath.Row];
		
		return cell;
		}
	   	
		public override bool CanEditRow (UITableView tableView, MonoTouch.Foundation.NSIndexPath indexPath)
		{
			return false;
		}

		public override bool CanMoveRow (UITableView tableView, MonoTouch.Foundation.NSIndexPath indexPath)
		{
			return false;
		}

		public override void RowSelected (UITableView tableView, MonoTouch.Foundation.NSIndexPath indexPath)
		{
			Console.WriteLine("Row Selected");
		}

		public override void RowDeselected (UITableView tableView, MonoTouch.Foundation.NSIndexPath indexPath)
		{
			Console.WriteLine("Row Deselected");
		}
	}
}

