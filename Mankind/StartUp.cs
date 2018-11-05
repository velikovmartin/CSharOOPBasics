using System;

namespace Mankind
{
    class StartUp
    {
        static void Main(string[] args)
        {
            try
            {
                string[] studentArgs = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string studentFirstName = studentArgs[0];
                string studentSecondName = studentArgs[1];
                string studentFacultyNumber = (studentArgs[2]);
                Student student = new Student(studentFirstName, studentSecondName, studentFacultyNumber);
                string[] workerArgs = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string workerFirstName = workerArgs[0];
                string workerLastName = workerArgs[1];
                decimal workerSalary = decimal.Parse(workerArgs[2]);
                double workerWorkingHours = double.Parse(workerArgs[3]);
                Worker worker = new Worker(workerFirstName, workerLastName, workerSalary, workerWorkingHours);

                Console.WriteLine(student);
                Console.WriteLine();
                Console.WriteLine(worker);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
