using Firebase.Database;
using FirebaseXamarin.Model;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace FirebaseXamarin.Helper
{
    public class DbFireBase
    {
        FirebaseClient firebaseClient;

        public DbFireBase()
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

        public async void AddRoom(Room room)
        {
            var data = Newtonsoft.Json.JsonConvert.SerializeObject(room);
            await firebaseClient
                  .Child("ChatApp")
                  .PostAsync(data);
        }
    }
}
