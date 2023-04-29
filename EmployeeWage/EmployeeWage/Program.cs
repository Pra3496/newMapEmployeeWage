namespace EmployeeWage
{
    public class Program
    {
        static void Main(string[] args)
        {

            int empCheck = 0;

            Random random = new Random();

            Console.WriteLine("Welcome to Employee Wages Prgrams");
            Console.WriteLine("Refactor the code to write a class Method to Compute Employee Wage");

            empCheck = random.Next(0, 3);
            EmployeeWageProblem wageProblem = new EmployeeWageProblem(empCheck);
            wageProblem.computeEmpWage();
            Console.ReadKey();


        }
    }
}