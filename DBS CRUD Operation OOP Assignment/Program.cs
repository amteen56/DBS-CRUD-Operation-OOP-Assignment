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
                                Console.WriteLine("Student Enterd Successfully.....\nGoing Back to Main Prompt...\n\n");
                                break;
                            case 2:
                                EnterAdmin();
                                Console.WriteLine("Admin Enterd Successfully.....\nGoing Back to Main Prompt...\n\n");
                                break;
                            case 3:
                                EnterLecturer();
                                Console.WriteLine("Lecturer Enterd Successfully.....\nGoing Back to Main Prompt...\n\n");
                                break;
                        }
                        prompt();
                        Console.Write("Enter Your Choice: ");
                        choice = int.Parse(Console.ReadLine());
                        break;
                case 2:
                        Console.WriteLine();
                        promptype();
                        Console.Write("Enter Your Choice: ");
                        type = int.Parse(Console.ReadLine());
                        switch (type)
                        {
                            case 1:
                                EditStudent();
                                Console.WriteLine("Student Edited Successfully.....\nGoing Back to Main Prompt...\n\n");
                                break;
                            case 2:
                                EditAdmin();
                                Console.WriteLine("Admin Edited Successfully.....\nGoing Back to Main Prompt...\n\n");
                                break;
                            case 3:
                                EditLecturer();
                                Console.WriteLine("Lecturer Edited Successfully.....\nGoing Back to Main Prompt...\n\n");
                                break;
                        }
                        prompt();
                        Console.Write("Enter Your Choice: ");
                        choice = int.Parse(Console.ReadLine());
                        break;
                case 3:
                        Console.WriteLine();
                        promptype();
                        Console.Write("Enter Your Choice: ");
                        type = int.Parse(Console.ReadLine());
                        switch (type)
                        {
                            case 1:
                                Console.Write("Enter Email Address: ");
                                string Email = Console.ReadLine();
                                if (!verifyemail(Email, 's'))
                                {
                                    bool yes = true;
                                    while (yes)
                                    {
                                        Console.Write("Invalid Email....\nEnter Email Address: ");
                                        Email = Console.ReadLine();
                                        if (verifyemail(Email, 's'))
                                            yes = false;
                                    }
                                }
                                students.RemoveAll(c => c.Email == Email);
                                Console.WriteLine("Student Record Deleted Successfully.....\nGoing Back to Main Prompt...\n\n");
                                break;
                            case 2:
                                Console.Write("Enter Email Address: ");
                                Email = Console.ReadLine();
                                if (!verifyemail(Email, 'a'))
                                {
                                    bool yes = true;
                                    while (yes)
                                    {
                                        Console.Write("Invalid Email....\nEnter Email Address: ");
                                        Email = Console.ReadLine();
                                        if (verifyemail(Email, 'a'))
                                            yes = false;
                                    }
                                }
                                administrators.RemoveAll(c => c.Email == Email);
                                Console.WriteLine("Admin Record Deleted Successfully.....\nGoing Back to Main Prompt...\n\n");
                                break;
                            case 3:
                                Console.Write("Enter Email Address: ");
                                Email = Console.ReadLine();
                                if (!verifyemail(Email, 'l'))
                                {
                                    bool yes = true;
                                    while (yes)
                                    {
                                        Console.Write("Invalid Email....\nEnter Email Address: ");
                                        Email = Console.ReadLine();
                                        if (verifyemail(Email, 'l'))
                                            yes = false;
                                    }
                                }
                                lecturers.RemoveAll(c => c.Email == Email);
                                Console.WriteLine("Lecturer Record Deleted Successfully.....\nGoing Back to Main Prompt...\n\n");
                                break;
                        }
                        prompt();
                        Console.Write("Enter Your Choice: ");
                        choice = int.Parse(Console.ReadLine());
                        break;
                case 4:
                        Console.WriteLine();
                        promptype();
                        Console.Write("Enter Your Choice: ");
                        type = int.Parse(Console.ReadLine());
                        switch (type)
                        {
                            case 1:
                                Console.Write("Enter Email Address: ");
                                string Email = Console.ReadLine();
                                if (!verifyemail(Email, 's'))
                                {
                                    bool yes = true;
                                    while (yes)
                                    {
                                        Console.Write("Invalid Email....\nEnter Email Address: ");
                                        Email = Console.ReadLine();
                                        if (verifyemail(Email, 's'))
                                            yes = false;
                                    }
                                }
                                var list = students.Where(c => c.Email == Email).ToList();
                                foreach (var item in list)
                                {
                                    Console.WriteLine("\n..........................................");
                                    Console.WriteLine(item.ToString());
                                    Console.WriteLine("..........................................");
                                }
                                Console.WriteLine("\nGoing Back to Main Prompt...\n\n");
                                break;
                            case 2:
                                Console.Write("Enter Email Address: ");
                                Email = Console.ReadLine();
                                if (!verifyemail(Email, 'a'))
                                {
                                    bool yes = true;
                                    while (yes)
                                    {
                                        Console.Write("Invalid Email....\nEnter Email Address: ");
                                        Email = Console.ReadLine();
                                        if (verifyemail(Email, 'a'))
                                            yes = false;
                                    }
                                }
                                var list1 = administrators.Where(c => c.Email == Email).ToList();
                                foreach (var item in list1)
                                {
                                    Console.WriteLine("\n..........................................");
                                    Console.WriteLine(item.ToString());
                                    Console.WriteLine("..........................................");
                                }
                                Console.WriteLine("\nGoing Back to Main Prompt...\n\n");
                                break;
                            case 3:
                                Console.Write("Enter Email Address: ");
                                Email = Console.ReadLine();
                                if (!verifyemail(Email, 'l'))
                                {
                                    bool yes = true;
                                    while (yes)
                                    {
                                        Console.Write("Invalid Email....\nEnter Email Address: ");
                                        Email = Console.ReadLine();
                                        if (verifyemail(Email, 'l'))
                                            yes = false;
                                    }
                                }
                                var list2 = lecturers.Where(c => c.Email == Email).ToList();
                                foreach (var item in list2)
                                {
                                    Console.WriteLine("\n..........................................");
                                    Console.WriteLine(item.ToString());
                                    Console.WriteLine("..........................................");
                                }
                                Console.WriteLine("\nGoing Back to Main Prompt...\n\n");
                                break;
                        }
                        prompt();
                        Console.Write("Enter Your Choice: ");
                        choice = int.Parse(Console.ReadLine());
                        break;
                default:
                    Console.Write("Invalid Input...\n Enter Choice Again: ");
                    choice = int.Parse(Console.ReadLine());
                    break;
            }
        }
        static void prompt()
        {
            Console.WriteLine("\n\n1) Insert Record: ");
            Console.WriteLine("2) Update Record: ");
            Console.WriteLine("3) Delete Record: ");
            Console.WriteLine("4) Find Record: ");
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
            while (status < 1 || status > 2)
            {
                Console.Write("Invalid Input...\nEnter Status (1.Postgrad, 2.Undergrad): ");
                status = int.Parse(Console.ReadLine());
            }
            Student student;
            if (status == 1)
                student = new Student(id, "Postgrad", name, phone, Email);
            else
                student = new Student(id, "Undergrad", name, phone, Email);
            students.Add(student);
        }
        static void EditStudent()
        {
            Console.WriteLine();

            Console.Write("Enter Email Address: ");
            string Email = Console.ReadLine();
            if(!verifyemail(Email, 's'))
            {
                bool yes = true;
                while (yes)
                {
                    Console.Write("Invalid Email....\nEnter Email Address: ");
                    Email = Console.ReadLine();
                    if (verifyemail(Email, 's'))
                        yes = false;
                }
            }
            Console.Write("Enter Student ID: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Enter Student Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Phone: ");
            int phone = int.Parse(Console.ReadLine());
            
            Console.Write("Enter Status (1.Postgrad, 2.Undergrad): ");
            int status = int.Parse(Console.ReadLine());
            while(status!=1||status!=2)
            {
                Console.Write("Invalid Input...\nEnter Status (1.Postgrad, 2.Undergrad): ");
                status = int.Parse(Console.ReadLine());
            }
            students.RemoveAll(c => c.Email == Email);
            Student student;
            if (status == 1)
                student = new Student(id, "Postgrad", name, phone, Email);
            else
                student = new Student(id, "Undergrad", name, phone, Email);
            students.Add(student);
        }
        static bool verifyemail(string email, char type)
        {
            switch(type)
            {
                case 's':
                    foreach (var item in students)
                    {
                        if (item.Email == email) return true;
                    }
                    break;
                case 'a':
                    foreach (var item in administrators)
                    {
                        if (item.Email == email) return true;
                    }
                    break;
                case 'l':
                    foreach (var item in lecturers)
                    {
                        if (item.Email == email) return true;
                    }
                    break;
            }
            return false;
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
            while (grade < 1 || grade > 4)
            {
                Console.Write("Invalid Input...\nEnter Grade (1.Registrar, 2.ExamOfficer, 3.Senior, 4.Junior): ");
                grade = int.Parse(Console.ReadLine());
            }
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
        static void EditAdmin()
        {
            Console.WriteLine();
            Console.Write("Enter Email Address: ");
            string Email = Console.ReadLine();
            if (!verifyemail(Email, 'a'))
            {
                bool yes = true;
                while (yes)
                {
                    Console.Write("Invalid Email....\nEnter Email Address: ");
                    Email = Console.ReadLine();
                    if (verifyemail(Email, 'a'))
                        yes = false;
                }
            }
            Console.Write("Enter Admin Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Phone: ");
            int phone = int.Parse(Console.ReadLine());
            Console.Write("Enter Grade (1.Registrar, 2.ExamOfficer, 3.Senior, 4.Junior): ");
            int grade = int.Parse(Console.ReadLine());
            while (grade < 1 || grade > 4)
            {
                Console.Write("Invalid Input...\nEnter Grade (1.Registrar, 2.ExamOfficer, 3.Senior, 4.Junior): ");
                grade = int.Parse(Console.ReadLine());
            }
            administrators.RemoveAll(c => c.Email == Email);
            Administrator administrator;
            if (grade == 1)
                administrator = new Administrator("Registrar", name, phone, Email);
            else if (grade == 2)
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
            Console.Write("Enter Subject Taught: ");
            string sub = Console.ReadLine();
            Console.Write("Enter Employee Type (1.Job Sharing, 2.FT, 3.PT): ");
            int emptype = int.Parse(Console.ReadLine());
            while (emptype < 1 || emptype > 3)
            {
                Console.Write("Invalid Input...\nEnter Employee Type (1.Job Sharing, 2.FT, 3.PT): ");
                emptype = int.Parse(Console.ReadLine());
            }
            Console.Write("Enter Department (1.Law, 2.Arts, 3.Professional, 4.Bussiness): ");
            int department = int.Parse(Console.ReadLine());
            while (department < 1 || department > 4)
            {
                Console.Write("Invalid Input...\nEnter Department (1.Law, 2.Arts, 3.Professional, 4.Bussiness): ");
                department = int.Parse(Console.ReadLine());
            }
            Console.Write("Enter Salary: ");
            int salary = int.Parse(Console.ReadLine());
            string employeetype = "";
            switch(emptype)
            {
                case 1:
                    employeetype = "Job Sharing";
                    break;
                case 2:
                    employeetype = "FT";
                    break;
                case 3:
                    employeetype = "PT";
                    break;
            }
            Lecturer lecturer;
            if (department == 1)
                lecturer = new Lecturer("Law", sub, employeetype,salary, name, phone, Email);
            else if (department == 2)
                lecturer = new Lecturer("Arts", sub, employeetype, salary, name, phone, Email);
            else if (department == 3)
                lecturer = new Lecturer("Professional", sub, employeetype, salary, name, phone, Email);
            else
                lecturer = new Lecturer("Bussiness", sub, employeetype, salary, name, phone, Email);
            lecturers.Add(lecturer);
        }

        static void EditLecturer()
        {
            Console.WriteLine();
            Console.Write("Enter Email Address: ");
            string Email = Console.ReadLine();
            if (!verifyemail(Email, 'a'))
            {
                bool yes = true;
                while (yes)
                {
                    Console.Write("Invalid Email....\nEnter Email Address: ");
                    Email = Console.ReadLine();
                    if (verifyemail(Email, 'a'))
                        yes = false;
                }
            }
            Console.Write("Enter Lecturer Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Phone: ");
            int phone = int.Parse(Console.ReadLine());
            Console.Write("Enter Subject Taught: ");
            string sub = Console.ReadLine();
            Console.Write("Enter Employee Type (1.Job Sharing, 2.FT, 3.PT): ");
            int emptype = int.Parse(Console.ReadLine());
            while (emptype < 1 || emptype > 3)
            {
                Console.Write("Invalid Input...\nEnter Employee Type (1.Job Sharing, 2.FT, 3.PT): ");
                emptype = int.Parse(Console.ReadLine());
            }
            Console.Write("Enter Department (1.Law, 2.Arts, 3.Professional, 4.Bussiness): ");
            int department = int.Parse(Console.ReadLine());
            while (department < 1 || department > 4)
            {
                Console.Write("Invalid Input...\nEnter Department (1.Law, 2.Arts, 3.Professional, 4.Bussiness): ");
                department = int.Parse(Console.ReadLine());
            }
            Console.Write("Enter Salary: ");
            int salary = int.Parse(Console.ReadLine());
            string employeetype = "";
            switch (emptype)
            {
                case 1:
                    employeetype = "Job Sharing";
                    break;
                case 2:
                    employeetype = "FT";
                    break;
                case 3:
                    employeetype = "PT";
                    break;
            }
            lecturers.RemoveAll(c => c.Email == Email);
            Lecturer lecturer;
            if (department == 1)
                lecturer = new Lecturer("Law", sub, employeetype, salary, name, phone, Email);
            else if (department == 2)
                lecturer = new Lecturer("Arts", sub, employeetype, salary, name, phone, Email);
            else if (department == 3)
                lecturer = new Lecturer("Professional", sub, employeetype, salary, name, phone, Email);
            else
                lecturer = new Lecturer("Bussiness", sub, employeetype, salary, name, phone, Email);
            lecturers.Add(lecturer);
        }
    }
}
