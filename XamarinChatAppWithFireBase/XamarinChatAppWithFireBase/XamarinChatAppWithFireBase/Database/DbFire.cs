using Firebase.Xamarin.Database;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XamarinChatAppWithFireBase.Model;

namespace XamarinChatAppWithFireBase.Database
{
    public class DbFire
    {
        FirebaseClient firebaseClient;
        public DbFire()
        {
            firebaseClient = new FirebaseClient("https://helloxamarin-c1e38-default-rtdb.firebaseio.com/");
        }
        public async Task<List<Room>> GetRoomList()
        {
            var list = (await firebaseClient
                .Child("ChatApp")
                .OnceAsync<Room>())
                .Select(x => new Room
                {
                    Key = x.Key,
                    Name = x.Object.Name
                }).ToList();

            return list;
        }

    }
}
