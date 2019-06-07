using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Solution
{
    /*
        N and M are integers within the range [1..30,000];
        each element of arrays A, B, C is an integer within the range [1..2*M];
        A[K] ≤ B[K].
    */

    public int solution(int[] A, int[] B, int[] C)
    {
        var minNail = -1;

        return minNail;
    }
}

class Program
{
    static void Main(string[] args)
    {
        var A = new int[] { 1, 4, 5, 8 };
        var B = new int[] { 4, 5, 9, 10 };
        var C = new int[] { 4, 6, 7, 10, 2 };

        Solution sltn = new Solution();
        var si = sltn.solution(A, B, C);

        Console.WriteLine(si);

        Console.ReadKey();
    }
}


