using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAImportantQuestion.Google
{
    public class KthSmallestElementInSortedMatrix
    {
        public void Run()
        {
            //int[][] matrix =
            //        {
            //            new int[] {1,5,9 },
            //            new int[] { 10,11,13 },
            //            new int[] { 12, 13, 15 }
            //        };

            int[][] matrix =
                    {
                        new int[] {1, 2 },
                        new int[] {1, 3 }
                    };
            int k = 2;

            Console.WriteLine(KthSmallest(matrix, k));
        }

        public int KthSmallest(int[][] matrix, int k)
        {
                        

        }
    }
}
