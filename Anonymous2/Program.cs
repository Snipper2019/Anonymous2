using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous2
{

    public delegate string GreetingDel(string name);
    class Program
    {


        static void Main(string[] args)
        {
            GreetingDel gt = delegate(string name)
            {
                return "hello" + name + "how are you";
            };

            string str = gt.Invoke("Tendeg");
            Console.WriteLine(str);
            Console.ReadLine();

        }
    }
}
