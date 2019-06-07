//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;


//class Solution
//{
//    /*


//A non-empty array A consisting of N integers is given. A pair of integers (P, Q), such that 0 ≤ P ≤ Q < N, is called a slice of array A. The sum of a slice (P, Q) is the total of A[P] + A[P+1] + ... + A[Q].

//Write a function:

//    class Solution { public int solution(int[] A); }

//that, given an array A consisting of N integers, returns the maximum sum of any slice of A.

//For example, given array A such that:
//A[0] = 3  A[1] = 2  A[2] = -6
//A[3] = 4  A[4] = 0

//the function should return 5 because:

//        (3, 4) is a slice of A that has sum 4,
//        (2, 2) is a slice of A that has sum −6,
//        (0, 1) is a slice of A that has sum 5,
//        no other slice of A has sum greater than (0, 1).

//Write an efficient algorithm for the following assumptions:

//        N is an integer within the range [1..1,000,000];
//        each element of array A is an integer within the range [−1,000,000..1,000,000];
//        the result will be an integer within the range [−2,147,483,648..2,147,483,647].

//        //def solution(A):
//        //max_ending = max_slice = -1000000
//        //for a in A:
//        //    max_ending = max(a, max_ending + a)
//        //    max_slice = max(max_slice, max_ending)

//        //return max_slice
//     */

//    public int solution(int[] A)
//    {
//        int? maxSliceSum = null;
//        var lA = A.ToList();

//        if (A == null || A.Length == 0)
//        {
//            return 0;
//        }

//        var q = new Queue<int>();
//        lA.ForEach(i => {
//            q.Enqueue(i);
//        });

//        while(q.Count > 0)
//        {
//            var curr = q.Dequeue();
//            var currSliceSum = curr;

//            if (maxSliceSum == null)
//            {
//                maxSliceSum = currSliceSum;
//            }

//            if (currSliceSum > maxSliceSum)
//            {
//                maxSliceSum = currSliceSum;
//            }

//            foreach (var qi in q)
//            {
//                currSliceSum += qi;
//                if (currSliceSum > maxSliceSum)
//                {
//                    maxSliceSum = currSliceSum;
//                }
//            }
//        }

//        return maxSliceSum ?? 0;
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        //var A = new int[] { 3, 2, -6, 4, 0 };
//        //var A = new int[] { -2, 1 };
//        var A = new int[] { -2, 1, -2 };

//        Solution sltn = new Solution();
//        var si = sltn.solution(A);

//        Console.WriteLine(si);

//        Console.ReadKey();
//    }
//}

