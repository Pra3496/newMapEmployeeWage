namespace EmployeeWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Employee Wage Problems");

            Random random= new Random();
            
            int emp = random.Next(0,2);


            EmployeeWageProblem ewp = new EmployeeWageProblem(emp);

            ewp.Attendencs();



        }
    }
}