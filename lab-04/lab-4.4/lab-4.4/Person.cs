using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4._4
{
    abstract class Person
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }

        public Person(string name, string phoneNumber, string emailAddress)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            EmailAddress = emailAddress;
        }

        public override string ToString()
        {
            return $"{GetType().Name}: {Name}, Email: {EmailAddress}";
        }
    }

    class Student : Person
    {
        public string Program { get; set; }

        public Student(string name, string phoneNumber, string emailAddress, string program)
            : base(name, phoneNumber, emailAddress)
        {
            Program = program;
        }
    }

    abstract class Employee : Person
    {
        public string Department { get; set; }
        public double Salary { get; set; }
        public DateTime DateHired { get; set; }

        public Employee(string name, string phoneNumber, string emailAddress, string department, double salary, DateTime dateHired)
            : base(name, phoneNumber, emailAddress)
        {
            Department = department;
            Salary = salary;
            DateHired = dateHired;
        }

        public abstract double CalculateBonus();
        public abstract int CalculateVacation();
    }

    class Faculty : Employee
    {
        public string OfficeHours { get; set; }
        public string Rank { get; set; }

        public Faculty(string name, string phoneNumber, string emailAddress, string department, double salary, DateTime dateHired, string officeHours, string rank)
            : base(name, phoneNumber, emailAddress, department, salary, dateHired)
        {
            OfficeHours = officeHours;
            Rank = rank;
        }

        public override double CalculateBonus()
        {
            return 1000 + 0.05 * Salary;
        }

        public override int CalculateVacation()
        {
            int yearsEmployed = (DateTime.Now - DateHired).Days / 365;
            if (yearsEmployed > 3)
            {
                return Rank == "Senior Lecturer" ? 6 : 5;
            }
            return 4;
        }
    }

    class Staff : Employee
    {
        public string Title { get; set; }

        public Staff(string name, string phoneNumber, string emailAddress, string department, double salary, DateTime dateHired, string title)
            : base(name, phoneNumber, emailAddress, department, salary, dateHired)
        {
            Title = title;
        }

        public override double CalculateBonus()
        {
            return 0.06 * Salary;
        }

        public override int CalculateVacation()
        {
            int yearsEmployed = (DateTime.Now - DateHired).Days / 365;
            return yearsEmployed >= 5 ? 4 : 3;
        }
    }
}
