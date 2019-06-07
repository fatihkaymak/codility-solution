using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//class Solution
//{
//    /*
//Write a function,

//    class Solution { public int solution(int[] A); }

//that, given an array A consisting of N integers containing daily prices of a stock share for a period of N consecutive days, returns the maximum possible profit from one transaction during this period. The function should return 0 if it was impossible to gain any profit.

//For example, given array A consisting of six elements such that:
//  A[0] = 23171
//  A[1] = 21011
//  A[2] = 21123
//  A[3] = 21366
//  A[4] = 21013
//  A[5] = 21367

//the function should return 356, as explained above.

//Write an efficient algorithm for the following assumptions:

//        N is an integer within the range [0..400,000];
//        each element of array A is an integer within the range [0..200,000].
//     */

//    public int solution(int[] A)
//    {
//        var maxProfit = 0;

//        if (A == null || A.Length == 0)
//        {
//            return 0;
//        }

//        var lA = A.ToList();

//        var q = new Queue<int>();
//        lA.ForEach(i =>
//        {
//            q.Enqueue(i);
//        });

//        while (q.Count > 0)
//        {
//            var curr = q.Dequeue();

//            foreach (var qi in q)
//            {
//                var currProfit = qi - curr;
//                if (currProfit > maxProfit)
//                {
//                    maxProfit = currProfit;
//                }
//            }
//        }

//        return maxProfit;
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        var A = new int[] { 23171, 21011, 21123, 21366, 21013, 21367 };

//        Solution sltn = new Solution();
//        var si = sltn.solution(A);

//        Console.WriteLine(si);

//        Console.ReadKey();
//    }
//}

