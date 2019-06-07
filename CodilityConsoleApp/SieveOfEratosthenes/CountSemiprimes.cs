//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;


//class Solution
//{
//    /*
// For example, given an integer N = 26 and arrays P, Q such that:
//    P[0] = 1    Q[0] = 26
//    P[1] = 4    Q[1] = 10
//    P[2] = 16   Q[2] = 20

//the function should return the values [10, 4, 0], as explained above.
//     */

//    //returns true or false depending if input was considered semiprime
//    private bool isSemiPrime(int c)
//    {
//        int a = 2, b = 0;
//        while (b < 3 && c != 1)
//        {
//            if ((c % a) == 0)
//            {
//                c /= a;
//                b++;
//            }
//            else
//            {
//                a++;
//            };
//        }
//        return b == 2;
//    }

//    public int[] solution(int N, int[] P, int[] Q)
//    {
//        var lReturnArray = new List<int>(P.Length);

//        for(int i=0; i<P.Length; i++)
//        {
//            int count = 0;

//            for(int k=P[i]; k<=Q[i]; k++)
//            {
//                if(isSemiPrime(k))
//                {
//                    count++;
//                }
//            }

//            lReturnArray.Add(count);
//        }

//        return lReturnArray.ToArray();
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        var P = new int[] { 1, 4, 16 };
//        var Q = new int[] { 26, 10, 20};

//        Solution sltn = new Solution();
//        var si = sltn.solution(26, P, Q);

//        Console.WriteLine(String.Join(" ", si));

//        Console.ReadKey();
//    }
//}


