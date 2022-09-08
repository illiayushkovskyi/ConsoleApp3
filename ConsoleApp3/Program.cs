using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Store story = new Store("Братья Эскобар", "Одежда для своих");
            story.Show();
            Console.WriteLine(story[5]);
            story.Enter();


            Console.ReadKey();
        }
    }
}
