using SQLite;
using System;

namespace HelloXamarin4.Model
{
    public class Student
    {
        [PrimaryKey,AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public DateTime RegisterDate { get; set; }
    }
}
