using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using HelloXamarin4.Views;

namespace HelloXamarin4
{
    public partial class App : Application
    {
        public static string appDbName = "HelloXamarin4.db3";
        public App()
        {
            InitializeComponent();

            MainPage = new SQLiteListPage();
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
