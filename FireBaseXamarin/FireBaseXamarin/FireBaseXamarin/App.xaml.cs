using FirebaseXamarin.PopupPage;
using FirebaseXamarin.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FirebaseXamarin
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            //MainPage = new NavigationPage(new RoomListPage());
            MainPage = new MyPopupPage();
            //MainPage = new RoomListPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
