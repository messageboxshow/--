using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 接口练习
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = new int[] {1,2,3,4,5 };                       //整形数组他的基类是Array
            ArrayList nums2 = new ArrayList { 1,2,3,4,5};           //Array与ArrayList都实现了IEnumerable接口
            Console.WriteLine(Sum(nums1));
            Console.WriteLine(Sum(nums2));
            Console.WriteLine(Avg(nums1));
            Console.WriteLine(Avg(nums2));
        }

        static int Sum(IEnumerable nums)
        {
            int Sum = 0;
            foreach (var n in nums)
            {
                Sum += (int )n;
            }
            return Sum;
        }

        static double Avg(IEnumerable nums)
        {
            int Sum = 0;double count = 0;
            foreach (var n in nums)
            {
                Sum +=(int ) n;
                count++;

            }
            return Sum / count;


        }

       
    }
}
