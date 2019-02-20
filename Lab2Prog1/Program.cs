using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static int[,] Keyboard(int Rows, int Calumns)
        {
            int[,] InputArrey = new int[Rows, Calumns];
            for (int i = 0; i < Rows; i++)
            {
                string[] NumbersInString = Console.ReadLine().Split();
                for (int j = 0; j < Calumns; j++)
                {
                    InputArrey[i, j] = Convert.ToInt32(NumbersInString[j]);
                }
            }
            return InputArrey;
        }
        static int[,] Rand(int Rows, int Calumns)
        {
            int[,] InputArray = new int[Rows, Calumns];
            Random Rand = new Random();
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Calumns; j++)
                {
                    InputArray[i, j] = Rand.Next(0, 9);
                    Console.Write(InputArray[i, j] + " ");
                }
                Console.WriteLine("");
            }
            return InputArray;
        }
        static int NumberOfLastColumn(int[,] InputArrey, int Rows, int Columns)
        {
            int NumberOfColumn = 0;
            int Temp = 0;
            for (int j = 0; j < Columns; j++)
            {
                for (int i = 0; i < Rows; i++)
                {
                    int Element = InputArrey[i, j];
                    if (Element == 0)
                    {
                        NumberOfColumn = Temp;
                        break;
                    }
                    else
                    {
                        NumberOfColumn = j + 1;
                    }
                }
                Temp = NumberOfColumn;
            }
            return NumberOfColumn;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введiть кiлькiсть рядкiв");
            int Rows = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введiть кiлькiсть стовпчикiв");
            int Calumns = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\"r\" щоб заповнити масив рандомно, \"k\" щоб заповнити масив з клавiатури");
            int[,] InputArrey = new int[Rows, Calumns];
            char Way = Convert.ToChar(Console.ReadLine());
            if (Way == 'r')
            {
                InputArrey = Rand(Rows, Calumns);
            }
            if (Way == 'k')
            {
                InputArrey = Keyboard(Rows, Calumns);
            }
            int NumberOfColumn = NumberOfLastColumn(InputArrey, Rows, Calumns);
            if (NumberOfColumn == 0)
            {
                Console.WriteLine("Всi введенi стовпцi мiстять нулi");
            }
            else
            {
                Console.WriteLine("Номер останнього зi стовпцiв, що не мiстить нуля: " + NumberOfColumn);
            }
            Console.ReadKey();
        }
    }
}
