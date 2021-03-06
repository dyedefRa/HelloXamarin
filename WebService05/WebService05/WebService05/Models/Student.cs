using System;
using System.Collections.Generic;
using System.Text;

namespace WebService05.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public string About { get; set; }
        public bool isDeleted { get; set; } = false;
    }
}
