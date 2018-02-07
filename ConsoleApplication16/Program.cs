using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication16
{
    public delegate void GreetingDelegate(string name ,int aa);
    public delegate void GreetingDelegate1(string name);
    class Program
    {

        private static void EnglishGreeting(string name)
        {
            Console.WriteLine("Morning, " + name);
        }
        private static void EnglishGreeting(string name,int aa)
        {
            Console.WriteLine("Morning, " + name+"asd"+aa);
        }

        private static void ChineseGreeting(string name)
        {
            Console.WriteLine("早上好, " + name);
        }

        //注意此方法，它接受一个GreetingDelegate类型的方法作为参数
        private static void GreetPeople(string name,int aa, GreetingDelegate MakeGreeting)
        {
            MakeGreeting(name,aa);
        }
        private static void GreetPeople(string name,  GreetingDelegate1 MakeGreeting)
        {
            MakeGreeting(name);
        }


        static void Main(string[] args)
        {
            GreetPeople("AA",1, EnglishGreeting);
            GreetPeople("阿斗", ChineseGreeting);
            Console.ReadKey();
        }
    }
}
