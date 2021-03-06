using HelloXamarin4.Model;
using SQLite;
using System.Collections.Generic;
using Xamarin.Forms;

namespace HelloXamarin4.Helper
{
    public class SQLiteManager 
    {
        SQLiteConnection _sqlConnection;
        public SQLiteManager()
        {
            _sqlConnection = DependencyService.Get<ISQLiteConnection>().GetConnection();
            _sqlConnection.CreateTable<Student>();
        }

        #region CRUD

        public Student GetStudent(int Id)
        {
            return _sqlConnection.Table<Student>().FirstOrDefault(x => x.Id == Id);
        }

        public List<Student> GetStudents()
        {
            return _sqlConnection.Table<Student>().ToList();
        }

        public int Insert(Student s)
        {
           return _sqlConnection.Insert(s);
        }

        public int Update(Student s)
        {
            return _sqlConnection.Update(s);
        }

        public int Delete(int Id)
        {
            return _sqlConnection.Delete<Student>(Id);
        }

        public void Dispose()
        {
            _sqlConnection.Dispose();
        }
        #endregion
    }
}
