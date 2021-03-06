using HelloXamarin4.Helper;
using HelloXamarin4.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloXamarin4.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SQLiteListPage : ContentPage
    {
        public SQLiteListPage()
        {
            InitializeComponent();

          
            SQLiteManager sQLiteManager = new SQLiteManager();
            List<Student> students = sQLiteManager.GetStudents();

            lstStudents.BindingContext = students;
        }
    }
}