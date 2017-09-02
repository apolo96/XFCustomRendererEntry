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
using Xamarin.Forms;
using App1.Droid;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(Entry), typeof(ApEntryRenderer))]
namespace App1.Droid
{
    class ApEntryRenderer: EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                Control.Background = Android.App.Application.Context.GetDrawable(Resource.Drawable.crentry);
                Control.Gravity = GravityFlags.CenterVertical;
                Control.SetPadding(10,10,10,10);
            }
        }
    }
}