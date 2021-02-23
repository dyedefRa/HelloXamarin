using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloXamarin.Views.TabbedPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TabbedPage2 : ContentPage
    {
        public TabbedPage2()
        {
            InitializeComponent();
            //this.Title = "Tabbed2 from Cs";
        }
    }
}