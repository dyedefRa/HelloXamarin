using HelloXamarin2.Data;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloXamarin2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ResimOrnegi : ContentPage
    {
        public ResimOrnegi()
        {
            InitializeComponent();
            //lstMVA.BindingContext = MVAFactory.MVAData;
            lstMVA.ItemsSource= MVAFactory.MVAData;

        }
    }
}