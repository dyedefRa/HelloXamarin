using FirebaseXamarin.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FirebaseXamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RoomListPage : ContentPage
    {
        //async metodları ctor da yazamıyoruz ama OnAppearing yani sayfa görüntulendıgınde override ederek calıstırabılıyoruz
        DbFireBase dbFire = new DbFireBase();
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            lstView.BindingContext = await dbFire.GetRoomList();
        }
        public RoomListPage()
        {
            InitializeComponent();
        }

        private void Plus_Clicked(object sender, EventArgs e)
        {
            //Bu sayfaya yönlendir
            Navigation.PushAsync(new RoomAddPage());
        }

        private void Quest_Clicked(object sender, EventArgs e)
        {

        }

        private async void ListView_Refreshing(object sender, EventArgs e)
        {
            lstView.BindingContext = await dbFire.GetRoomList();
            lstView.IsRefreshing = false;
        }
    }
}