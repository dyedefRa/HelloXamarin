using HelloXamarin2.Views;
using Xamarin.Forms;

namespace HelloXamarin2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new HelloXamarin2.Views.ListView();
            MainPage = new ResimOrnegi();
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
