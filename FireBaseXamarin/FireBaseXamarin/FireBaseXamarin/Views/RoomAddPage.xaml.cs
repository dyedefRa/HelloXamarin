using FirebaseXamarin.Helper;
using FirebaseXamarin.Model;
using System;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FirebaseXamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RoomAddPage : ContentPage
    {
        public RoomAddPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var db = new DbFireBase();
            db.AddRoom(new Room() { Name = rootName.Text });
            await Navigation.PopAsync();
        }
    }
}