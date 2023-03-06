﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAlgorithms.SortAlgorithms
{
    public class InsertionSort
    {
        public int[] InsertionSortArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                var key = array[i];
                var flag = 0;
                for (int j = i - 1; j >= 0 && flag != 1;)
                {
                    if (key < array[j])
                    {
                        array[j + 1] = array[j];
                        j--;
                        array[j + 1] = key;
                    }
                    else
                    {
                        flag = 1;
                    }
                }
            }
            return array;
        }
    }
}
