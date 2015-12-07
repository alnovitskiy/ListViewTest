using System;
using System.Collections.Generic;
using System.Text;
using ListViewTest;
using ListViewTest.iOS;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(TestListView), typeof(TestListViewRenderer))]
namespace ListViewTest.iOS
{
    public class TestListViewRenderer : ListViewRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.ListView> e)
        {
            base.OnElementChanged(e);
            Control.ItemLongClick += OnItemLongClick;
        }

    }
}
