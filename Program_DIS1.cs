using System;
using System.Collections.Generic;
using static System.Console;

namespace Assignment
{
    class Program_DIS1
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Self Dividing Number - Output1:");

            int a = 1, b = 22;
            printSelfDividingNumbers(a, b);

            Console.WriteLine("\n" + " PrintSeries - Output2 :");

            int n2 = 5;
            printSeries(n2);

            Console.WriteLine("\n" + "Print Triangle - Output3 :");

            int n3 = 5;            printTriangle(n3);

            Console.WriteLine("\n" + " numJewelsInStones - Output4 :");

            int[] J = new int[] { 1, 3 };            int[] S = new int[] { 1, 3, 3, 2, 2, 2, 2, 2 };            int r4 = numJewelsInStones(J, S);            Console.WriteLine(r4);

            Console.WriteLine("\n" + " LargestCommonSubArray -Output5 :");

            int[] arr1 = { 1, 2, 5, 6, 7, 8, 9 };            int[] arr2 = { 1, 2, 3, 4, 5, 7, 8, 9 };
            int[] r5 = getLargestCommonSubArray(arr1, arr2);
            foreach (int item in r5)
            {

                Console.Write(item + " ");
            }
            solvePuzzle();
        }
            // int[] arr = { 1, 2, 3 };
            // object[] testArray = new object[] { "blah", "blah2" };
            // List<int> testList = new List<int>();
            /* foreach (var x in arr)
             {
                 // Console.WriteLine("testlist: " +x);
                 testList.Add(x);

             } */
            // printSubArrays(arr, 0, 0);
            // int[] X = { 1, 2, 3, 4, 5, 6 };
            // int[] Y = { 1, 2, 5, 6, 7, 8 };

            // int m = X.Length;
            // int n = Y.Length;

            //  printLCSubStr(X, Y, m, n);


              

        

        public static bool isSelfDividing(int num, int orig)
        {
            // we want to test each whether each digit is non - zero and divides the number. For example, with 21, we want to test d != 0 && 22 % d == 0 for d = 2,1.
            // To do that, we need to iterate over each digit of the number.
            // For each number in the given range, we will test if that number is self - dividing.
            //perform the modulo operation
            if ((num % 10) == 0 || orig % (num % 10) != 0)
                return false;
            if (num < 10)
                return true;
            return isSelfDividing(num / 10, orig);
        }
        //to print self dividing numbers for a given range from x to y
        public static void printSelfDividingNumbers(int x, int y)
        {
            try
            {

                for (int i = x; i <= y; i++)
                {
                    if (isSelfDividing(i, i))
                    {
                        Console.WriteLine(i);
                    }

                }
            }
            //catch exception
            catch
            {
                WriteLine("Exception occured while computing printSelfDividingNumbers()");
            }
        }


        public static void printSeries(int n)        {            try            {                int count = 0;                for (int i = 1; i <= n; i++)                {                    for (int j = 1; j <= i; j++)                    {                        if (count <= n)                        {                            Console.Write(i + " ");                            count = count + 1;                        }                    }                }            }            catch            {                Console.WriteLine("Exception occured while computing printSeries()");            }        }
        public static void printTriangle(int n)        {            for (int i = n; i > 0; i--)            {                for (int k = 0; k < n - i; k++)                {                    Console.Write(' ');                }                for (int j = i; j <= 2 * i - 1; j++)                {                    Console.Write("* ");                }                for (int p = 0; p < i - 1; ++p)                    Console.Write("* ");                Console.Write("\n");            }        }        public static int numJewelsInStones(int[] J, int[] S)        {            int c = 0;            for (int i = 0; i < S.Length; i++)            {                for (int j = 0; j < J.Length; j++)                {                    if (J[j] == S[i])                    {                        c = c + 1;                    }                }            }            return c;        }

    public static int[] getLargestCommonSubArray(int[] X, int[] Y)
        {
            int res = 0;
            int m = X.Length;
            int n = Y.Length;
            int[,] len = new int[2, n + m];
            int Row = 0;

            int checkEnd = 0;
            //method finds the largest common contiguous subarray from two sorted arrays
            //return the last array having the maximum length
            // To store the index which contains the maximum value
            try
            {

                for (int i = 0; i <= m; i++)
                {
                    for (int j = 0; j <= n; j++)
                    {
                        if (i == 0 || j == 0)
                        {
                            len[Row, j] = 0;
                        }
                        else if (X[i - 1] == Y[j - 1])
                        {

                            len[Row, j] = len[1 - Row, j - 1] + 1;

                            if (len[Row, j] >= res)
                            {

                                res = len[Row, j];
                                checkEnd = i - 1;
                            }
                        }
                        else
                        {

                            len[Row, j] = 0;
                        }
                    }


                    Row = 1 - Row;
                }
                if (res == 0)
                    return null;

                int[] @new = new int[res];

                for (int i = checkEnd - res + 1, index = 0; index < res; i++, index++)
                {
                   @new[index] = X[i];
                   
                }
                return @new;


            }
            // Add catch statement if there is no largest common subarray found
            catch 
            {
                Console.WriteLine("Exception occured while computing getLargestCommonSubArray()");
            }
            return null;

        }


       /* static void printLCSubStr(int[] X, int[] Y, int m, int n)
        {
            // Create a table to store lengths of longest common 
            // suffixes of substrings. Note that LCSuff[i][j] 
            // contains length of longest common suffix of X[0..i-1] 
            // and Y[0..j-1]. The first row and first column entries 
            // have no logical meaning, they are used only for 
            // simplicity of program 
            int[,] LCSuff = new int[m + 1, n + 1];

            // To store length of the longest common substring 
            int len = 0;

            // To store the index of the cell which contains the 
            // maximum value. This cell's index helps in building 
            // up the longest common substring from right to left. 
            int row = 0, col = 0;

            /* Following steps build LCSuff[m+1][n+1] in bottom 
            up fashion. */
            /*for (int i = 0; i <= m; i++)
            {
                for (int j = 0; j <= n; j++)
                {
                    if (i == 0 || j == 0)
                        LCSuff[i, j] = 0;

                    else if (X[i - 1] == Y[j - 1])
                    {
                        LCSuff[i, j] = LCSuff[i - 1, j - 1] + 1;
                        if (len < LCSuff[i, j])
                        {
                            len = LCSuff[i, j];
                            row = i;
                            col = j;
                        }
                    }
                    else
                        LCSuff[i, j] = 0;
                }
            }

            // if true, then no common substring exists 
            if (len == 0)
            {
                Console.Write("No Common Substring");
                return;
            }

            // allocate space for the longest common substring 
            String resultStr = "";

            // traverse up diagonally form the (row, col) cell 
            // until LCSuff[row][col] != 0 
            while (LCSuff[row, col] != 0)
            {
                resultStr = X[row - 1] + "," + resultStr ; // or Y[col-1] 
                --len;

                // move diagonally up to previous cell 
                row--;
                col--;
                
            }

            // required longest common substring
            resultStr = resultStr.Remove(resultStr.Length - 1, 1);
           
            Console.WriteLine(resultStr);
        } */
    
        public static void solvePuzzle()
        {            try
            {

               // Console.WriteLine("Input1 :");
                var input1 = Console.ReadLine();

               // Console.WriteLine("Input2 :");
                var input2 = Console.ReadLine();




            }            catch            {                Console.WriteLine("Exception occured while computing solvePuzzle()");            }        }
    }
}
/* write your self-reflection here as a comment :
            1- Got handson experience on Visual Studio IDE.
            2- Got exposure to basics of c# and coding in general.
            3- Learned programming concepts and their fundamental application.
            4- Learned how to present and prepare a proper flow of the program.
            5- Learned how to develop and use methods throughout the program having independent functionality in c# programming.
            6- Broke the program into simpler segments for efficient calculation.
            7- Learned how to convert data types i.e. array to int.
            8- Learned how to handle corner cases. */
