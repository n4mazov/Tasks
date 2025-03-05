namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your number:");
            int num = Convert.ToInt32(Console.ReadLine());
            int Dozen = num / 10;
            int Unit = num % 10;
            if(Dozen > Unit)
            {
                Console.WriteLine("Onlug boyukdur");
            }
            else
            {
                Console.WriteLine("Teklik boyukdur");
            }
        }
    }
}
