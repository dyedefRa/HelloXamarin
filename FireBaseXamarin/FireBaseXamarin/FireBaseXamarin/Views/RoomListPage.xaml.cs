using FirebaseXamarin.Helper;
using FirebaseXamarin.Model;
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
            DisplayAlert("Current User ", User.UserName, "Okey");
        }

        private async void ListView_Refreshing(object sender, EventArgs e)
        {
            lstView.BindingContext = await dbFire.GetRoomList();
            lstView.IsRefreshing = false;
        }

        private void lstView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

            if (e.SelectedItem != null)
            {
                Room selectedRoom = (Room)e.SelectedItem;

                //MessagingCenter.Send<RoomListPage, Room>(this, "currentRoom", selectedRoom);
                User.CurrentRoom = selectedRoom;

                Navigation.PushAsync(new RoomChatPage());
            }
        }
    }
}