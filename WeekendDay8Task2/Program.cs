using System;

namespace WeekendDay8Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Bakhshali",20,2000.50);
            Employee employee1 = new Employee("Tural",21,800.20);
            Employee employee2 = new Employee("Islam",19,1500.90);
            Employee employee3 = new Employee("Malik", 22, 2200.10);

            Deparment deparment = new Deparment("AzTu",4);

            deparment.AddEmployee(employee);
            deparment.AddEmployee(employee1);
            deparment.AddEmployee(employee2);
            deparment.AddEmployee(employee3);

            foreach (var item in deparment.employees)
            {
                Console.WriteLine(item.ShowInfo());
            }

            Console.WriteLine("\nFoundById");
            Console.WriteLine(deparment[2]);
        }
    }
}
