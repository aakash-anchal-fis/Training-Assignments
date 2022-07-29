﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1.Create a class called Accounts which has data members like Account no, Customer name, Account type, Transaction type (d/w), amount, balance
//D->Deposit
//W->Withdrawal

//-write a function that updates the balance depending upon the transaction type

//	-If transaction type is deposit call the credit(int amount) function and update balance
//	-If transaction type is withdraw call debit(int amt)function and update balance
//-Pass the other information like Acount no, name, acc type through constructor
//-call the show data method to display the values.


namespace Assignment2
{
    class Account
    {
        int acc_no;
        string cust_name;
        string acc_type;
        int amount;

        public Account(int acc_no, string cust_name, string acc_type, int amount)
        {
            this.acc_no = acc_no;
            this.cust_name = cust_name;
            this.acc_type = acc_type;
            this.amount = amount;
        }

        public void deposit(int dep)
        {
            amount += dep;

            Console.WriteLine("Amount in your bank account is : " + amount);
        }

        public void withdrawal(int wid)
        {
            if (amount < wid)
            {
                Console.WriteLine("Not Enought account in Bank , Your account balance is : ", amount);
            }
            else
            {
                amount -= wid;
                Console.WriteLine("Amount left in your bank account is : " + amount);
            }
        }

        public void show()
        {
            Console.WriteLine("Account No.: " + acc_no);
            Console.WriteLine("Name: " + cust_name);
            Console.WriteLine("Account type: " + acc_type);
            Console.WriteLine("Amount Left:  " + amount);
        }
    }


    public class Student
    {
        int Roll_No;
        string Name;
        string Class;
        int Sem;
        //string Branch;
        int[] Marks = new int[5];


        public Student()
        {
            Console.WriteLine("Enter Name of the Student: ");
            this.Name = Console.ReadLine();
            Console.WriteLine("Enter RollNo: ");
            this.Roll_No = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter Division: ");
            this.Class = Console.ReadLine();
            Console.WriteLine("Enter Semester: ");
            this.Sem = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter Marks Of Each Subject");

            for (int i = 0; i < 5; i++)
            {
                this.Marks[i] = Int32.Parse(Console.ReadLine());
            }
        }

        public void Display()
        {
            Console.WriteLine("Name : " + Name);
            Console.WriteLine("Roll Number : " + Roll_No);
            Console.WriteLine("Division : " + Class);
            Console.WriteLine("Semester : " + Sem);
            Console.Write("Result : ");
            Boolean t = false;
            int total = 0;
            int average;

            for (int i = 0; i < 5; i++)
            {
                total += Marks[i];

                if (Marks[i] < 35)
                {
                    t = true;
                }
            }

            average = total / 5;

            if (t || average < 50)
            {
                Console.WriteLine("Fail");
            }
            else
            {
                Console.WriteLine("Pass");
            }
        }
    }

    internal class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t##Assignment 2 PART 1##\n\n\t\t\tSchool Evaluation System \n\n");
            Student stu = new Student();
            stu.Display();
            Console.WriteLine("\n\n\t\t\t##Assignment 2 PART 2##\n\n\t\t\tBanking System \n\n");
            Console.WriteLine("Enter Account Number");
            int acc_no = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Account Holder name");
            string cust_name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter Account Type");
            string acc_type = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter Amount you want to add");
            int amount = Convert.ToInt32(Console.ReadLine());

            Account obj1 = new Account(acc_no, cust_name, acc_type, amount);
            Console.WriteLine("What would you Like to Perform ? ");
            Console.WriteLine("1 . Deposit");
            Console.WriteLine("2 . Withdrawal");
            Console.WriteLine("3 . Show Details");
            Console.WriteLine("4 . Exit");


            int check = 0;

            while (check == 0)
            {
                int n = Convert.ToInt32(Console.ReadLine());

                switch (n)
                {
                    case 1:
                        Console.WriteLine("How much Money You want to Deposit");
                        int am = Convert.ToInt32(Console.ReadLine());
                        obj1.deposit(am);
                        obj1.show();
                        break;
                    case 2:
                        Console.WriteLine("How much Money You want to Withdraw");
                        int amw = Convert.ToInt32(Console.ReadLine());
                        obj1.withdrawal(amw);
                        obj1.show();
                        break;
                    case 3:
                        Console.WriteLine("Details of of the Account");
                        obj1.show();
                        break;
                    case 4:
                        Console.WriteLine("Exit");
                        check = 1;
                        break;
                    default:
                        Console.WriteLine("Wrong Input");
                        break;

                }
            }
        }
    }
}


