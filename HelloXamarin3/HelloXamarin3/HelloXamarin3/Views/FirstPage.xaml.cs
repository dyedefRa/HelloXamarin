using HelloXamarin3.CustomControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloXamarin3.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FirstPage : ContentPage
    {
        public FirstPage(string deviceName)
        {
            InitializeComponent();
            Label lbl = new Label();
            lbl.Text = deviceName;

            MyCustomEntry myCustomEntry = new MyCustomEntry();
            Entry entry = new Entry();


            MyCustomDatePicker myCustomDatePicker = new MyCustomDatePicker();
            myCustomDatePicker.TextColor = Color.Blue;
            Content = new StackLayout()
            {
                Children =
                {
                    lbl,
                    entry,
                    myCustomEntry,
                    myCustomDatePicker
                }
            };
        }
    }
}