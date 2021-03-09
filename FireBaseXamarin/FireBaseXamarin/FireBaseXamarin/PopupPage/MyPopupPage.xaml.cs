using FirebaseXamarin.Model;
using FirebaseXamarin.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace FirebaseXamarin.PopupPage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyPopupPage : ContentPage /*Rg.Plugins.Popup.Pages.PopupPage*/
    {
        public MyPopupPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_entryUserName.Text))
            {
                User.UserName = _entryUserName.Text;
                Navigation.PushModalAsync(new NavigationPage(new RoomListPage()));
                //Navigation.PushAsync(new NavigationPage(new RoomListPage()));
            }
          
        }
    }
}