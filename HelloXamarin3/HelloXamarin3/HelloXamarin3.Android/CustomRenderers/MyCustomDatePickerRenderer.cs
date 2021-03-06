using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using HelloXamarin3.CustomControls;
using HelloXamarin3.Droid.CustomRenderers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms.Platform.Android;

[assembly:Xamarin.Forms.ExportRenderer(typeof(MyCustomDatePicker),typeof(MyCustomDatePickerRenderer))]
namespace HelloXamarin3.Droid.CustomRenderers
{
    [Obsolete]
    public class MyCustomDatePickerRenderer:DatePickerRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.DatePicker> e)
        {
            base.OnElementChanged(e);

            MyCustomDatePicker myCustomDatePicker =(MyCustomDatePicker) Element;

            if (myCustomDatePicker!=null)
            {
                Control.SetTextColor(myCustomDatePicker.TextColor.ToAndroid());
            }
        }
    }
}