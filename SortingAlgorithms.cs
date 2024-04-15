using System.Numerics;

namespace SortingAlgorithmsNS
{
    public static class SortingAlgorithms
    {
        public static T[] MergeSort<T>(T[] array) where T : INumber<T>
        {
            int length = array.Length;
            if (length <= 1)
                return array;

            int mid = length / 2;

            var leftArray = new T[mid];
            for (int i = 0; i < leftArray.Length; i++)
                leftArray[i] = array[i];

            var rightArray = new T[length - mid];
            int aux = 0;
            for (int i = mid; i < array.Length; i++)
            {
                rightArray[aux] = array[i];
                aux++;
            }            

            MergeSort(leftArray);
            MergeSort(rightArray);

            int l = 0;
            int r = 0;
            int k = 0;

            while (l < leftArray.Length && r < rightArray.Length)
            {
                if (leftArray[l] <= rightArray[r])
                {
                    array[k] = leftArray[l];
                    l++;
                }
                else
                {
                    array[k] = rightArray[r];
                    r++;
                }
                k++;
            }

            while (l < leftArray.Length)
            {
                array[k] = leftArray[l];
                l++;
                k++;
            }

            while (r < rightArray.Length)
            {
                array[k] = rightArray[r];
                r++;
                k++;
            }

            return array;
        }

        public static T[] QuickSort<T>(T[] array) where T : INumber<T>
        {
            int length = array.Length;
            if (length <= 1)
                return array;
            
            int randomIndex = new Random().Next(length);
            var pivot = array[randomIndex];

            Queue<T> lowerQueue = new Queue<T>();
            Queue<T> greaterQueue = new Queue<T>();
            for (int i = 0; i < length; i++)
            {
                if (i == randomIndex)
                    continue;

                if (array[i] <= pivot)
                    lowerQueue.Enqueue(array[i]);
                else greaterQueue.Enqueue(array[i]);
            }

            var lowerArray = lowerQueue.ToArray();
            var greaterArray = greaterQueue.ToArray();

            lowerQueue.Clear();
            greaterQueue.Clear();                       

            QuickSort(lowerArray);
            QuickSort(greaterArray);

            int l = 0;
            int g = 0;
            int k = 0;

            while (l < lowerArray.Length)
            {
                array[k] = lowerArray[l];
                l++;
                k++;
            }

            array[k] = pivot;
            k++;

            while (g < greaterArray.Length)
            {
                array[k] = greaterArray[g];
                g++;
                k++;
            }                        

            return array;
        }

        public static void InsertionSort<T>(T[] array) where T : INumber<T>
        {
            if (array == null || array.Length <= 1)
                return;
            for (int i = 1; i < array.Length; i++)
            {
                int j = i - 1;
                var key = array[i];
                while (j >= 0 && key < array[j])
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = key;
            }            
        }

        public static void SelectionSort<T>(T[] array) where T : INumber<T>
        {
            if (array == null || array.Length <= 1)
                return;
            for (int i = 0; i < array.Length; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[minIndex] > array[j])
                        minIndex = j;
                }
                var aux = array[minIndex];
                array[minIndex] = array[i];
                array[i] = aux;
            }            
        }

        public static void SelectionSort<T>(Queue<T> queue) where T : INumber<T>
        {
            if (queue == null || queue.Count <= 1)
                return;

            Queue<T> organizedQueue = new Queue<T>();
            int size = queue.Count;

            for (int i = 0; i < size; i++)
            {
                int minIndex = 0;
                for (int j = 1; j < size - i; j++)
                {
                    if (queue.ElementAt(minIndex)> queue.ElementAt(j))
                        minIndex = j;
                }

                var current = queue.Dequeue();
                if (minIndex == 0)
                    organizedQueue.Enqueue(current);
                else
                {
                    queue.Enqueue(current);
                    int k = 0;
                    while (k < minIndex - 1)
                    {
                        queue.Enqueue(queue.Dequeue());
                        k++;
                    }
                    var minValue = queue.Dequeue();
                    organizedQueue.Enqueue(minValue);
                }

            }

            while (organizedQueue.Count > 0)
                queue.Enqueue(organizedQueue.Dequeue());
        }

        public static void PrintArray(int[] array)
        {
            if (array.Length == 0)
                Console.WriteLine();
            for (int i = 0; i < array.Length; i++)
                Console.Write(array[i] + (i == array.Length - 1 ? "\n" : ", "));
        }

        public static int[] CopyArray(int[] array)
        {
            int[] copy = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
                copy[i] = array[i];
            return copy;
        }
    }
}
