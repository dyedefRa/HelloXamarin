using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloXamarin2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListView : ContentPage
    {

        public class OrnekSinif
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string ImageUrl { get; set; }
        }
        public ListView()
        {
            InitializeComponent();

            List<OrnekSinif> ornekList = new List<OrnekSinif>();
            ornekList.Add(new OrnekSinif() { Id = 1, Name = "Bir", ImageUrl = "Gitpush.png" });
            ornekList.Add(new OrnekSinif() { Id = 2, Name = "İki", ImageUrl = "Gitpush.png" });
            ornekList.Add(new OrnekSinif() { Id = 3, Name = "Üç", ImageUrl = "Gitpush.png" });

            //lstView.ItemsSource = ornekList;

            lstView.BindingContext = ornekList;
        }

        private void lstView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                DisplayAlert("Seçilmedi!", "Messagee", "Cancell");
            else
            {
                var sinifim = (OrnekSinif)e.SelectedItem;
                DisplayAlert("TITLE", sinifim.Name, "Cancel");
            }
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
          
            var button = (Button)sender;

            var id = button.CommandParameter;
            DisplayAlert("TITLE button", id+" id li nesne silinecek", "Cancel");
        }
    }
}