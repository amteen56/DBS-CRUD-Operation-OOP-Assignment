using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBS_CRUD_Operation_OOP_Assignment
{
    class Lecturer : Employee
    {
        public readonly string SubjectTaught ;
        public readonly string Department ;
        public Lecturer(string d,string a,string b, int s, string N, int p, string e)
        {
            SubjectTaught = a;
            EmployeeType = b;
            Salary = s;
            Department = d;
            Name = N;
            Phone = p;
            Email = e;
        }
        public override string ToString()
        {
            return "Name: " + Name + "\nPhone: " + Phone + "\nEmail: " + Email + "\nSubject Taught: " + SubjectTaught + "\nEmployee Type: " + EmployeeType + "\nSalary: " + Salary + "\nDepartment: " + Department;
        }
    }
}
