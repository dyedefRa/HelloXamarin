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

            Entry entry = new Entry();
            Content = new StackLayout()
            {
                Children =
                {
                    lbl,
                    entry
                }
            };
        }
    }
}