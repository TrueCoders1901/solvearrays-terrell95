using System;
using System.Collections.Generic;

namespace SolveArrays
{
    public class ArraySolver
    {
        public int Sum(int[] numbers)
        {
            int total = 0;

            foreach (int number in numbers)
            {
                total = total + number;
            }

            return total;
        }


        public int SumEvens(int[] numbers)
        {
            int totalofEvens = 0;

            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    totalofEvens = totalofEvens + number;
                }
                return totalofEvens;
            }
            // TODO: Implement this method
            throw new NotImplementedException();
        }

        public double AverageEvens(int[] numbers)
        {
            int totalofEvens = 0;
            int countofEvans = 0;

            foreach (int number in numbers)
            {


                if (number % 2 == 0)
                {
                    totalofEvens += number;
                    countofEvans += 1;
                }

            }
            if (countofEvans == 0)
            {
                return 0;
            }
            else
            {
                double average = (double)totalofEvens / countofEvans;
                return average;

            }
        }



        public bool IsSumOdd(List<int> numbers)
        {
            // get the sum of all the numbers in the list
            // first, the list needs to be converted to an array

            int total = Sum(numbers.ToArray());
            // check if the total is odd. Return true if it is, false if not
            // first, the list needs to be converted to an answer
            if (total % 2 != 0)
            {
                return true;
            }

            {
                return false;
            }


        }
    }
}
