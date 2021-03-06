using HelloXamarin3.Helper;
using HelloXamarin3.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloXamarin3
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            string deviceName = DependencyService.Get<IDeviceHelper>()
                .GetDeviceName();
            MainPage =new FirstPage(deviceName);
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
