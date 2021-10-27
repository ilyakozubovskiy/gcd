﻿using System;

namespace GcdTask
{
    public static class IntegerExtensions
    {
        /// <summary>
        /// Calculates GCD of two integers from [-int.MaxValue;int.MaxValue]  by the Euclidean algorithm.
        /// </summary>
        /// <param name="a">First integer.</param>
        /// <param name="b">Second integer.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or two numbers are int.MinValue.</exception>
        public static int FindGcd(int a, int b)
        {
            if (a == 0 && b == 0)
            {
                throw new ArgumentException("All numbers are 0");
            }

            if (a == int.MinValue)
            {
                throw new ArgumentOutOfRangeException(nameof(a));
            }

            if (b == int.MinValue)
            {
                throw new ArgumentOutOfRangeException(nameof(b));
            }

            return Math.Abs(GreatestCommonDivisor(a, b));
        }

        public static int GreatestCommonDivisor(int a, int b)
        { 
        return b == 0 ? a : GreatestCommonDivisor(b, a % b);
        } 
    }
}
