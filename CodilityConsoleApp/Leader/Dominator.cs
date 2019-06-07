using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//class Solution
//{

//    public int solution(int[] A)
//    {
//        if(A == null || A.Length == 0)
//        {
//            return -1;
//        }

//        var lA = A.ToList();

//        int domIndex = -1;

//        var groupQuery = from i in A
//                         group i by i into grp
//                         orderby grp.Count()
//                         select new { key = grp.Key, cnt = grp.Count() };

//        var last = groupQuery.Last();

//        if (last.cnt > (A.Length/2))
//        {
//            domIndex = lA.IndexOf(last.key);
//        }

//        return domIndex;
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        var A = new int[] { 3, 4, 3, 2, 3, -1, 3, 3 };

//        Solution sltn = new Solution();
//        var si = sltn.solution(A);

//        Console.WriteLine(si);

//        Console.ReadKey();
//    }
//}

