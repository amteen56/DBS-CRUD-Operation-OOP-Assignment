using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBS_CRUD_Operation_OOP_Assignment
{
    class Student : Person
    {
        public readonly int StudentID ;
        public readonly string Status ;
        public Student(int id,string s, string N, int p, string e)
        {
            StudentID = id;
            Status = s;
            Name = N;
            Phone = p;
            Email = e;
        }
        public override string ToString()
        {
            return "StudentID : " + StudentID + "\nName: " + Name + "\nPhone: " + Phone + "\nEmail: " + Email + "\nStatus: " + Status;
        }
    }
}
