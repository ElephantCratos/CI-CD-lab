global using NUnit.Framework;
using System;
using System.Reflection.Metadata.Ecma335;
using System.Collections.Generic;

    public static class ExperimentalRat
    {
       public static int[] Merge(int[] targetArray, int[] array1, int[] array2)
        {
            int arr1MinIndex = 0;
            int arr2MinIndex = 0;
            int targetMinIndex = 0;

            while (arr1MinIndex < array1.Length && arr2MinIndex < array2.Length)
            {
                if (array1[arr1MinIndex] <= array2[arr2MinIndex])
                {
                    targetArray[targetMinIndex] = array1[arr1MinIndex];
                    arr1MinIndex++;
                }
                else
                {
                    targetArray[targetMinIndex] = array2[arr2MinIndex];
                    arr2MinIndex++;
                }
                targetMinIndex++;
            }

            while (arr1MinIndex < array1.Length)
            {
                targetArray[targetMinIndex] = array1[arr1MinIndex];
                arr1MinIndex++;
                targetMinIndex++;
            }

            while (arr2MinIndex < array2.Length)
            {
                targetArray[targetMinIndex] = array2[arr2MinIndex];
                arr2MinIndex++;
                targetMinIndex++;
            }
            return targetArray;
        }

       public static int[] MergeSort(int[] array)
        {
            if (array.Length < 2)
            { return array; }

            int mid = array.Length / 2;
            int[] left = new int[mid];
            int[] right = new int[array.Length - mid];

            for (int i = 0; i < mid; i++)
            {
                left[i] = array[i];
            }

            for (int i = mid; i < array.Length; i++)
            {
                right[i - mid] = array[i];
            }

            MergeSort(left);
            MergeSort(right);
            return Merge(array, left, right);
        }

        public static bool IsPalindrome(string probablyPalindrome)
        {
            int j = probablyPalindrome.Length - 1;
            int i = 0;

            while (i < j)
            {
                if (probablyPalindrome[i] != probablyPalindrome[j])
                    return false;

                i++;
                j--;
            }

            return true;
        }

       public static int GetFactorial(int position)
        {
            if (position < 0)
                return 0;

            int factorial = 1;

            for (int i = 2; i <= position; i++)
                factorial *= i;

            return factorial;
        }

       public static int GetFibonachi(int position)
        {
            if (position <= 0)
                return 0;

            if (position == 1 || position == 2)
                return 1;

            int fib1 = 1;
            int fib2 = 1;
            int fib_sum = 0;

            for (int i = 3; i <= position; i++)
            {
                fib_sum = fib1 + fib2;
                fib1 = fib2;
                fib2 = fib_sum;
            }
            return fib_sum;
        }

      public  static bool SubstringSearch(string str, string substr)
        {
            if (string.IsNullOrEmpty(str) || string.IsNullOrEmpty(substr) || substr.Length > str.Length)
                return false;

            for (int i = 0; i <= str.Length - substr.Length; i++)
            {
                if (str[i] == substr[0])
                {
                    bool found = true;
                    for (int j = 1; j < substr.Length; j++)
                    {
                        if (str[i + j] != substr[j])
                        {
                            found = false;
                            break;
                        }
                    }
                    if (found)
                        return true;
                }
            }
            return false;
        }

      public  static bool IsPrime(long number)
        {
            if (number <= 1)
                return false;

            for (long i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }

      public  static int GetReversedNumber(int number)
        {
            long result = 0;

            while (number != 0)
            {
                result = result * 10 + number % 10;
                number /= 10;
            }

            if (result > Int32.MaxValue || result < Int32.MinValue)
                return 0;

            return Convert.ToInt32(result);
        }

       public static string ConvertToRoman(int number)
        {
            if (number <= 0)
                return "Incorrect Data";

            var RomanNumbers = new Dictionary<int, string>()
           {
               {1000, "M"},
               {900, "CM"},
               {500, "D"},
               {400, "CD"},
               {100, "C"},
               {90, "XC"},
               {50, "L"},
               {40, "XL"},
               {10, "X"},
               {9, "IX"},
               {5, "V"},
               {4, "IV"},
               {1, "I"}
          };
            string roman = "";

            foreach (var item in RomanNumbers)
            {
                while (number >= item.Key)
                {
                    roman += item.Value;
                    number -= item.Key;
                }
            }
            return roman;
        }

   
}
