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
	public class JIRADatabase:SQLiteConnection
	{
		public JIRADatabase(string path):base(path)
		{
			CreateTable<JiraTask> ();
		}

		public IEnumerable<JiraTask> GetTasks()
		{
			return (from i in this.Table<JiraTask> ()
			        select i);
		}
		public JiraTask GetTask(int id)
		{
			return (from i in this.Table<JiraTask> ()
			        where i.ID == id
				select i).FirstOrDefault ();
		}
		public int SaveTask(JiraTask task)
		{
			if (task.ID != 0) {
				base.Update (task);
				return task.ID;
			} else {
				return base.Insert (task);
			}
		}
		public int DeleteTask(int Id)
		{
			return base.Delete<JiraTask> (new JiraTask (){ ID = Id });
		}
	}
}

