using System;

namespace Assign1Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            int noOfElements;
            int[] arr = new int[10];
            int ptr;
            int j;
            int i;
            Console.Write("\nNumber of Elements\n");
            noOfElements = Convert.ToInt32(Console.ReadLine());

            Console.Write("-----------------------------------------\n");

            Console.Write("\n\nWrite {0} elements of an array :\n", noOfElements);
            Console.Write("-----------------------------------------\n");
            for (i = 0; i < noOfElements; i++)
            {
                Console.Write("Element No: {0} - on Index {1} : ", i + 1, i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
        
             
        for ( i = 1; i < noOfElements; ++i) { 
            
            ptr = arr[i]; 
            j= i - 1; 
  
            while (j >= 0 && arr[j] > ptr) { 
                arr[j + 1] = arr[j]; 
                j = j - 1; 
            } 
            arr[j + 1] = ptr; 
        } 

     Console.Write("\nSorted Array: \n");
        for (i = 0; i < noOfElements; ++i) 

        
            Console.Write(arr[i] + " "); 
  
        Console.Write("\n"); 
        }
    }
}
