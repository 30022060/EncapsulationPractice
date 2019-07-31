using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapQuestions
{
    //PRACTICE QUESTIONS 2 Task 1 
    class Program
    {
        static void Main(string[] args)
        {
            int height = 0;
            int width = 0;
            int length = 0;

            height = GetData(height, "Height");
            width = GetData(width, "Width");
            length = GetData(length, "Length");

            Box b1 = new Box(height, width, length);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(b1.GetSurfaceArea());
            Console.ReadLine();

        }


        static int GetData(int number, string info)
        {
            bool check = true;
            bool confirm = false;

            do
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write($"Please enter {info} of the Box: ");
                confirm = int.TryParse(Console.ReadLine(), out number);
                do
                {
                    if (!confirm)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("ERROR. NUMBER NOT VALID. PLEASE TRY AGAIN.");
                        confirm = int.TryParse(Console.ReadLine(), out number);
                    }
                } while (!confirm);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"{info} has been set.\n\n");
                break;

            } while (check);
             return number;   
        }
      
      class Box
      {
            private int Height { get; set; }
            private int Width { get; set; }
            private int Length { get; set; }

            public Box(int _height, int _width, int _length)
            {
                Height = _height;
                Width = _width;
                Length = _length;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("***BOX HAS BEEN CREATED***\n\n");
            }
         public string GetSurfaceArea()
            {
                return $"Surface Area of Box: {2 * (Height * Width) + 2 * (Height * Length) + 2 * (Width * Length)}";
            }

      }

    }
}
