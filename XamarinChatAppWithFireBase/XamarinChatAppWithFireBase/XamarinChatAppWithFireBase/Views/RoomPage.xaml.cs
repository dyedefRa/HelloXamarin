using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinChatAppWithFireBase.Database;

namespace XamarinChatAppWithFireBase.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RoomPage : ContentPage
    {
        //async metodları ctor da yazamıyoruz ama OnAppearing yani sayfa görüntulendıgınde override ederek calıstırabılıyoruz
        DbFire dbFire = new DbFire();
        protected override void OnAppearing()
        {
            base.OnAppearing();
            lstView.BindingContext =  dbFire.GetRoomList();
        }
        public RoomPage()
        {
            InitializeComponent();
        }

        private void Plus_Clicked(object sender, EventArgs e)
        {

        }

        private void Quest_Clicked(object sender, EventArgs e)
        {

        }

        private void ListView_Refreshing(object sender, EventArgs e)
        {

        }
    }
}