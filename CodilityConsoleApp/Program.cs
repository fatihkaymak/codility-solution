using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityConsoleApp
{
    class Program
    {
        /*
        N is an integer within the range [0..100,000];
        the elements of A are all distinct;
        each element of array A is an integer within the range [1..(N + 1)].
         */

        class Solution
        {
            public int solution(int[] A)
            {
                if (A == null || A.Length == 0 || A.Length == 1 || A.Length > 100000)
                {
                    return 0;
                }

                var query = from i in A orderby i select i;

                int returnVal = 0;

                int currInt = query.First();
                if (currInt == 2)
                {
                    returnVal = 1;
                }
                else
                {
                    foreach (var i in query)
                    {
                        if (currInt == i)
                            continue;

                        else if ((i - currInt) > 1)
                        {
                            returnVal = currInt + 1;
                            break;
                        }

                        currInt = i;
                    }
                }

                return returnVal;
            }
        }

        //static void Main(string[] args)
        //{
        //    var A = new int[] { 2, 3, 1, 5 };

        //    Solution s = new Solution();
        //    var si = s.solution(A);

        //    Console.WriteLine(si);

        //    Console.ReadKey();
        //}
    }
}
