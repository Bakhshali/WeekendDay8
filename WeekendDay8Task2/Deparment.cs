using System;
using System.Collections.Generic;
using System.Text;

namespace WeekendDay8Task2
{
    class Deparment
    {
        public string Name { get; set; }
        public int EmployeeLimit { get; set; }

       public Employee[] employees = new Employee[0];

        public void AddEmployee(Employee employee)
        {

            if (employees.Length < EmployeeLimit)
            {
                Array.Resize(ref employees, employees.Length + 1);
                employees[employees.Length - 1] = employee;
            }
            else
            {
                throw new CapacityLimitException("Capacity limit kecdiniz!");
            }


        }

        public Deparment()
        {
            employees = new Employee[0];
        }

        public Deparment(string name,int limit)
        {
            Name = name;
            EmployeeLimit = limit;
        }

        public Employee this[int index]
        {
            get
            {
                return employees[index];
            }
            set
            {
                employees[index] = value;
            }
        }


       
    }
}

