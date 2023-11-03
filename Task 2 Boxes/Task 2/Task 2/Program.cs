using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Box
    {
        public int id;
        public int length;
        public int width;
        public int height;
        public int base_area;

        public Box(int id, int length, int width, int height)
        {
            this.id = id;
            this.length = length;
            this.width = width;
            this.height = height;
            this.base_area = length * width;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Box[] boxesArr = new Box[30];

            Random rnd = new Random();

            Console.WriteLine("Initial boxes: ");
            for (int i = 0; i < 10; i++)
            {
                // x = length, y = width, z = height

                int x = rnd.Next(1, 11);
                int y = rnd.Next(1, 11);
                int z = rnd.Next(1, 11);

                boxesArr[i] = new Box(i, x, y, z);

                Console.Write("ID: " + boxesArr[i].id + "  Dimensions: " + boxesArr[i].length + " " + boxesArr[i].width + " " + boxesArr[i].height + "\n");

                //Rotated boxes
                boxesArr[10 + i] = new Box(i, z, y, x);
                boxesArr[20 + i] = new Box(i, z, x, y);

                Console.Write("ID: " + boxesArr[10 + i].id + "  Dimensions: " + boxesArr[10 + i].length + " " + boxesArr[10 + i].width + " " + boxesArr[10 + i].height + " Rotated box \n");
                Console.Write("ID: " + boxesArr[20 + i].id + "  Dimensions: " + boxesArr[20 + i].length + " " + boxesArr[20 + i].width + " " + boxesArr[20 + i].height + " Rotated box \n");
            }
            Console.Write("\n");


            //Case for non-rotated boxes array

            Box[] nonRotatedBoxesArr = new Box[10];

            //New array for 
            for(int i = 0; i < 10; i++)
            {
                nonRotatedBoxesArr[i] = boxesArr[i];
            }

            Array.Sort(nonRotatedBoxesArr, (box1, box2) => box2.base_area.CompareTo(box1.base_area));

            int boxCount = nonRotatedBoxesArr.Length;

            Console.Write("\nMax stack height for non-rotated boxes:\n");

            Max_Height(nonRotatedBoxesArr, boxCount);

            boxCount = boxesArr.Length;

            //Sort boxes by their base area

            Array.Sort(boxesArr, (box1, box2) => box2.base_area.CompareTo(box1.base_area));

            Console.Write("\nSorted array\n");
            for (int i = 0; i < boxCount; i++)
            {
                Console.Write("ID: " + boxesArr[i].id + "  Dimensions: " + boxesArr[i].length + " " + boxesArr[i].width + " " + boxesArr[i].height + " " + boxesArr[i].base_area + "\n");
            }


            //TODO Case where rotated boxes can be used but only a single instance of the same box is used in the max stack

            Console.Write("\nCase where multiple instances of a box can be used and boxes can be rotated:\n");

            Max_Height(boxesArr, boxCount);
        }


        static void Max_Height(Box[] boxesArr, int boxCount)
        {
            int[] maxArray = new int[boxCount];
            int[] prevBoxIndex = new int[boxCount];

            for (int i = 0; i < boxCount; i++)
            {
                maxArray[i] = boxesArr[i].height;
                prevBoxIndex[i] = -1;
            }


            for (int i = 1; i < boxCount; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (boxesArr[i].length <= boxesArr[j].length && boxesArr[i].width <= boxesArr[j].width && maxArray[i] < maxArray[j] + boxesArr[i].height)
                    {
                        maxArray[i] = maxArray[j] + boxesArr[i].height;
                        prevBoxIndex[i] = j;
                    }
                }

            }

            int max = 0;
            int topBoxIndex = -1;

            for (int i = 0; i < boxCount; i++)
            {
                if (maxArray[i] > max)
                {
                    max = maxArray[i];
                    topBoxIndex = i;
                }
            }

            if (topBoxIndex != -1)
            {
                Console.WriteLine("\nMax height for stacked boxes: " + max);


                Stack<int> stack = new Stack<int>();
                while (topBoxIndex != -1)
                {
                    stack.Push(topBoxIndex);
                    topBoxIndex = prevBoxIndex[topBoxIndex];
                }

                foreach (int index in stack)
                {
                    Box box = boxesArr[index];
                    Console.Write("ID: " + box.id + "  Dimensions: " + box.length + " " + box.width + " " + box.height + "\n");
                }
            }
            else
            {
                Console.WriteLine("No valid stack found.");
            }



        }


    }
}