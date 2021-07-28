using System;

namespace SearchNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 4, 6, 7, 2, 3 ,9};
            int key = 6;
            int n = arr.Length;
            SearchNumber(arr, 0, n - 1,key);
        }

        public static int SearchNumber(int[] arr,int min,int max,int key)
        {
            int mid = (min + max) / 2;
            Array.Sort(arr);
            if (key == arr[mid])
            {
                return mid;
            }
            if(arr[min] <= arr[mid])
            {
                if(key >= arr[min] && key <= arr[mid])
                {
                    return SearchNumber(arr,0,mid-1,key);
                }
                return SearchNumber(arr, mid + 1, max, key);
            }
            
            if (key >= arr[min] && key <= arr[mid])
            {
                return SearchNumber(arr, mid+1, max, key);
            }
            return SearchNumber(arr, 1, mid-1, key);
            
        }
    }
}
