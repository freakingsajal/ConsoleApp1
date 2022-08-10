namespace merge_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[100];
            int[] arr2 = new int[100];
           // int[] arr3 = new int[] {};
            int n1, n2, n3;
            int i, j;

            Console.Write("Input the number of elements to be stored in the first array :");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input " + n1 + " elements in the array :\n");
            for (i = 0; i < n1; i++)
            {
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }


            Console.Write("Input the number of elements to be stored in the second array :");
            n2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input " + n2 + " elements in the array :\n");
            for (i = 0; i < n2; i++)
            { 
                arr2[i] = Convert.ToInt32(Console.ReadLine());
            }


            int[] arr3 = new int[n1+n2];


            for (i = 0; i < n1; i++)
            {
                arr3[i] = arr1[i];
            }
            for (j = 0; j < n2; j++)
            {
                arr3[i] = arr2[j];
                i++;
            }

            Array.Sort(arr3);
            n3 = arr3.Length;
            for (i = 0; i < n3; i++)
            {
                Console.Write(arr3[i] + " ");
            }
            Console.Write("\n\n");


        }
    }
}