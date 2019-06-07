using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//class Solution
//{
//    public int solution(int A, int B)
//    {
//        int count = 0;

//        var start = (int)Math.Ceiling(Math.Sqrt(A));
//        var end = (int)Math.Floor(Math.Sqrt(B));

//        count = end - start + 1;

//        return count;
//    }
//}

class Solution
{
    public int solution(int M, int[] A)
    {
        int N = A.Length;
        int[] count = new int[M + 1];

        for (int i = 0; i <= M; i++)
        {
            count[i] = 0;
        }

        int maxOccurence = 1; //-1
        int index = -1;
        for (int i = 0; i < N; i++)
        {
            if (count[A[i]] > 0)
            {
                int tmp = (count[A[i]] =);
                
                if (tmp > maxOccurence)
                {
                    maxOccurence = tmp;
                    index = i;
                }
                //count[A[i]] = tmp + 1;
            }
            else
            {
                count[A[i]] = 1;
            }
        }
        return A[index];
    }
}

class Program
{
    static void Main(string[] args)
    {
        int M = 3;
        var A = new int[] { 1,2,3,3,1,3,1 };
        //int A = 130;

        Solution s = new Solution();
        var retVal = s.solution(M, A);

        Console.WriteLine(retVal);
        Console.ReadKey();

    }
}
