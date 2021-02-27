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
            lstMVA.ItemsSource = MVAFactory.MVAData;

        }

        private void lstMVA_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;

            var selectedData = (MVAFactory.MVA)e.SelectedItem;
            DisplayAlert(selectedData.PublishedDate.ToString("dd-MM-yyyy"), selectedData.Description, "Tamam");

        }
    }
}