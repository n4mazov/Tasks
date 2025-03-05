namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your salary:");
            int salary = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your kredit:");
            int kredit = Convert.ToInt32(Console.ReadLine());
            int yearSalary = salary * 12;
            if (kredit > yearSalary * 0.6)
            {
                Console.WriteLine("Kredit goture bilersiniz");
            }
            else
            {
                Console.WriteLine("Kredit goture bilmesiniz");
            }
        }
    }
}
