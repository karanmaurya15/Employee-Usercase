namespace Employee_Usercase
{
    internal class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Enter a Company Name: ");
             string companyname = Console.ReadLine();

             Console.WriteLine("Enter Employee Rate Per Hour: ");
             int empRatePerHour = Convert.ToInt32(Console.ReadLine());

             Console.WriteLine("Enter number of working days: ");
             int numOfWorkingDays = Convert.ToInt32(Console.ReadLine());

             Console.WriteLine("Enter max hours per month: ");
             int maxHoursPerMonth = Convert.ToInt32(Console.ReadLine());

             EmpWageBuilder empWageBuilder = new EmpWageBuilder();
             empWageBuilder.addCompanyEmpWage(companyname, numOfWorkingDays, empRatePerHour, maxHoursPerMonth);
             empWageBuilder.computeEmpWage();

            Console.WriteLine("Total Wage when queried by the companies is as follows: ");
            Console.WriteLine("Total wage for " + companyname + " is " + empWageBuilder.getTotalWage(companyname));
          

        }
    }
}
