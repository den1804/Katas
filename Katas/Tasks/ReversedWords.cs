using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katas.Tasks
{
    class ReversedWords
    {
        public static string ReverseWords(string str)
        {
            Stack<string> stack = new Stack<string>();
            char [] charStr = str.ToCharArray();
            string res = "";
            for (int i = 0; i < charStr.Length; i++)
            {
                
                if (charStr[i] != ' ')
                {
                    res += charStr[i];
                }
                else
                {
                    if (res != string.Empty)
                        stack.Push(res);
                    stack.Push(" ");
                    res = "";
                } 
            }
            while (stack.Count != 0)
                res += stack.Pop();
            return res;
        }
    }
}
