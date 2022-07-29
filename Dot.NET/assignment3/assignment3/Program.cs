using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//1.Create an Employee class(Empid, Name, Address, City, Department, Salary) and define properties to read and write the values. Salary should not be editable outside employee class but it should be readable outside.

//- Then extend this class and create two derived classes called as ContractEmployee and PermanentEmployee

//- The contract employee will have perks as an additional property
//- The permanent employee will have no.ofleaves and Providentfund property additionally

//Task 1: Override the GetSalary Method in these 2 classes
//        For contract employee the new salary will be Salary + Perks
//        For permanent employee the new salary will be Salary-Providentfund

//Task 2: Create a Console application to use these classes
//        Develop a menu driven application to select the type of employee
//        Based on the user selection create the object and accept the details from the user, and display the salary of the employee

//Task : Incorporate relevant methods in the classes

namespace Assignment3
{


    abstract class student
    {
        public string name;
        public string studentId;
        public double grade;
        // abstract method
        public abstract bool Ispassed(double grad);
    }

    class Undergraduate : student
    {
        public override bool Ispassed(double grad)
        {
            if (grad > 70.0f)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    class Graduate : student
    {
        public override bool Ispassed(double grad)
        {
            if (grad > 80.0f)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    class Employee
    {
        public int empid { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string Dep { get; set; }
        public int salary { get; set; }

        public virtual void getsalary()
        {
            Console.WriteLine("Actual salary of the EMployee will be" + this.salary);
        }
    }

    class PermanentEmployee : Employee
    {
        private int pfund { get; set; }

        public PermanentEmployee(int a, string b, string c, string d, string e, int f, int g)
        {
            this.empid = a;
            this.name = b;
            this.address = c;
            this.city = d;
            this.Dep = e;
            this.salary = f;
            this.pfund = g;
        }
        public override void getsalary()
        {
            Console.WriteLine("New salary for the EMployee will be" + (salary - pfund));
        }
    }

    class ContractEmployee : Employee
    {
        private int perks { get; set; }


        public ContractEmployee(int a, string b, string c, string d, string e, int f, int g)
        {
            this.empid = a;
            this.name = b;
            this.address = c;
            this.city = d;
            this.Dep = e;
            this.salary = f;
            this.perks = g;
        }
        public override void getsalary()
        {
            Console.WriteLine("Updated Salary of the Employee: " + (salary + perks));
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t##PART 1 - Banking##\n\n");

            Console.WriteLine("Enter Details of Your Employee");

            Console.WriteLine("Enter the Emp ID");
            int emp_id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter name of the Employee");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Address of Employee");
            string address = Console.ReadLine();
            Console.WriteLine("Enter the City of Employee");
            string city = Console.ReadLine();
            Console.WriteLine("Enter the Department of Employee");
            string dept = Console.ReadLine();
            Console.WriteLine("Enter the salary of the Employee");
            int salary = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Select the type of Emplpoyee");
            Console.WriteLine("1 . Contract Based");
            Console.WriteLine("2 . Full Time");

            int a = Convert.ToInt32(Console.ReadLine()); ;

            if (a == 1)
            {
                Console.WriteLine("Enter the Perks Earned by the Employee");
                int perks = Convert.ToInt32(Console.ReadLine());
                ContractEmployee obj = new ContractEmployee(emp_id, name, address, city, dept, salary, perks);
                obj.getsalary();
            }
            else if (a == 2)
            {
                Console.WriteLine("Enter the Provident fund of the Employee");
                int pfunds = Convert.ToInt32(Console.ReadLine());
                PermanentEmployee obj = new PermanentEmployee(emp_id, name, address, city, dept, salary, pfunds);
                obj.getsalary();
            }


            Undergraduate A = new Undergraduate();
            Graduate B = new Graduate();

            Console.WriteLine("\n\n\t\t\t#####Part 2 - School Management#####\n\n");

            Console.WriteLine("1. Undergraduate");
            Console.WriteLine("2. Graduate");

            int aa = Convert.ToInt32(Console.ReadLine());

            if (aa == 1)
            {
                Console.WriteLine("Enter the Name of Student");
                A.name = Console.ReadLine();
                Console.WriteLine("Enter the StudentId");
                A.studentId = Console.ReadLine();
                Console.WriteLine("Enter the Grade Point of the Student (1-5)");
                A.grade = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Result of Student is " + A.Ispassed(A.grade));
            }
            else if (aa == 2)
            {
                Console.WriteLine("Enter the Name of Student");
                B.name = Console.ReadLine();
                Console.WriteLine("Enter the StudentId");
                B.studentId = Console.ReadLine();
                Console.WriteLine("Enter the Grade Point of the Student");
                B.grade = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Result of Student is " + B.Ispassed(B.grade));
            }
            else
            {
                Console.WriteLine("Wrong Input");
            }

            Console.ReadLine();
        }
    }
}

