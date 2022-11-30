using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bai4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 3, 5, 6, 8, 9, 11 };
            int key = 2;
            //int kq = BinarySearch(arr, key);

            //if (kq == -1)
            //{
            //    Console.WriteLine("Khong tim thay");
            //}
            //else
            //{
            //    Console.WriteLine($"Tim thay {key} tai vi tri {kq}");
            //}

            TimX(arr,key);
            Console.ReadKey();


        }
        static int BinarySearch (int[] arr, int key)
        {
            int left = 0;
            int right = arr.Length - 1;
            int mid;

            while (left <= right)
            {
                mid = (left + right) / 2;
                Console.WriteLine(mid);
                if (arr[mid] == key)
                {
                    return mid;
                }
                else if (arr[mid] < key)
                    left = mid + 1;
                else
                {
                    right = mid - 1;
                }
            }
            return -1;
        }

        static void TimX (int[] arr, int key)
        {
            int left = 0;
            int right = arr.Length - 1;
            int mid;
            int count = 0;
            while (left <= right)
            {
                mid = (left + right) / 2;
                Console.WriteLine($"Lan {++count}: x = {key} nam trong doan [{left}...{right}] // mid = {mid}");
                if (arr[mid] == key)
                {
                    break;
                }
                else if (arr[mid] < key)
                    left = mid + 1;
                else
                {
                    right = mid - 1;
                }
            }
            Console.WriteLine($"So lan chia doi cua mang la: {count}");
        }
    }
}