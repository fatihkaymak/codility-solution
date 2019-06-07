using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//class Solution
//{
//    bool isValidPair(char left, char right)
//    {
//        if ((left == '{' && right == '}')
//            || (left == '[' && right == ']')
//            || (left == '(' && right == ')'))
//        {
//            return true;
//        }
//        else
//        {
//            return false;
//        }
//    }

//    public int solution(String S)
//    {
//        Stack<char> stck = new Stack<char>();
//        foreach(var ch in S)
//        {
//            if ("{[(".Contains(ch))
//            {
//                stck.Push(ch);
//            }
//            else
//            {
//                if (stck.Count == 0)
//                {
//                    return 0;
//                }

//                var lastFromStack = stck.Pop();

//                if (!isValidPair(lastFromStack, ch))
//                {
//                    return 0;
//                }
//            }
//        }

//        if (stck.Count > 0)
//        {
//            return 0;
//        }

//        return 1;
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        //string s = "{[()()]}";
//        string s = "([)()]";

//        Solution sltn = new Solution();
//        var si = sltn.solution(s);

//        Console.WriteLine(si);

//        Console.ReadKey();
//    }
//}
