using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Random Number Generator *********************
            Random rnd = new Random();

            //Variable Declaration and Initialization **************
            int firstRoll = 0;
            int secondRoll = 0;
            int sum;

            //Array Declaration ******************
            int[] sumArray = new int[11];


            //for loop to roll the dice 36000 times
            for (int i = 0; i < 36000; i++)
            {
                firstRoll = rnd.Next(1, 7);
                secondRoll = rnd.Next(1, 7);
                sum = firstRoll + secondRoll;

                //switch statement to add up how many times each value is achieved
                switch (sum)
                {
                    case 2:
                        sumArray[0]++;
                        break;
                    case 3:
                        sumArray[1]++;
                        break;
                    case 4:
                        sumArray[2]++;
                        break;
                    case 5:
                        sumArray[3]++;
                        break;
                    case 6:
                        sumArray[4]++;
                        break;
                    case 7:
                        sumArray[5]++;
                        break;
                    case 8:
                        sumArray[6]++;
                        break;
                    case 9:
                        sumArray[7]++;
                        break;
                    case 10:
                        sumArray[8]++;
                        break;
                    case 11:
                        sumArray[9]++;
                        break;
                    case 12:
                        sumArray[10]++;
                        break;
                }
            }


            //Displaying to console
            Console.WriteLine();
            Console.WriteLine("\t***********************************");
            Console.WriteLine("\t\t**** TOTAL ****");
            Console.WriteLine("\t***********************************");
            Console.WriteLine();
            //For loop to go through each index in the array and display its value
            Console.WriteLine("\t    Faces    Frequency");
            for (int index = 0; index < sumArray.Length; index++)
            {
                Console.WriteLine("\t {0,5}: {1,10} ", index + 2, sumArray[index]);
            }

            WaitForKey();
        }
        private static void WaitForKey()
        {
            Console.WriteLine();
            Console.WriteLine("\t***********************************");
            Console.WriteLine("\t    Press any key to continue...");
            Console.WriteLine("\t***********************************");
            Console.ReadKey();
        }
    }
}