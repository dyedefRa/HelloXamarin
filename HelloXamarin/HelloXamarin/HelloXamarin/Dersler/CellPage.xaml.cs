using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloXamarin.Dersler
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CellPage : ContentPage
    {
        public CellPage()
        {
            InitializeComponent();
        }

        private void sCell_OnChanged(object sender, ToggledEventArgs e)
        {
            DisplayAlert("TITLE","Değişti","CANCEL");
        }
    }
}