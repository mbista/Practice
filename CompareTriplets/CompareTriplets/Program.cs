﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
    //compare triplets
    static int[] solve(int a0, int a1, int a2, int b0, int b1, int b2)
    {
        // Complete this function

        int[] A = { a0, a1, a2 };
        int[] B = { b0, b1, b2 };

        int[] result = new int[2];

        if (a0 > b0)
        {
            result[0] = result[0] + 1;
        }
        if (a2 < b2)
        {
            result[1] = result[1] + 1;
        }
        if (a1 == b1)
        {
            result[0] = result[0] + 0;
            result[1] = result[1] + 0;
        }
        return result;
    }
    public bool isValidScore(int[] a)
    {
        bool ye = false;
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] > 0 && a[i] < 101)
                ye = true;
        }
        return ye;
    }

    static void Main(String[] args)
    {
        string[] tokens_a0 = Console.ReadLine().Split(' ');
        int a0 = Convert.ToInt32(tokens_a0[0]);
        int a1 = Convert.ToInt32(tokens_a0[1]);
        int a2 = Convert.ToInt32(tokens_a0[2]);
        string[] tokens_b0 = Console.ReadLine().Split(' ');
        int b0 = Convert.ToInt32(tokens_b0[0]);
        int b1 = Convert.ToInt32(tokens_b0[1]);
        int b2 = Convert.ToInt32(tokens_b0[2]);
        int[] result = solve(a0, a1, a2, b0, b1, b2);
        Console.WriteLine(String.Join(" ", result));
    }
}
