using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//class Solution
//{
//    public int solution(String S)
//    {
//        //{[()()]}
//        int left1 = 0; //{
//        int left2 = 0; //[
//        int left3 = 0; //(

//        foreach (char ch in S)
//        {
//            switch (ch)
//            {
//                case '{':
//                    left1++;
//                    break;
//                case '}':
//                    if (left1 == 0)
//                        return 0;
//                    left1--;
//                    break;
//                case '[':
//                    left2++;
//                    break;
//                case ']':
//                    if (left2 == 0)
//                        return 0;
//                    left2--;
//                    break;
//                case '(':
//                    left3++;
//                    break;
//                case ')':
//                    if (left3 == 0)
//                        return 0;
//                    left3--;
//                    break;
//            }
//        }

//        return left1 == 0 && left2 == 0 && left3 == 0 ? 1: 0;
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        string s = "{[()()]}";
//        //string s = "([)()]";

//        Solution sltn = new Solution();
//        var si = sltn.solution(s);

//        Console.WriteLine(si);

//        Console.ReadKey();
//    }
//}

#region PassingCars
/*

    public int solution(int[] A)
    {
        int pairCounts = 0;

        var dicPassingCars = new Dictionary<int, int>();
        List<int> lA = A.ToList();

        var totalOneCount = (from i in lA where i == 1 select i).Count();
        var leftOneCount = totalOneCount;

        for(int i=0; i<lA.Count; i++)
        {
            if(lA[i] == 0)
            {
                pairCounts += leftOneCount;
            }
            else //1
            {
                leftOneCount--;
            }
        }

        if(pairCounts > 1000000000)
        {
            pairCounts = -1;
        }

        return pairCounts;
    }
 
*/
#endregion

#region MaxProductOfThree
/*
    public int solution(int[] A)
    {
        var lA = A.ToList();

        int? maxProduct = null;
        int p = 0, q = 1, r = 2;
        int currProduct = 0;

        for (p = 0; p < lA.Count - 2; p++)
        {
            for (q = p + 1; q < lA.Count - 1; q++)
            {
                for (r = q + 1; r < lA.Count; r++)
                {
                    currProduct = lA[p] * lA[q] * lA[r];

                    if ((currProduct > maxProduct) || (maxProduct == null))
                    {
                        maxProduct = currProduct;
                    }
                }
            }
        }

        return maxProduct ?? 0;
    } 
     
     */
#endregion

#region triangle
/*
    public int solution(int[] A)
    {
        var lP = A.ToList();

        var lQ = A.ToList();

        var lR = A.ToList();

        int returnVal = 0;

        //for (int p = 0; p <= A.Length - 3; p++)
        //{
        //    for (int q = p + 1; q <= A.Length - 2; q++)
        //    {
        //        for (int r = q + 1; r <= A.Length - 1; r++)
        //        {
        //            long totalPQ = ((long)A[p] + (long)A[q]);
        //            bool b1 = totalPQ > A[r];

        //            long totalQR = ((long)A[q] + (long)A[r]);
        //            bool b2 = totalQR > A[p];

        //            long totalRP = ((long)A[r] + (long)A[p]);
        //            bool b3 = totalRP > A[q];

        //            if (b1 && b2 && b3)
        //            {
        //                returnVal = 1;
        //            }
        //        }
        //    }
        //}

        int indexP = 0;
        int indexQ = 0;
        int indexR = 0; 

        lP.ForEach(p => 
        {
            if (indexP <= A.Length - 3)
            {
                lQ.ForEach(q =>
                {
                    if ((indexQ >= indexP+1) && (indexQ <= A.Length - 2))
                    {
                        lQ.ForEach(r =>
                        {
                            if (indexR >= indexQ+1)
                            {
                                long totalPQ = ((long)p + (long)q);
                                bool b1 = totalPQ > r;

                                long totalQR = ((long)q + (long)r);
                                bool b2 = totalQR > p;

                                long totalRP = ((long)r + (long)p);
                                bool b3 = totalRP > q;

                                if (b1 && b2 && b3)
                                {
                                    returnVal = 1;
                                }
                            }

                            indexR++;
                        });
                        indexR = 0;
                    }

                    indexQ++;
                });
                indexQ = 0;
            }

            indexP++;
        });

        return returnVal;
    } 
     
 */
#endregion

//public int solution(int[] A, int[] B)
//{
//    int countAlive = 0;
//    var lFish = new List<Fish>();

//    for (int i = 0; i < A.Length; i++)
//    {
//        lFish.Add(new Fish { index = i, size = A[i], direction = B[i] });
//    }

//    var queryForDownstream = from e in lFish where e.direction == 1 select e;

//    foreach (var f in queryForDownstream)
//    {
//        //if (f.direction == 0)
//        //{

//        //}
//        //else //direction 1
//        //{
//        var rightList = from e in lFish
//                        where (e.index > f.index) && (e.direction == 0)
//                        //orderby f.index
//                        select e;

//        foreach (var rightF in rightList)
//        {
//            if (f.size > rightF.size)
//            {
//                lFish[rightF.index].isAlive = false;
//            }
//            else
//            {
//                f.isAlive = false;
//                break;
//            }
//        }
//        //}
//    }

//    countAlive = (from f in lFish
//                  where f.isAlive == true
//                  select f).Count();

//    return countAlive;
//}