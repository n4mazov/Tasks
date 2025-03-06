namespace Task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your length:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your width:");
            int b = Convert.ToInt32(Console.ReadLine());
            int S = a * b;
            int P = 2 * (a + b);
            Console.WriteLine("Sahe beraberdir: " + S);
            Console.WriteLine("Perimetr beraberdir: " + P);
        }
    }
}
