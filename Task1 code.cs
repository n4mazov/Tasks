using System.Collections.Specialized;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        #region Task1
        {
            Console.WriteLine("Enter your mark:");
            int mark = Convert.ToInt32(Console.ReadLine());
            if (mark > 90)
            {
                Console.WriteLine("Your mark is: A");
            }
            else if (mark > 80)
            {
                Console.WriteLine("Your mark is: B");
            }
            else if (mark > 70)
            {
                Console.WriteLine("Your mark is: C");
            }
            else if (mark > 61)
            {
                Console.WriteLine("Your mark is: D");
            }
            else if (mark < 61)
            {
                Console.WriteLine("Siz kesilmisiniz");
            }
            
        }
    }
}
#endregion
