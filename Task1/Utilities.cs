﻿using System;

namespace Task1
{
    public static class Utilities
    {
        /// <summary>
        /// Sorts an array in ascending order using bubble sort.
        /// </summary>
        /// <param name="numbers">Numbers to sort.</param>
        public static void Sort(int[] numbers)
        {
            if (numbers == null)
            {
                throw new ArgumentNullException();
            }
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = 0; j < numbers.Length - i - 1; j++)
                {
                    if (numbers[j + 1] < numbers[j])
                    {
                        Swap(numbers, j);

                    }
                }
            }
        }

        public static void Swap(int[] numbers, int j)
        {
            int temp;
            temp = numbers[j];
            numbers[j] = numbers[j + 1];
            numbers[j + 1] = temp;
        }

        /// <summary>
        /// Searches for the index of a product in an <paramref name="products"/> 
        /// based on a <paramref name="predicate"/>.
        /// </summary>
        /// <param name="products">Products used for searching.</param>
        /// <param name="predicate">Product predicate.</param>
        /// <returns>If match found then returns index of product in <paramref name="products"/>
        /// otherwise -1.</returns>
        public static int IndexOf(Product[] products, Predicate<Product> predicate)
        {
            if (products == null || predicate == null)
            {
                throw new ArgumentNullException();
            }
            for (int i = 0; i < products.Length; i++)
            {
                if (CheckEquality(products[i], predicate, i) > 0)
                    return i;
            }
            return -1;
        }

        public static int CheckEquality(Product product, Predicate<Product> predicate, int i)
        {
            if (predicate(product))
            {
                return i;
            }
            return -1;
        }
    }


}
