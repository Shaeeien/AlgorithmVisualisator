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

        public static T[] QuickSort(T[] array, bool ascending, int pivot)
        {
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
                            T tmp = array[i];
                            array[i] = array[j];
                            array[j] = tmp;
                        }
                    }
                    else
                    {
                        if (array[i].CompareTo(array[j]) < 0)
                        {
                            T tmp = array[i];
                            array[i] = array[j];
                            array[j] = tmp;
                        }
                    }
                }
            }
            return array;
        }
    }
}
