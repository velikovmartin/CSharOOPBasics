using System;
using System.Collections.Generic;
using System.Linq;

namespace CompanyRoster
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Employee> employees = new List<Employee>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string name = input[0];
                decimal salary = decimal.Parse(input[1]);
                string position = input[2];
                string depaertment = input[3];

                Employee employee = new Employee(name, salary, position, depaertment);

                if (input.Length == 5)
                {
                    if (int.TryParse(input[4], out int result))
                    {
                        employee.Age = result;
                    }
                    else
                    {
                        employee.Email = input[4];
                    }
                }
                else if (input.Length == 6)
                {
                    int age = int.Parse(input[5]);
                    employee.Email = input[4];
                    employee.Age = age;
                }

                employees.Add(employee);
            }
            var topDepartment = employees.GroupBy(x => x.Department)
                .ToDictionary(x => x.Key, y => y.Select(s => s))
                .OrderByDescending(x => x.Value.Average(s => s.Salary))
                .FirstOrDefault();

            Console.WriteLine($"Highest Average Salary: {topDepartment.Key}");

            foreach (var employee in topDepartment.Value.OrderByDescending(x => x.Salary))
            {
                Console.WriteLine($"{employee.Name} {employee.Salary:f2} {employee.Email} {employee.Age}");
            }
        }
    }
}
