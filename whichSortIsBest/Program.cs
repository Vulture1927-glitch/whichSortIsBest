using System.Threading.Channels;

public class Program()
{
    static void Main()
    {
        //Selection Sort
        int numbersAdded = 0;
        int[] masterArray = new int[5];
        int numberOfComparisons = 0;
        int numberOfSwaps = 0;
        int totalOperations = 0;
            while (numbersAdded < 5)
            {
                Console.WriteLine("Input a number");
                int number = int.Parse(Console.ReadLine());
                masterArray[numbersAdded] = number;
                numbersAdded++;
            }
        //Display the array before sorting
        Console.WriteLine("Before sorting:");
        for (int i = 0; i < masterArray.Length; i++)
        {
            Console.WriteLine(masterArray[i]);
        }
        //Selection sort algorithm
        for (int i = 0; i < masterArray.Length - 1; i++)
        {
            int minIndex = i;

            for (int j = i + 1; j < masterArray.Length; j++)
            {
                numberOfComparisons++;

                if (masterArray[j] < masterArray[minIndex])
                {
                    minIndex = j;
                }
            }

            if (minIndex != i)
            {
                numberOfSwaps++;

                int temp = masterArray[i];
                masterArray[i] = masterArray[minIndex];
                masterArray[minIndex] = temp;
            }
        }
        Console.WriteLine("After sorting:");
        for (int i = 0; i < masterArray.Length; i++)
        {
            Console.WriteLine(masterArray[i]);
        }
        totalOperations = numberOfComparisons + numberOfSwaps;
        Console.WriteLine("Swaps: " + numberOfSwaps);
        Console.WriteLine("Comparisons: " + numberOfComparisons);
        Console.WriteLine("Total operations: " + totalOperations);

        //Reset
        numberOfComparisons = 0;
        numberOfSwaps = 0;
        totalOperations = 0;
        int numbersAdded2 = 0;
        //Remake the array for the next sort, though this is the best I've got for now
        while (numbersAdded2 < 5)
        {
            Console.WriteLine("Input a number");
            int number = int.Parse(Console.ReadLine());
            masterArray[numbersAdded2] = number;
            numbersAdded2++;
        }


        //Bubble Sort
        for (int i = 0; i < masterArray.Length; i++)
        {
                numberOfComparisons++;
            for(int j = 0; j < masterArray.Length - i -1; j++) {
                if (masterArray[j] > masterArray[j + 1])
                {
                    int temp = masterArray[j];
                    masterArray[j] = masterArray[j + 1];
                    masterArray[j + 1] = temp;
                    numberOfSwaps++;
                }
            }
        }
        Console.WriteLine("After bubble sorting:");
        for (int i = 0; i < masterArray.Length; i++)
        {
            Console.WriteLine(masterArray[i]);
        }
        totalOperations = numberOfComparisons + numberOfSwaps;

        Console.WriteLine("Comparisons: " + numberOfComparisons);
        Console.WriteLine("Swaps: " + numberOfSwaps);
        Console.WriteLine("Total operations: " + totalOperations);

        numberOfComparisons = 0;
        numberOfSwaps = 0;
        totalOperations = 0;
        int numbersAdded3 = 0;
        while (numbersAdded3 < 5)
        {
            Console.WriteLine("Input a number");
            int number = int.Parse(Console.ReadLine());
            masterArray[numbersAdded3] = number;
            numbersAdded3++;
        }

        //Insertion Sort
        for (int i = 0; i < masterArray.Length; i++)
        {
            int temp = masterArray[i];
            int j = i - 1;
            while (j >= 0)
            {
                numberOfComparisons++;

                if (temp < masterArray[j])
                {
                    masterArray[j + 1] = masterArray[j];
                    numberOfSwaps++;
                    j--;
                }
                else
                {
                    break;
                }
            }
            masterArray[j + 1] = temp;
        }
        Console.WriteLine("After insertion sorting:");
        for (int i = 0; i < masterArray.Length; i++)
        {
            Console.WriteLine(masterArray[i]);
        }
        totalOperations = numberOfComparisons + numberOfSwaps;
        Console.WriteLine("Comparisons: " + numberOfComparisons);
        Console.WriteLine("Swaps: " + numberOfSwaps);
        Console.WriteLine("Total operations: " + totalOperations);
    }


}
