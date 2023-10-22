using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///[10, x, y, z]    x = sirina, y = duzina, z = visina

            int[,] boxesArray = new int[10, 3];

            Random rnd = new Random();

            Console.WriteLine("Initial boxes: ");

            for(int i = 0; i < 10; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    boxesArray[i, j] = rnd.Next(1, 11);
                    Console.Write(" " + boxesArray[i, j]);
                }
                Console.Write("\n");
            }
            Console.Write("\n");




        }

        void Max_Visina(int[,] boxesArray)
        {
            int[,] tempBoxes = new int[10, 3];

            tempBoxes[0, 2] = boxesArray[0,2];

            for (int i = 0; i < 10; i++)
            {
               for(int j=0; i < 3; j++)
                {

                }   

            }

        }

        void swap(int[,] boxesArray, int[,] tempBoxes, int i, int j)
        {
           
        }
    }
}
