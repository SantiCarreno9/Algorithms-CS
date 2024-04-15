
internal class DataStructuresTest
{
    private static void Main(string[] args)
    {
        //Final Test
        Queue<Account> queue = new Queue<Account>();
        queue.Enqueue(new(5, "Santiago", 10000));
        queue.Enqueue(new(13, "Felipe", 500));
        queue.Enqueue(new(19, "Carreno", 1997));
        queue.Enqueue(new(97, "Pardo", 5123));
        queue.Enqueue(new(12, "Marcela", 5000));
        queue.Enqueue(new(1, "Maria", 2705));
        queue.Enqueue(new(28, "Dicue", 2810));
        queue.Enqueue(new(27, "Menza", 9875));
        queue.Enqueue(new(29, "Mary", 258));
        queue.Enqueue(new(4, "Luz", 3697));
        queue.Enqueue(new(17, "Laura", 4561));
        queue.Enqueue(new(2, "Sofia", 3497));

        SelectionSort(queue);
        while (queue.Count > 0)
        {
            var item = queue.Dequeue();
            Console.WriteLine($"{item.AccountNumber} {item.CustomerName}");
        }


        static void SelectionSort(Queue<Account> queue)
        {
            if (queue == null || queue.Count <= 1)
                return;

            Queue<Account> organizedQueue = new Queue<Account>();
            int size = queue.Count;

            for (int i = 0; i < size; i++)
            {
                int minIndex = 0;
                for (int j = 1; j < size - i; j++)
                {
                    if (queue.ElementAt(minIndex).AccountNumber > queue.ElementAt(j).AccountNumber)
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
    }
}