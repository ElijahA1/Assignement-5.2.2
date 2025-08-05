
namespace Assignement_5._2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            printNatNums(10, 1);
        }
        static void printNatNums(int n, int i) 
        {


            if (i <= n)
            {
                Console.Write($"{i} ");
                printNatNums(n, i += 1);
            }
        }
    }
}
