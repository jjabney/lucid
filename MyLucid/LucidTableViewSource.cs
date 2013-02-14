using System;
using MonoTouch.UIKit;
using System.Collections.Generic;
using System.Linq;

namespace MyLucid
{
	public class LucidTableSource : UITableViewSource {

		string cellIdentifier = "TableCell";
		public LucidTableSource (List<LucidContent> items)
		{
			TableItems = items;
		}
		public override int RowsInSection (UITableView tableview, int section)
		{
			return TableItems.Count;
		}
		public override UITableViewCell GetCell (UITableView tableView, MonoTouch.Foundation.NSIndexPath indexPath)
		{
			LucidTableViewCell cell = tableView.DequeueReusableCell (cellIdentifier) as LucidTableViewCell;
			LucidContent content = TableItems[indexPath.Row];
			cell.TitleLabel.Text = content.Title;
			cell.UIImageView.Image = UIImage.FromFile(content.Image);
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

		public List<LucidContent> TableItems 
		{
			get;
			set;
		}
	
	
	}
}

