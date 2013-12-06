using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using TaskJira.Core;

namespace TaskJira
{
	[Activity (Label = "TaskJira", MainLauncher = true)]
	public class MainActivity : Activity
	{
		int count = 1;
		protected JiraTask _task = new JiraTask();
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button> (Resource.Id.myButton);
			_task.Name = "srihari";
			_task.Notes = "this is sample";
			button.Click += delegate {
				TaskJira.Core.JiraTaskManager.SaveTask(_task);
				this._task = TaskJira.Core.JiraTaskManager.GetTask(1); 
				string s = this._task.Name;
				string a = this._task.Notes;
			};
		}
	}
}


