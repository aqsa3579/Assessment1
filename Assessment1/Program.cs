using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment1
{
    class DeciToHexadecimal
    {
        static string decToHexa(int n)
        {
            char[] hexaDeciNum = new char[100];

            // loop for hexadecimal
            int i = 0;

            while (n != 0)
            {
                // temporary variable to store remainder 
                int temp = 0;
                temp = n % 16;


                if (temp < 10)
                {
                    hexaDeciNum[i] = (char)(temp + 48);
                    i++;
                }
                else
                {
                    hexaDeciNum[i] = (char)(temp + 87);
                    i++;
                }

                n = n / 16;
            }

            string ans = " ";

            // Printing hexadecimal number 
            for (int j = i - 1;
                    j >= 0; j--)
            {
                ans += hexaDeciNum[j];
            }

            return ans;
        }
    }





    //Question 2:
    //public class series
    //{
    //    public static void Main()
    //    {
    //        double x, sum, sqr, p, term;
    //        int i, n;
    //        Console.Write("Calculate the sum of the series [ x - x^3 + x^5 - x^7 + x^9 - .....]:\n");

    //        Console.Write("Input the value of x :");
    //        x = Convert.ToInt32(Console.ReadLine());
    //        Console.Write("Input number of terms : ");
    //        n = Convert.ToInt32(Console.ReadLine());
    //        term = 1;
    //        sum = 0;
    //        for (i = 1, p = 1; i < n + 1; i++)
    //        {
    //            sqr = Math.Pow(x, p);
    //            sum = sum + sqr * term;
    //            term = term * (-1);
    //            p = p + 2;
    //        }
    //        Console.Write("\nThe value of x = {0}\nNumber of terms = {1}\nThe sum = {2}\n", x, n, sum);
    //        Console.ReadLine();
    //    }
    //}


}



