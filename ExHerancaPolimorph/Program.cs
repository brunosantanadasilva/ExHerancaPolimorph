using System.Globalization;
using ExHerancaPolimorph.Entities;

namespace ExHerancaPolimorph
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());

            
            List<Employee> employees = new List<Employee>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Employee #{i} data:");
                Console.Write("Outsourced (y/n)? ");
                char outsourced = char.Parse(Console.ReadLine());
                while (outsourced != 'n' && outsourced != 'y')
                {
                    Console.Write("Enter only ( y - yes ) ou ( n - no ): ");
                    outsourced = char.Parse(Console.ReadLine());
                }

                if (outsourced == 'y')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Hours: ");
                    int hours = int.Parse(Console.ReadLine());
                    Console.Write("Value per hour: $");
                    double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Aditional charge: $");
                    double aditionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Employee employee = new OutsourcedEmployee(name, hours, valuePerHour, aditionalCharge);
                    employees.Add(employee);
                    Console.WriteLine();
                }
                else if (outsourced == 'n')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Hours: ");
                    int hours = int.Parse(Console.ReadLine());
                    Console.Write("Value per hour: $");
                    double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Employee employee = new Employee(name, hours, valuePerHour);
                    employees.Add(employee);
                    Console.WriteLine();
                }
            }

            Console.WriteLine("PAYMENTS:");
            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee);
            }

        }
    }
}