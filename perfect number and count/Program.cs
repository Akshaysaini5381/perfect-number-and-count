using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace perfect_number_and_count
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the size array:");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];

            int ctr = 0;
            while (ctr<size)
            {
                Console.Write("Enter the "+(ctr+1)+" value  of  array : ");
                arr[ctr] = int.Parse(Console.ReadLine());
                ctr++;
            }
            Console.Write("my array :");
            int ptr = 0;
            while (ptr<size)
            {
                Console.Write(" "+arr[ptr]);
                ptr++;
            }

            int perfectNumbers = 0;

            Console.WriteLine();
            for (int i=0;i<arr.Length;i++)
            {
                long num = arr[i];
                long sum = 0;

                for (int j = 1; j <= num / 2; j++)
                {
                    if (num % j == 0)
                    {
                        sum = sum + j;
                    }
                }

                if (num == sum)
                {
                    perfectNumbers++;
                    Console.WriteLine(arr[i]+" is perfect number ");
                }
            }

            Console.WriteLine("Total perfect number is :"+perfectNumbers);

            Console.ReadLine();
        }
    }
}
