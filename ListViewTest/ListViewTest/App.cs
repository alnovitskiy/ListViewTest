using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace ListViewTest
{
	public class App : Application
	{
		public App ()
		{
		    var listView = new TestListView();
		    var model = new ObservableCollection<TestItemViewModel>();
            model.Add(new TestItemViewModel() { Id = 1, Name="Item1"});
            model.Add(new TestItemViewModel() { Id = 2, Name = "Item2" });
            model.Add(new TestItemViewModel() { Id = 3, Name = "Item3" });
		    listView.ItemsSource = model;
			// The root page of your application
			MainPage = new ContentPage {
				Content = new StackLayout {
					VerticalOptions = LayoutOptions.Center,
					Children = {listView}
				}
			};
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
