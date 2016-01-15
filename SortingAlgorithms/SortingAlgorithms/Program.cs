using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SortingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Accessing the file.");
            int[] list = readFromFile();
            Console.WriteLine("File loaded.");
            Console.WriteLine("Choose the type of sorting algorithm you wish to use.");
            Console.WriteLine();
            Console.WriteLine("1. Bubble Sort");
            Console.WriteLine("2. Insertion Sort");
            Console.WriteLine();


            string userChoice = Console.ReadLine();

            switch(userChoice)
            {
                case "1":
                    bubbleSort(list);
                    break;
                case "2":
                    insertionSort(list);
                    break;
                default:
                    Console.WriteLine("Not a valid selection; please choose again.");
                    break;
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadLine();
        }

        static int[] readFromFile()
        {
            string fileText = File.ReadAllText("C:\\Dev\\data\\unsorted-numbers.txt");
            string[] numberString = fileText.Split(',');
            int[] numbers = new int[numberString.Length];

            for (int i = 0; i < numberString.Length; i++)
            {
                numbers[i] = int.Parse(numberString[i]);
            }

            return numbers;

        }


        static void bubbleSort(int[] list)
        {
            printList("Unsorted List", list);

            for (int i = list.Length - 1; i > 0; i--)
            {
                for (int j = 0; j < i; j ++)
                {
                    if (list[j] > list[j + 1])
                    {
                        int temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                    }
                }
            }

            printList("Sorted list", list);
        }


        static void insertionSort(int[] list)
        {
            printList("Unsorted List", list);

            for(int i = 0; i < list.Length; i++ )
            {
                int j = i;

                while (j > 0 )
                {
                    if (list[j] < list[j - 1])
                    {
                        int temp = list[j];
                        list[j] = list[j - 1];
                        list[j - 1] = temp;
                    }

                    j--;                    
                }
            }

            printList("Sorted list", list);
        }

        static void printList(string listName, int[] list)
        {
            Console.WriteLine("-- " + listName + " --");
            for (int i = 0; i < list.Length; i++)
            {
                Console.Write(list[i] + ", ");
            }
            Console.WriteLine();
        }
    }
}

