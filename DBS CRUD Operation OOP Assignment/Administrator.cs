using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBS_CRUD_Operation_OOP_Assignment
{
    class Administrator : Person    
    {
        public readonly string Grade;
        public Administrator(string a, string N, int p, string e)
        {
            Grade = a;
            Name = N;
            Phone = p;
            Email = e;
        }
        public override string ToString()
        {
            return "Name: " + Name + "\nPhone: " + Phone + "\nEmail: " + Email + "\nGrade: " + Grade;
        }
    }

}
