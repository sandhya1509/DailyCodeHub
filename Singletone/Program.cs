using System;
using System.Threading.Tasks;


namespace Singletone
{
    class Program
    {
        static void Main(string[] args)
        {
            Parallel.Invoke(() => Employee(),
            ()=>person());
        }

        private static void person()
        {
            Singleton person = Singleton.getInstance;
            person.printMsg("I am Person");
            Console.ReadLine();
        }

        private static void Employee()
        {
            Console.WriteLine("Hello World!");
            Singleton employee = Singleton.getInstance;
            employee.printMsg("I am employee");
        }
    }
}
