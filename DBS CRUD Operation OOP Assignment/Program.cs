using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBS_CRUD_Operation_OOP_Assignment
{
    class Program
    {
        static List<Student> students = new List<Student>();
        static List<Administrator> administrators = new List<Administrator>();
        static List<Lecturer> lecturers = new List<Lecturer>();
        static void Main(string[] args)
        {
            prompt();
            Console.Write("Enter Your Choice: ");
            int choice = int.Parse(Console.ReadLine());
            while(choice != 0)
            switch(choice)
            {
                case 1:
                        Console.WriteLine();
                        promptype();
                        Console.Write("Enter Your Choice: ");
                        int type = int.Parse(Console.ReadLine());
                        switch(type)
                        {
                            case 1:
                                EnterStudent();
                                break;
                            case 2:
                                EnterAdmin();
                                break;
                            case 3:
                                break;
                        }
                        break;
                case 2:
                        Console.WriteLine();
                        promptype();
                        Console.Write("Enter Your Choice: ");
                        type = int.Parse(Console.ReadLine());
                        switch (type)
                        {
                            case 1:
                                
                                break;
                            case 2:
                                break;
                            case 3:
                                break;
                        }
                        break;
                case 3:
                        Console.WriteLine();
                        promptype();
                        Console.Write("Enter Your Choice: ");
                        type = int.Parse(Console.ReadLine());
                        switch (type)
                        {
                            case 1:
                                break;
                            case 2:
                                break;
                            case 3:
                                break;
                        }
                        break;
                case 4:
                        Console.WriteLine();
                        promptype();
                        Console.Write("Enter Your Choice: ");
                        type = int.Parse(Console.ReadLine());
                        switch (type)
                        {
                            case 1:
                                break;
                            case 2:
                                break;
                            case 3:
                                break;
                        }
                        break;
                case 5:
                        Console.WriteLine();
                        promptype();
                        Console.Write("Enter Your Choice: ");
                        type = int.Parse(Console.ReadLine());
                        switch (type)
                        {
                            case 1:
                                break;
                            case 2:
                                break;
                            case 3:
                                break;
                        }
                        break;
                default:
                    Console.Write("Invalid Input Enter Value Again: ");
                    choice = int.Parse(Console.ReadLine());
                    break;
            }
        }
        static void prompt()
        {
            Console.WriteLine("1) Insert Record: ");
            Console.WriteLine("2) Update Record: ");
            Console.WriteLine("3) Delete Record: ");
            Console.WriteLine("4) Find Record: ");
            Console.WriteLine("5) Show All: ");
            Console.WriteLine("0) Quit: ");
        }
        static void promptype()
        {
            Console.WriteLine("1) Student: ");
            Console.WriteLine("2) Adminstrator: ");
            Console.WriteLine("3) Lecturer: ");
        }
        static void EnterStudent()
        {
            Console.WriteLine();
            Console.Write("Enter Student ID: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Enter Student Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Phone: ");
            int phone = int.Parse(Console.ReadLine());
            Console.Write("Enter Email Address: ");
            string Email = Console.ReadLine();
            Console.Write("Enter Status (1.Postgrad, 2.Undergrad): ");
            int status = int.Parse(Console.ReadLine());
            Student student;
            if (status == 1)
                student = new Student(id, "Postgrad", name, phone, Email);
            else
                student = new Student(id, "Undergrad", name, phone, Email);
            students.Add(student);
        }
        static void EnterAdmin()
        {
            Console.WriteLine();
            Console.Write("Enter Admin Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Phone: ");
            int phone = int.Parse(Console.ReadLine());
            Console.Write("Enter Email Address: ");
            string Email = Console.ReadLine();
            Console.Write("Enter Grade (1.Registrar, 2.ExamOfficer, 3.Senior, 4.Junior): ");
            int grade = int.Parse(Console.ReadLine());
            Administrator administrator;
            if (grade == 1)
                administrator = new Administrator("Registrar", name, phone, Email);
            else if(grade == 2)
                administrator = new Administrator("ExamOfficer", name, phone, Email);
            else if (grade == 3)
                administrator = new Administrator("Senior", name, phone, Email);
            else 
                administrator = new Administrator("Junior", name, phone, Email);
            administrators.Add(administrator);
        }
        static void EnterLecturer()
        {
            Console.WriteLine();
            Console.Write("Enter Lecturer Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Phone: ");
            int phone = int.Parse(Console.ReadLine());
            Console.Write("Enter Email Address: ");
            string Email = Console.ReadLine();
            Console.Write("Enter Department (1.Law, 2.Arts, 3.Professional, 4.Bussiness): ");
            int department = int.Parse(Console.ReadLine());
            Lecturer lecturer;
            if (department == 1)
                lecturer = new Lecturer("Law", name, phone, Email);
            else if (department == 2)
                lecturer = new Lecturer("Arts", name, phone, Email);
            else if (department == 3)
                lecturer = new Lecturer("Professional", name, phone, Email);
            else
                lecturer = new Lecturer("Bussiness", name, phone, Email);
            lecturers.Add(lecturer);
        }
    }
}
