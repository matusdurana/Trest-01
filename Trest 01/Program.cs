using System;

namespace Trest_01
{
    class Program
    {
        static void Main(string[] args)
        {
            var Family_members = new Family_members();


            while (13 == 13)
            {
                Family_members.Update();
                Console.WriteLine("Kerú setru sceš nakrmic?");
                string input = Console.ReadLine();
                Family_members.Feed(input, 3);

                Family_members.Update2();
                Console.WriteLine("Ktorá má isť spinkať?");
                string input2 = Console.ReadLine();
                Family_members.Sleep(input2, 20);
            }
        }
    }
}
