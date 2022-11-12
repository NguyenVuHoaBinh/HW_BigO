using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace BigO
{
    internal class Program
    {
        static int hw1(int num1, int num2)
        {
            if (num1 > num2)
            {
                return 1;
            }
            else if (num1 == num2)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }

        static List<Int32> hw2(List<Int32> a)
        {
            List<Int32> list = new List<Int32>();
            int mid = (int)Math.Floor((double)a.Count / 2);
            Console.WriteLine("mid: {0}",mid);
            if(a.Count % 2 == 0)
            {
                list.Add(a[mid-1]);
                list.Add(a[mid]);
                return list;
            }
            else
            {
                list.Add(a[mid]);
                return list;
            }
        }

        static int hw3(List<Int32> a)
        {
            int max = 0;
            foreach (Int32 i in a)
            {
                if (i > max) max = i;
            }
            return max;
        }

        static void hw4(List<Int32> a)
        {
            List<Int32> dup = new List<Int32>();
            for(int i = 0; i < a.Count; i++)
            {
                if(dup.Contains(a[i]))  continue;
                else
                {
                    int count = 1;
                    for (int j = i + 1; j < a.Count; j++)
                    {
                        if (a[i] == a[j]) count++;
                    }
                    Console.WriteLine("Value {0} has appeared {1} times", a[i], count);
                    dup.Add(a[i]);
                }
            }
        }

        static List<Int32> hw5(List<Int32> a, List<Int32> b)
        {
            List<Int32> findshared = new List<Int32>();
            for (int i = 0; i < a.Count; i++)
            {
                if (findshared.Contains(a[i])) continue;
                else
                {
                    int count = 1;
                    for (int j = 0; j < a.Count; j++)
                    {
                        if (a[i] == b[j]) findshared.Add(a[i]);
                    }
                }
            }
            return findshared;
        }

        static void hw6(int index,List<Int32> a)
        {
            for( int i = 0; i < a.Count; i++)
            {
                if (a[i] == index)
                    System.Console.Write("{0}, ",i);
                else continue;
            }
        }

        static void Main(string[] args)
        {
            List<Int32> list = new List<Int32>() { 1, 2, 3, 40, 5, 10, 20, 13 };
            List<Int32> list_dup = new List<Int32>() { 1, 2, 3, 40, 5, 10, 20, 13 , 1 , 1 , 1 , 40};

            //HW1
            Console.WriteLine("\nHW1: {0}", hw1(10, 4));
            //HW2
            Console.WriteLine("\nHW2:");
            foreach (Int32 i in hw2(list))
            {
                Console.WriteLine("Mid element in array: {0}",i);
            }
            //HW3
            Console.WriteLine("\nHW3: Max={0}", hw3(list));
            //HW4
            Console.WriteLine("\nHW4:");
            hw4(list_dup);
            //HW5
            Console.WriteLine("\nHW5: Find shared element");
            foreach (Int32 i in hw5(list,list_dup))
            {
                Console.Write("{0} ,", i);
            }
            //HW6
            Console.WriteLine("\nHW6: Index of element:");
            hw6(40, list_dup);
            Console.ReadLine();
        }
    }
}
