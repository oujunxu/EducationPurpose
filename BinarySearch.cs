using System;

namespace BinarySearch
{
    public class BinarySearch
    {
        // search-method that returns the index of the number you are searching for, however if it doesn't exists then -1 will be returned.
        public static int search_num(int[] arr, int left, int right, int find)
        {
            if(left <= right)
            {
                int mid = left + (right-left) / 2;
                if (arr[mid] == find)
                {
                    return mid;
                }
                
                if(arr[mid] > find)
                {
                  return search_num(arr, left, mid - 1, find);
                }

                else
                {
                   return search_num(arr, mid + 1, right, find);
                }
            }

            return -1;
        }
        public static void Main(string[] args)
        {
            int[] arr = {3, 5, 6, 7, 9, 11, 15};

            int find = int.Parse(Console.ReadLine()); // the number you are searching for.

            Console.WriteLine("Number found at index:");
            Console.WriteLine(search_num(arr, 0, arr.Length-1, find));

            
        }
    }
}
