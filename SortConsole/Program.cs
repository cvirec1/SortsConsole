using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] data = GenerateData(10000,100000);
            //BubbleSort(data);                   
            //SelectionSort(data);
            WriteData(InsertSort(data));
            //WriteData(BubbleSort(data));
            //WriteData(SelectionSort(data));
            //InsertSort(data);
            Console.ReadKey();
        }

        static int[] BubbleSort(int[] data)
        {
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length - 1; j++)
                {
                    if (data[j] > data[j + 1])
                    {                        
                        ChangeNumber(ref data[j],ref data[j + 1]);
                    }
                }
               // Console.WriteLine((data[(data.Length - 1) - i]));
            }
            return data;
        }

        static int[] SelectionSort(int[] data)
        {
            for (int i = 0; i < data.Length; i++)
            {
                int maxIndex = i;
                for (int j = i; j < data.Length-1;j++)
                {
                    if (data[i] > data[j+1])
                    {
                        ChangeNumber(ref data[i], ref data[j + 1]);
                    }
                }
                //Console.WriteLine(data[i]);
            }
            return data;
        }

        static int[] InsertSort(int[] data)
        {
            for (int i = 0; i < data.Length; i++)
            {
                int currIndex = i;
                int currData = data[i];
                for (int j = 0; j < data.Length; j++)
                {
                    if (currIndex > 0 && data[currIndex - 1] > currData)
                    {
                        data[currIndex] = data[currIndex - 1];
                        currIndex--;
                    }
                    else
                    {
                        data[currIndex] = currData;
                    }
                }        
            }
            return data;
        }

        static void WriteData(int [] data)
        {
            for (int i = 0; i < data.Length; i++)
            {
                Console.WriteLine(data[i]);
            }
        }
        static int[] GenerateData(int size,int max)
        {
            int[] data = new int[size];
            Random r = new Random();
            for (int i = 0; i < data.Length; i++)
            {
                data[i] = r.Next(0, max);
            }
            return data;
        }

        static void ChangeNumber(ref int firstNumber, ref int secondNUmber)
        {
            
            int temp = secondNUmber;
            secondNUmber = firstNumber;
            firstNumber = temp;
        }
    }
}
