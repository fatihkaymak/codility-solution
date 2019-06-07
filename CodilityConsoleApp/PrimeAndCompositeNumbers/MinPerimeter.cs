//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;


//class Solution
//{

//    public int solution(int N)
//    {
//        int? minPerimeter = null;

//        int x = (int)Math.Sqrt(N);

//        for (int a = 1; a <= x; a++)
//        {
//            for (int b= x; b <= N; b++)
//            {
//                if (a*b == N)
//                {
//                    int currPerimeter = 2 * (a + b);
//                    if (minPerimeter == null)
//                    {
//                        minPerimeter = currPerimeter;
//                    }
//                    else if (currPerimeter < minPerimeter)
//                    {
//                        minPerimeter = currPerimeter;
//                    }
//                }
//            }
//        }

//        return minPerimeter ?? 0;
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Solution sltn = new Solution();
//        var si = sltn.solution(1);

//        Console.WriteLine(si);

//        Console.ReadKey();
//    }
//}

