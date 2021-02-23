using HelloXamarin.Dersler;
using Xamarin.Forms;

namespace HelloXamarin
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new StyleileXamldeCssVerme();
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
