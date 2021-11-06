using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Hero
    {
        private int x;
        private int y;
        private int xP;
        private int yP;
        private int heath;
        private int steps;
        private bool endGame;

        public Hero(int x, int y, int xP, int yP)
        { this.x = x;
          this.y = y;
          this.xP = xP;
          this.yP = yP;
          heath = 10;
          steps = 10;
          endGame = false;
        }

        public int X
        {
            set
            {
                x = value;
            }
            get
            {
                return x;
            }
        }
        public int XP
        {
            set
            {
                x = value;
            }
            get
            {
                return xP;
            }
        }
        public int Y
        {
            set
            {
                y = value;
            }
            get
            {
                return y;
            }
        }
        public int YP
        {
            set
            {
                y = value;
            }
            get
            {
                return yP;
            }
        }

        public void Explode()
        {
            var rand = new Random();
            int bombPower = rand.Next(11);
            heath -= bombPower;
            if (heath <= 0)
                EndGame();

        }

        public void Step(char[,] arr, int n)
        {
            steps--;
            if (steps == 0)
            { EndGame();
                return;
            }

            if (arr[x, y] == 'x')
            {
                Explode();

            }


        }

        public void EndGame()
        {
            steps=0;
            heath = 0;
            endGame = true;

        }

        public void StartGame()
        {
            steps = 10;
            heath = 10;
            endGame = false;

        }

        public void InfoPrint()
        {
            Console.Write($" moves left {steps} ,");
            Console.WriteLine($" health left {heath}");
        }

    }
}
