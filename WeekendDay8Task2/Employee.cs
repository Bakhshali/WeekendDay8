using System;
using System.Collections.Generic;
using System.Text;

namespace WeekendDay8Task2
{
    class Employee : IPerson
    {
        private static int _id;
        public int Id { get;}
        private int _age;
        public string Name { get; set; }
        public int Age
        {
            get => _age;
            set
            {
                if(value>0 && value < 100)
                {
                    _age = value;
                }
            }
        }
        public double Salary { get; set; }

        public Employee(string name,int age,double salary)
        {
            Id = ++_id;
            Name = name;
            Age = age;
            Salary = salary;
        }

        public string ShowInfo()
        {
            return $"Id: {Id}, Name: {Name}, Age: {Age}, Salary: {Salary}";
        }

        public override string ToString()
        {
            return ShowInfo();
        }
    }
}
