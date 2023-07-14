using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //day05
            //exercise 01
            Console.WriteLine("Enter the number of employees:");
            int noe = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of working days:");
            int now=int.Parse(Console.ReadLine());
            int[][] salaries = new int[noe][];

            for(int i = 0; i < noe; i++)
            {
                salaries[i]= new int[now];
                Console.WriteLine($"Enter the salary for day: of employee{0}:",(i+1));
                for(int j = 0; j < now; j++)
                {
                    Console.Write($"Day{0}:", (j+1));
                    salaries[i][j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Weekly Salary:");
            Console.WriteLine("****************************");
            Console.WriteLine("Day\t");
            for (int i = 0; i < now; i++)
            {
                Console.Write("Day {0}\t", (i + 1));
            }
            Console.WriteLine("Total Salary");

            for (int i = 0; i < noe; i++)
            {
                int totalSalary = 0;
                Console.Write("Employee {0}\t", (i + 1));
                for (int j = 0; j < now; j++)
                {
                    Console.Write("{0}\t", salaries[i][j]);
                    totalSalary += salaries[i][j];
                }
                Console.WriteLine(totalSalary);
            }

            Console.ReadKey();
        }
    }
    }

            
       
   
