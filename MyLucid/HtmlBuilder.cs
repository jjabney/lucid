using System;
using System.Collections.Generic;

namespace MyLucid
{
	public class HtmlBuilder
	{
		public HtmlBuilder ()
		{
		}

		private static string VideoTag (Movie movie)
		{

				return "<video width='320' height='240' controls><source src='"+  movie.Url +"' type='video/mp4'></video>";
		
		}

		public static string ToHtml (IEnumerable<LucidContent> contentItems)
		{
			string html = "Dear Patient,<br /><br /><br /><br /><br />============  Treatment Plan ====================";
			foreach (var content in contentItems) {
			
				if(content is Movie)
				{
					html += "<br /><br />" + VideoTag((Movie)content);
				}
			}
			return html;
		}
	}
}

