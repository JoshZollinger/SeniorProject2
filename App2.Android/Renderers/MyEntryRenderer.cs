using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using App2;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using CustomEntry;
using CustomRenderer;
using Android.Graphics.Drawables;

[assembly: ExportRenderer(typeof(MyEntry),typeof(MyEntryRenderer))]
namespace CustomRenderer
{
    public class MyEntryRenderer : EntryRenderer
    {
        public MyEntryRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            
            if (Control != null)
            {
                var gradientDrawable = new GradientDrawable();
                gradientDrawable.SetCornerRadius(90f);
                gradientDrawable.SetStroke(5, Android.Graphics.Color.White);
                gradientDrawable.SetColor(Android.Graphics.Color.White);

                Control.SetBackground(gradientDrawable);
                
                //Control.SetBackgroundColor(global::Android.Graphics.Color.LawnGreen);
                Control.SetTextSize(global::Android.Util.ComplexUnitType.Dip, 12);
                Control.SetTextColor(global::Android.Graphics.Color.DarkRed);
                Control.SetPadding(0,0,0,0);
                Control.Gravity = GravityFlags.Center;
                Control.SetMinHeight(100);
            }
        }
    }
}