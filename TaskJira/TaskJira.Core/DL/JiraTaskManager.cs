using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using TaskJira.Core.DL;

namespace TaskJira.Core
{
	public class JiraTaskManager
	{
		JIRADatabase _db = null;
		protected static string _dbLocation;
		protected static JiraTaskManager _me;
		static JiraTaskManager()
		{
			_me = new JiraTaskManager ();
		}
		protected JiraTaskManager()
		{
			_dbLocation = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "TaskDB.db3");
			this._db = new JIRADatabase (_dbLocation);
		}
		public static JiraTask GetTask(int id)
		{
			return _me._db.GetTask(id);
		}
		public static IEnumerable<JiraTask> GetTasks()
		{
			return _me._db.GetTasks ();
		}
		public static int SaveTask(JiraTask item)
		{
			return _me._db.SaveTask (item);
		}
		public static int DeleteTask(int id)
		{
			return _me._db.DeleteTask(id);
		}
	}
}

