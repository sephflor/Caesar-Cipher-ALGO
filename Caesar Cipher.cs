using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'caesarCipher' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts following parameters:
     *  1. STRING s
     *  2. INTEGER k
     */

    public static string caesarCipher(string s, int k)
    {
         char[] encrypted = new char[s.Length];
        k = k % 26; 
        for (int i = 0; i < s.Length; i++)
        {
            char c = s[i];

            if (char.IsUpper(c))
            {
                encrypted[i] = (char)((((c - 'A') + k) % 26) + 'A');
            }
            else if (char.IsLower(c))
            {
                encrypted[i] = (char)((((c - 'a') + k) % 26) + 'a');
            }
            else
            {
                encrypted[i] = c; 
            }
        }

        return new string(encrypted);
    }
}
class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        string s = Console.ReadLine();

        int k = Convert.ToInt32(Console.ReadLine().Trim());

        string result = Result.caesarCipher(s, k);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
