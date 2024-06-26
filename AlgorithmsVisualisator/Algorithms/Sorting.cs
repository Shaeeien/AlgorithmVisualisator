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

        public static T[] InsertionSort(T[] array, bool ascending)
        {            
            for(int i = 1; i < array.Length; i++)
            {
                T current = array[i];
                int j = i - 1;
                if (ascending)
                {
                    while (j >= 0 && array[j].CompareTo(current) > 0)
                    {
                        array[j + 1] = array[j];
                        j--;
                    }
                }
                else
                {
                    while (j >= 0 && array[j].CompareTo(current) < 0)
                    {
                        array[j + 1] = array[j];
                        j--;
                    }
                }
                
                array[j + 1] = current;
                WriteArray(array);
            }
            
            return array;
        }

        public static T[] SelectionSort(T[] array,  bool ascending)
        {
            for(int i = 0; i < array.Length - 1; i++)
            {
                if (ascending)
                {
                    int smallestIndex = i;
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        if (array[j].CompareTo(array[smallestIndex]) < 0)
                        {
                            smallestIndex = j;
                        }
                    }
                    (array[i], array[smallestIndex]) = (array[smallestIndex], array[i]);
                }
                else
                {
                    int biggestIndex = i;
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        if (array[j].CompareTo(array[biggestIndex]) > 0)
                        {
                            biggestIndex = j;
                        }
                    }
                    (array[i], array[biggestIndex]) = (array[biggestIndex], array[i]);
                }
                
            }
            WriteArray(array);
            return array;
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
