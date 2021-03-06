using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebService05.Providers;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WebService05.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListPage : ContentPage
    {
        readonly ServiceManager manager = new ServiceManager();
        public ListPage()
        {
            InitializeComponent();
            LoadData();
        }

        private async void LoadData()
        {
            try
            {
                var collection = await manager.GetStudents();
                lstView.BindingContext = collection;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {

            }
        }
    }
}