using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1_4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            DrawBar(40, ConsoleColor.Red, 2);
            DrawBar(80, ConsoleColor.Blue, 4);
            Console.SetCursorPosition(0, 20);
            Console.Write("Для продолжения нажмите любую кнопку...");
            Console.ReadKey();
        }

        static void DrawBar(int fullnessPercent, ConsoleColor barColor, int positionY, int positionX=2, char drawSymbol=' ')
        {
            Console.SetCursorPosition(positionX, positionY);

            if (fullnessPercent > 100 || fullnessPercent < 0)
            {
                Console.WriteLine("Недопустимое значение %");
            }
            else
            {
                const int maxValue = 100;
                int maxPossiblePercent = 100;
                int fullnessValue = maxValue * fullnessPercent / maxPossiblePercent;
                ConsoleColor defaultColor = Console.BackgroundColor;

                Console.Write("[");
                DrawLine(fullnessValue, barColor, drawSymbol);
                DrawLine(maxValue - fullnessValue, defaultColor, drawSymbol);
                Console.Write("]");
            }
        }

        static void DrawLine (int length, ConsoleColor color, char drawSymbol=' ')
        {
            ConsoleColor defaultColor = Console.BackgroundColor;
            Console.BackgroundColor = color;

            for (int value = 0; value < length; value++)
            {
                Console.Write(drawSymbol);
            }

            Console.BackgroundColor = defaultColor;
        }
    }
}