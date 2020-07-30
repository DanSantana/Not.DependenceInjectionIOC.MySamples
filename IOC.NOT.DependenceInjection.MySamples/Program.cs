using System;

namespace IOC.NOT.DependenceInjection.MySamples
{
    class Program
    {
        static void Main(string[] args)
        {
            var message = new MessageMAnager();
            string helloMessage = message.HelloMessage("Khael");
            Console.WriteLine(helloMessage);
            Console.ReadKey();
        }
    }
}
