using HelloXamarin4.Droid.ConnectionHelper;
using HelloXamarin4.Helper;
using SQLite;

[assembly: Xamarin.Forms.Dependency(typeof(GetAndroidConnection))]
namespace HelloXamarin4.Droid.ConnectionHelper
{
    //Tüm platformlarda bunu oluşturmalısın
    public class GetAndroidConnection : ISQLiteConnection
    {
        public SQLiteConnection GetConnection()
        {
            string documentPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            string path = System.IO.Path.Combine(documentPath, App.appDbName);
            var platform = new SQLite.Net.Platform.XamarinAndroid.SQLitePlatformAndroidN();

            var connection = new SQLiteConnection(platform, path);
            return connection;
        }
    }
}