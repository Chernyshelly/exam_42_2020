﻿using System;
using System.Collections.Generic;

namespace exApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public static List<int[]> GetZeroSumms(List<int> list)
        {
            List<int> vvod = list;
            vvod.Sort();
            List<int[]> result = new List<int[]>();
            int i = 0;
            int j = vvod.Count - 1;
            while (j > i)
            {
                while (Math.Abs(vvod[j]) > Math.Abs(vvod[i]))
                {
                    j--;
                }

                if (vvod[i] == 0 - vvod[j])
                {
                    result.Add(new int[2] { vvod[i], vvod[j] });
                }
                i++;
            }

            return result;
        }
    }

}
