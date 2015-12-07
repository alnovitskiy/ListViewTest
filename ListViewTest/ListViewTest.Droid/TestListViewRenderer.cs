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
using Java.Util;
using ListViewTest;
using ListViewTest.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(TestListView), typeof(TestListViewRenderer))]
namespace ListViewTest.Droid
{
    public class TestListViewRenderer : ListViewRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.ListView> e)
        {
            base.OnElementChanged(e);
            Control.ItemLongClick += OnItemLongClick;
            Control.ItemLongClick -= OnItemLongClick;
        }

        private void OnItemLongClick(object sender, AdapterView.ItemLongClickEventArgs e)
        {
            
        }
    }    
}