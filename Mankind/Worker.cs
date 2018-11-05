using System;
using System.Collections.Generic;
using System.Text;

namespace Mankind
{
    public class Worker : Human
    {
        private decimal weekSalary;
        private double workHoursPerDay;

        public Worker(string firstName, string lastName, decimal workerSalary, double workerWorkingHours) : base(firstName, lastName)
        {
            this.WeekSalary = workerSalary;
            this.WorkHoursPerDay = workerWorkingHours;
        }

        public decimal WeekSalary
        {
            get { return weekSalary; }
            set
            {
                if (value <= 10)
                {
                    throw new ArgumentException($"Expected value mismatch! Argument: weekSalary");
                }
                weekSalary = value;
            }
        }

        public double WorkHoursPerDay
        {
            get { return workHoursPerDay; }
            set
            {
                if (value < 1 || value > 12)
                {
                    throw new ArgumentException($"Expected value mismatch! Argument: workHoursPerDay");
                }
                workHoursPerDay = value;
            }
        }

        public decimal CalculateHourSalary()
        {
            var result = this.WeekSalary / ((decimal)this.WorkHoursPerDay * 5);
            return result;
        }

        public override string ToString()
        {
            var resultBuilder = new StringBuilder();
            resultBuilder.AppendLine($"First Name: {this.FirstName}")
                .AppendLine($"Last Name: {this.LastName}")
                .AppendLine($"Week Salary: {this.WeekSalary:F2}")
                .AppendLine($"Hours per day: {this.WorkHoursPerDay:F2}")
                .AppendLine($"Salary per hour: {this.CalculateHourSalary():F2}");

            string result = resultBuilder.ToString().TrimEnd();
            return result;
        }
    }
}
