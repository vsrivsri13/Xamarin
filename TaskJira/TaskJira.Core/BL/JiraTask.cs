using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using TaskJira.Core.DL.SQLite;
namespace TaskJira.Core
{
	public partial class JiraTask
	{
		public JiraTask (){
		}
		[PrimaryKey,AutoIncrement]
		public int ID { get; set;}
		public string Name { get; set;}
		public string Notes { get; set;}
	}
}

