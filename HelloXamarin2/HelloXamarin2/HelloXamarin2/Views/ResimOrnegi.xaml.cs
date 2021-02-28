using HelloXamarin2.Data;
using System.Linq;
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
            //lstMVA.ItemsSource = MVAFactory.BindingGroupData();
            lstMVA.ItemsSource = MVAFactory.MVAData;
            //mySearchBar.Text=Device.Android

            //Dokunduğumda bir animasyon eventi tetikledim!
            //lstMVA.GestureRecognizers.Add(
            //    new TapGestureRecognizer
            //    {
            //        Command = new Command(async (t) =>
            //        {
            //            await lstMVA.ScaleTo(.95, 100, Easing.CubicOut);
            //            await lstMVA.ScaleTo(1, 50, Easing.CubicIn);
            //            await lstMVA.RotateYTo(360, 1500, Easing.SpringIn);
            //        })
            //    });
        }

        private async void lstMVA_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;

            var selectedData = (MVAFactory.MVA)e.SelectedItem;
            bool isOkey = await DisplayAlert(selectedData.PublishedDate.ToString("dd-MM-yyyy"), selectedData.Description, "Detaylar", "Vazgeç");
            if (isOkey)
            {
                await Navigation.PushModalAsync(new DetailPopup(selectedData));
            }

        }

        private void lstMVA_Refreshing(object sender, System.EventArgs e)
        {
            DisplayAlert("Refleshing Metodu Çalıştı", "Çalıştı", "Tamam");
            lstMVA.IsRefreshing = false;
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(e.NewTextValue) || e.NewTextValue == "")
            {
                lstMVA.ItemsSource = MVAFactory.MVAData;
                return;
            }

            var newList = MVAFactory.MVAData.Where(x => x.Title.Contains(e.NewTextValue) || x.Description.Contains(e.NewTextValue)).ToList();
            lstMVA.ItemsSource = newList;
        }

        private void MenuItem_Clicked(object sender, System.EventArgs e)
        {
            DisplayAlert("Ozellik", "Güncelledin", "Tamam", "Vazgeç");
        }

        private void MenuItem_Clicked_1(object sender, System.EventArgs e)
        {
            DisplayAlert("Ozellik", "Sildin", "Tamam", "Vazgeç");
        }
    }
}