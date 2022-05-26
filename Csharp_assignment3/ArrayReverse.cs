using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_assignment3
{
    public class ArrayReverse
    {
        private int[] numberArr;
        public ArrayReverse(int l)
        {
            numberArr = new int[l];
            for (int i = 0; i < l; i++)
            {
                numberArr[i] = i+1;
            }
        }
        public int[] GenerateNumbers()
        {
            return numberArr;
        }


        public void Reverse(int[] arr)
        {
            int l=arr.Length;
            int st = 0, nd = l - 1;
            while (st < nd)
            {
                int temp = arr[nd];
                arr[nd] = arr[st];
                arr[st] = temp;
                st++;
                nd--;
            }
        }

        public void PrintNumber(int[] arr)
        {
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
        }
    }


    public static class Fibonacci
    {
        public static int GenerateFibo(int n)
        {
            if(n==1 || n==2)
            {
                return 1;
            }
            int res=GenerateFibo(n-1)+GenerateFibo(n-2);
            return res;
        }
    }





}
   
