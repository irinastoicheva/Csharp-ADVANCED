namespace _06.CompanyRoster
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        public static void Main()
        {
            int numberEmployee = int.Parse(Console.ReadLine());

            List<Employee> employees = new List<Employee>();

            for (int i = 0; i < numberEmployee; i++)
            {
                string[] employeeDefenition = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);


                string name = employeeDefenition[0];
                double salary = double.Parse(employeeDefenition[1]);
                string position = employeeDefenition[2];
                string department = employeeDefenition[3];

                if (employeeDefenition.Length == 4)
                {
                    Employee currentEmployee = new Employee(name, salary, position, department);
                    employees.Add(currentEmployee);
                }

                if (employeeDefenition.Length == 6)
                {
                    string email = employeeDefenition[4];
                    int age = int.Parse(employeeDefenition[5]);

                    Employee currentEmployee = new Employee(name, salary, position, department, email, age);
                    employees.Add(currentEmployee);
                }

                if (employeeDefenition.Length == 5)
                {
                    int n;
                    bool isNumeric = int.TryParse(employeeDefenition[4], out n);

                    if (isNumeric)
                    {
                       int age = int.Parse(employeeDefenition[4]);

                        Employee currentEmployee = new Employee(name, salary, position, department, age);
                        employees.Add(currentEmployee);
                    }
                    else
                    {
                        string email = employeeDefenition[4];
                        Employee currentEmployee = new Employee(name, salary, position, department, email);
                        employees.Add(currentEmployee);
                    }
                }
            }

            string bestDepartment = employees.GroupBy(x => x.Department).OrderByDescending(x => x.Average(s => s.Salary)).FirstOrDefault().Key;

            Console.WriteLine($"Highest Average Salary: {bestDepartment}");

            foreach (Employee employee in employees.Where(x => x.Department == bestDepartment).OrderByDescending(x => x.Salary))
            {
                Console.WriteLine($"{employee.Name} {employee.Salary:F2} {employee.Email} {employee.Age}");
            }
        }
    }
}
