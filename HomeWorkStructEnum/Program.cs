using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkStructEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            FirstExercise();
            Console.WriteLine("Второе задание: ");
            SecondExercise();
        }
        
        private static void FirstExercise()
        {
            var office = new Office();
            Console.WriteLine("a)");
            office.ShowAllWorkers();
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("b)");
            office.FindManagers();
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("c)");
            office.PrintAllAfterChef();
            Console.ReadLine();
            Console.Clear();
        }
        private static void SecondExercise()
        {
            var univercity = new Univercity();

            univercity.HostelForming();
            Console.ReadLine();
        }
    }
}
