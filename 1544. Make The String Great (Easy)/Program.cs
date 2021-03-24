using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1544._Make_The_String_Great__Easy_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(makeGood("leEeetcode"));
        }

        public static string makeGood(string s)
        {
            Stack<char> stack = new Stack<char>();
            StringBuilder res = new StringBuilder();

            foreach (var c in s.ToCharArray())
            {
                //因為英文大小寫字母ASCII CODE 差32
                if (stack.Count !=0 && Math.Abs(stack.Peek() - c) == 32)
                    stack.Pop();
                else
                    stack.Push(c);
            }

            while (stack.Count !=0) 
                res.Append(stack.Pop());

            return new string (res.ToString().Reverse().ToArray());

        }
    }
}
