using System.Security.Principal;

namespace Part_11___Making_Your_Own_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine(string.Join(",",MyMethod.GetRandomList(1,10,10)));
        }
    }
}
