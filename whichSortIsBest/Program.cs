public class Program()
{
    static void Main()
    {
        //Selection Sort
        int numbersAdded = 0;
        int[] selectionArray = new int[5];
        int numberOfComparisons = 0;
        int numberOfSwaps = 0;
        int totalOperations = 0;
            while (numbersAdded < 5)
            {
                Console.WriteLine("Input a number");
                int number = int.Parse(Console.ReadLine());
                selectionArray[numbersAdded] = number;
                numbersAdded++;
            }
        //Display the array before sorting
        Console.WriteLine("Before sorting:");
        for (int i = 0; i < selectionArray.Length; i++)
        {
            Console.WriteLine(selectionArray[i]);
        }
        //Selection sort algorithm
        for (int i = 0; i < selectionArray.Length - 1; i++)
        {
            int minIndex = i;
            numberOfComparisons++;
            for (int j = i + 1; j < selectionArray.Length; j++)
            {
                numberOfComparisons++;
                if (selectionArray[j] < selectionArray[minIndex])
                {
                    minIndex = j;
                }

            }
            int temp = selectionArray[i];
            selectionArray[i] = selectionArray[minIndex];
            selectionArray[minIndex] = temp;
            
        }
        Console.WriteLine("After sorting:");
        for (int i = 0; i < selectionArray.Length; i++)
        {
            Console.WriteLine(selectionArray[i]);
        }
        totalOperations = numberOfComparisons + numberOfSwaps;
        Console.WriteLine();

    }
}
