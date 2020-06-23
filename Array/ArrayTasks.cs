using System;

namespace ArrayObject
{
    public static class ArrayTasks
    {
        /// <summary>
        /// Task 1
        /// </summary>
        public static void ChangeElementsInArray(int[] nums)
        {
            int temp;
            int N = nums.Length - 1;

            for (int i = 0; i < nums.Length / 2; i++)
            {
                if (nums[i] % 2 == 0 && nums[N - i] % 2 == 0)
                {
                    temp = nums[i];
                    nums[i] = nums[N - i];
                    nums[N - i] = temp;
                }
            }
        }

        /// <summary>
        /// Task 2
        /// </summary>
        public static int DistanceBetweenFirstAndLastOccurrenceOfMaxValue(int[] nums)
        {
            if (nums.Length == 0)
                return 0;

            int max = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > max)
                {
                    max = nums[i];
                }
            }

            return Array.LastIndexOf(nums, max) - Array.IndexOf(nums, max);
        }

        /// <summary>
        /// Task 3 
        /// </summary>
        public static void ChangeMatrixDiagonally(object matrix)
        {
            int[,] newMatrix = matrix as int[,];

            for (int i = 0; i < newMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < newMatrix.GetLength(1); j++)
                {
                    if (i < j)
                    {
                        newMatrix[i, j] = 1;
                    }
                    else if (i > j)
                    {
                        newMatrix[i, j] = 0;
                    }
                }
            }
        }
    }
}