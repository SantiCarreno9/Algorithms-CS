using SortingAlgorithmsNS;

int[] originalArray = new int[] { 5, 4, 3, 9, 2, 7 };
int[] copy = SortingAlgorithms.CopyArray(originalArray);
Console.WriteLine("\nMerge Sort Algorithm:");
SortingAlgorithms.MergeSort(copy);
Console.WriteLine("\nSorted Array");
SortingAlgorithms.PrintArray(copy);


copy = SortingAlgorithms.CopyArray(originalArray);
Console.WriteLine("\nQuick Sort Algorithm:");
SortingAlgorithms.QuickSort(copy);
Console.WriteLine("\nSorted Array:");
SortingAlgorithms.PrintArray(copy);


copy = SortingAlgorithms.CopyArray(originalArray);
Console.WriteLine("\nInsertion Sort Algorithm:");
SortingAlgorithms.InsertionSort(copy);
Console.WriteLine("\nSorted Array:");
SortingAlgorithms.PrintArray(copy);

copy = SortingAlgorithms.CopyArray(originalArray);
Console.WriteLine("\nSelection Sort Algorithm:");
SortingAlgorithms.SelectionSort(copy);
Console.WriteLine("\nSorted Array:");
SortingAlgorithms.PrintArray(copy);

Queue<int> queue = new Queue<int>();
for (int i = 0; i < originalArray.Length; i++)
    queue.Enqueue(originalArray[i]);

Console.WriteLine("\nSelection Sort Algorithm Queue:");
SortingAlgorithms.SelectionSort(queue);
while (queue.Count > 0)
    Console.Write(queue.Dequeue() + (queue.Count > 0 ? ", " : "\n"));
