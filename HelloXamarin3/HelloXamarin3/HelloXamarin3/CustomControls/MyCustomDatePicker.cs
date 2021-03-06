using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using HelloXamarin3.CustomControls;

namespace HelloXamarin3.CustomControls
{
    //CustomDatePicker  oluşturuyoruz. Ve bu nesneye özellik ekleyeceğiz.
    public class MyCustomDatePicker : DatePicker
    {
        [Obsolete]
        public static new readonly BindableProperty TextColorProperty =
            BindableProperty.Create<MyCustomDatePicker, Color>
            (p => p.TextColor, Color.Red);

        [Obsolete]
        public new Color TextColor
        {
            get { return (Color)GetValue(TextColorProperty); }
            set { SetValue(TextColorProperty, value); }
        }
    }
}
