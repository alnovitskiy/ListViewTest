using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ListViewTest
{
    public class TestListView : ListView
    {
        public TestListView()
        {
            ItemTemplate = new DataTemplate(() => new TestItemCell());
        }
    }
}
