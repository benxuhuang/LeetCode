using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int?[] vals = { 1, 2, 3, null, 4, 5 };

            int i = 0;

            while (i < vals.Length)
            {
                Console.WriteLine(vals[i].GetType());
                i++;
            }

            Console.ReadLine();
        }

        class User
        {
            public User() { }

            public User(string name, string occupation)
            {
                this.name = name;
                this.occupation = occupation;
            }

            public string name { get; set; }
            public string occupation { get; set; }

            public override string ToString() => $"{name} {occupation}";
        }


    }
}
