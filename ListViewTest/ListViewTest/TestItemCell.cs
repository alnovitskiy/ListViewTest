using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ListViewTest
{
    public class TestItemCell : ViewCell 
    {
        public TestItemCell()
        {
            var deleteAction = new MenuItem { Text = "Delete", IsDestructive = true };
            deleteAction.Clicked += OnDeleteItem;
            ContextActions.Add(deleteAction);

            var labelId = new Label();
            labelId.SetBinding(Label.TextProperty, "Id");
            var labelName = new Label();
            labelName.SetBinding(Label.TextProperty, "Name");

            var cellLayout = new StackLayout
            {
                Padding = new Thickness(0, 0, 0, 0),
                Orientation = StackOrientation.Horizontal,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                Children = { labelId, labelName }
            };
            View = cellLayout;
        }

        private void OnDeleteItem(object sender, EventArgs e)
        {
            Console.WriteLine("Fired delete action clicked handler");
        }
    }
}
