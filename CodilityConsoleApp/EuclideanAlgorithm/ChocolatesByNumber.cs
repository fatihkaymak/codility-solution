//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;


//class Solution
//{

//    public int solution(int N, int M)
//    {
//        int eatenChocoCount = 0;
//        int maxChocoCount = N;

//        int currentChocoIndex = 0;
//        var lEatenChoco = new List<int>(N);

//        //for (currentChocoIndex = 0; currentChocoIndex < N - 1; currentChocoIndex += M)
//        //{
//        //    eatenChocoCount++;
//        //    lEatenChoco.Add(currentChocoIndex);
//        //}
//        //currentChocoIndex = currentChocoIndex % N;

//        while (eatenChocoCount < maxChocoCount)
//        {
//            if (lEatenChoco.Contains(currentChocoIndex))
//            {
//                break;
//            }

//            eatenChocoCount++;
//            lEatenChoco.Add(currentChocoIndex);
//            currentChocoIndex = (currentChocoIndex + M) % N;
//        }

//        return eatenChocoCount;
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Solution sltn = new Solution();
//        var si = sltn.solution(10, 4);

//        Console.WriteLine(si);

//        Console.ReadKey();
//    }
//}


