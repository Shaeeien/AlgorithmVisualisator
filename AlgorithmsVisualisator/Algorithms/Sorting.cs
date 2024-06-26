using System.Numerics;

namespace AlgorithmsVisualisator.Algorithms
{
    public static class Sorting<T> where T : IComparable
    {
        public static void WriteArray(T[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }

        public static T[] QuickSort(ref T[] array, bool ascending, int leftIndex, int rightIndex)
        {
            int i = leftIndex;
            int j = rightIndex;
            T pivot = array[leftIndex];

            while (i <= j)
            {                
                while (array[i].CompareTo(pivot) < 0)
                {
                    i++;
                }

                while (array[j].CompareTo(pivot) > 0)
                {
                    j--;
                }

                if (i <= j)
                {
                    (array[i], array[j]) = (array[j], array[i]);
                    i++;
                    j--;
                }
            }

            if (leftIndex < j)
                QuickSort(ref array, ascending, leftIndex, j);

            if (i < rightIndex)
                QuickSort(ref array, ascending, i, rightIndex);
            return array;
        }

        public static T[] BubbleSort(T[] array, bool ascending) 
        {
            for(int i = 0; i < array.Length; i++)
            {
                for(int j = 0; j < array.Length - 1; j++)
                {
                    if (ascending)
                    {
                        if (array[i].CompareTo(array[j]) > 0)
                        {
                            (array[i], array[j]) = (array[j], array[i]);
                        }
                    }
                    else
                    {
                        if (array[i].CompareTo(array[j]) < 0)
                        {
                            (array[i], array[j]) = (array[j], array[i]);
                        }
                    }
                }
            }
            return array;
        }
    }
}
