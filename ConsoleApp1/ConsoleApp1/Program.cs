using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            
            char[,] matrixMap = new char[n, n];
            
            char[,] matrixDisplay = new char[n, n];

            Hero player = new Hero(0,0,0,0);
            
            player= kartGenerate(matrixMap, matrixDisplay, n);

            Print2DArray(matrixDisplay, n);
            
            Print2DArray(matrixMap, n);
            
            ConsoleKeyInfo key;
            
            do
            {
                key = Console.ReadKey(true);
            
                if (key.Key == ConsoleKey.LeftArrow)
                {
                    int x, y;
                
                    if (player.X != 0)
                    { 
                        x = player.X--;
                    
                        player.step();
                    }
                }
                
                player.InfoPrint();
            }
            while (key.Key != ConsoleKey.Escape);
        }

        public static void Print2DArray(char[,] arr, int n)
        {
            Console.Write("\n");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(arr[j, i]);
                }

                Console.Write("\n");
            }
        }

        public static void PrintmatrixMap(Array a)
        {
            for (int i = 0; i < a.GetLength(0); ++i)
            {
                for (int j = 0; i < a.GetLength(1); ++i)
                {
                    Console.Write("\t" + a.GetValue(i, j));
                }

                Console.WriteLine();
            }
        }

        public static Hero kartGenerate(char[,] matrixMap, char[,] matrixDisplay, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrixMap[j, i] = '*';
                    matrixDisplay[j, i] = '*';
                }
            }

            var rand = new Random();

            int count = 0;

            // генеруруем номер угла карты
            int HeroCoordinate = rand.Next(4);

            int PrincessCoordinate;

            int PlayerX = 0, PlayerY = 0, PincessX = 0, PrincessY = 0;

            // генеруруем номер угла карты отличный от героя
            while (true)
            {
                PrincessCoordinate = rand.Next(4);

                if (PrincessCoordinate != HeroCoordinate)
                {
                    break;
                }
            }

            switch (HeroCoordinate)//наносим на карту  героя
            {
                case 0:
                {
                    matrixMap[0, 0] = 'H';

                    matrixDisplay[0, 0] = 'H';

                    PlayerX = 0;

                    PlayerY = 0;

                    break;
                }
                case 1:
                    matrixMap[9, 0] = 'H'; matrixDisplay[9, 0] = 'H'; PlayerX = 9; PlayerY = 0; break;
                case 2:
                    matrixMap[0, 9] = 'H'; matrixDisplay[0, 9] = 'H'; PlayerX = 0; PlayerY = 9; break;
                case 3:
                    matrixMap[9, 9] = 'H'; matrixDisplay[9, 9] = 'H'; PlayerX = 9; PlayerY = 9; break;

            }

            switch (PrincessCoordinate)// наносим на карту принцессу
            {
                case 0:
                    matrixMap[0, 0] = 'P'; matrixDisplay[0, 0] = 'P'; PincessX = 0; PrincessY = 0; break;
                case 1:
                    matrixMap[9, 0] = 'P'; matrixDisplay[9, 0] = 'P'; PincessX = 9; PrincessY = 0; break;
                case 2:
                    matrixMap[0, 9] = 'P'; matrixDisplay[0, 9] = 'P'; PincessX = 0; PrincessY = 9; break;
                case 3:
                    matrixMap[9, 9] = 'P'; matrixDisplay[9, 9] = 'P'; PincessX = 9; PrincessY = 9; break;

            }

            Hero player = new Hero(PlayerX, PlayerY, PincessX, PrincessY);

            while (count < 10) // расставляем 10 ловушек
            {
                int temp = rand.Next(100);
                int NumRow = temp / 10;
                int NumCol = temp % 10;
                if (matrixMap[NumRow, NumCol] == '*')
                {
                    matrixMap[NumRow, NumCol] = 'x';
                    count++;
                }
            }
            return player;
        }
    }
}
