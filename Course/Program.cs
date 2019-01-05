using System;
using System.Globalization;
using Course.Entities;
using Course.Entities.Enums;


namespace Course {
    class Program {
        static void Main(string[] args) {
            Console.Write("Enter department's name: ");
            string deptName = Console.ReadLine();
            Department dp = new Department(deptName);

            Console.WriteLine("Enter Worker data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Level (Junior/MidLevel/Senior): ");
            string level = Console.ReadLine();
            WorkerLevel wl = Enum.Parse<WorkerLevel>(level);

            Console.Write("Base Salary: ");
            double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Worker worker = new Worker(name, wl, salary, dp);

            Console.Write("How many contracts to this worked? ");
            int contracts = int.Parse(Console.ReadLine());

            for (int i=0; i<contracts; i++) {
                Console.Write("Date: ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per Hour: ");
                double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration (hours): ");
                int duration = int.Parse(Console.ReadLine());

                Contract con = new Contract(date, value, duration);
                worker.Contract.Add(con);

            }

            Console.WriteLine("Enter month and year to calculate income: ");
            Console.Write("Month: "); int month = int.Parse(Console.ReadLine());
            Console.Write("Year: "); int year = int.Parse(Console.ReadLine());

            double income = worker.Income(year, month);

            Console.WriteLine();
            Console.WriteLine("Name: "+worker.Name);
            Console.WriteLine("Department: " + worker.Department.Name);
            Console.WriteLine("Income for "+month+"/"+year+": "+income);
            
        }
    }
}
