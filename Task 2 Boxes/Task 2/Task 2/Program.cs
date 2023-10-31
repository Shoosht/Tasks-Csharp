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

            for(int i = 0; i < 10; i++)
            {
                /// x = length, y = width, z = height
                
                int x = rnd.Next(1, 11);
                int y = rnd.Next(1, 11);
                int z = rnd.Next(1, 11);

                boxesArr[i] = new Box(i, x, y, z);

                Console.Write("ID: " + boxesArr[i].id + "  Dimensions: " + boxesArr[i].length + " " + boxesArr[i].width + " " + boxesArr[i].height + "\n");

                //Rotated boxes
                boxesArr[10 + i] = new Box(i, z, y, x);
                boxesArr[20 + i] = new Box(i, z, x, y);

                Console.Write("ID: " + boxesArr[10 + i].id + "  Dimensions: " + boxesArr[10 + i].length + " " + boxesArr[10 + i].width + " " + boxesArr[10 + i].height + "\n");
                Console.Write("ID: " + boxesArr[20 + i].id + "  Dimensions: " + boxesArr[20 + i].length + " " + boxesArr[20 + i].width + " " + boxesArr[20 + i].height + "\n");
            }
            Console.Write("\n");

            Array.Sort(boxesArr, (box1, box2) => box2.base_area.CompareTo(box1.base_area));

            Console.Write("Sorted array\n");
            for (int i = 0; i < 30; i++)
            {
                Console.Write("ID: " + boxesArr[i].id + "  Dimensions: " + boxesArr[i].length + " " + boxesArr[i].width + " " + boxesArr[i].height + " " + boxesArr[i].base_area + "\n");
            }

            Max_Height(boxesArr);
        }


        //Case where there can be multiple instances of a certain box.
        //TODO There can be only one instance of a certain box.
        static void Max_Height(Box[] boxesArr)
        {
            int[] maxArray = new int[30];
            int[] prevBoxIndex = new int[30];

            for (int i=0; i<30; i++) {
                maxArray[i] = boxesArr[i].height;
                prevBoxIndex[i] = -1;
            }
            

            for(int i = 1; i < 30; i++)
            {
                for(int j = 0; j < i; j++)
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

            for (int i = 0; i < 30; i++)
            {
                if (maxArray[i] > max)
                {
                    max = maxArray[i];
                    topBoxIndex = i;
                }
            }

            if (topBoxIndex != -1)
            {
                Console.WriteLine("\nMax stack height for a case where multiple instances of a certain box can be used: " + max);

                
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
