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
    public partial class RoomChatPage : ContentPage
    {
        DbFireBase dbFireBase;
        //Room currentRoom = new Room();
        public RoomChatPage()
        {
            InitializeComponent();
            dbFireBase = new DbFireBase();
            _lstChat.BindingContext = dbFireBase.GetAllMessage(User.CurrentRoom.Key);
            //MessagingCenter.Subscribe<RoomListPage, Room>(this, "currentRoom", (page, data) =>
            //    {
            //        currentRoom = data;
            //        MessagingCenter.Unsubscribe<RoomListPage, Room>(this, "currentRoom");
            //    });

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Chat chat = new Chat();
            chat.Message = _message.Text;
            chat.UserName = User.UserName;
            //dbFireBase.SendMessage(chat, currentRoom.Key);
            dbFireBase.SendMessage(chat, 
User.CurrentRoom.Key);
            _message.Text = "";
        }
    }
}