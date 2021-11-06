using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Hero
    {
        private int x; //координаты героя
        
        private int y;
        
        private int xP;//координаты принцессы
        
        private int yP;
        
        private int health;//здоровье
        
        private int steps;//число ходов
        
        private bool endGame; //конец игры
        
        private string Message; //статус

        public Hero(int x, int y, int xP, int yP)
        { 
            this.x = x;
          
            this.y = y;
          
            this.xP = xP;
          
            this.yP = yP;
          
            health = 10;
          
            steps = 15; //поставила 15 а то победить мало  шансов
          
            endGame = false;
          
            Message = "start the game";
        }

        public int X
        {
            get
            {
                return x;
            }
        }
        public int XP
        {
            get
            {
                return xP;
            }
        }
        public int Y
        {
            get
            {
                return y;
            }
        }
        public int YP
        {
            get
            {
                return yP;
            }
        }
        public bool Endgame
        {
            set
            {
                endGame = value;
            }
            
            get
            {
                return endGame;
            }
        }

        public void Explode()
        {
            var rand = new Random();
            
            int bombPower = rand.Next(11);
            
            health -= bombPower;
           
            Message = "You are exploded! Power bobmb =  "+ bombPower.ToString();
           
            Console.ForegroundColor = ConsoleColor.Red;
            
            if (health <= 0)
                
                EndGame();

        }

        public void Step(char[,] arr, int n,int dx, int dy)
        {
            steps--;
           
            Message = "continue the game";
            
            Console.ForegroundColor = ConsoleColor.White;
           
            x = NewCoordinate(x,dx);
            
            y= NewCoordinate(y,dy);

           if (x == xP && y==yP)
            {
                
                Message = "You are winner!";
                
                Console.ForegroundColor = ConsoleColor.Green;
                
                EndGame();
                
                return;
            }

            if (steps == 0)
            { 
                EndGame();
              
                Message = "Step =0, End the game!";
              
                return;
            }
                        
            if (arr[x, y] == 'x')
            {
                Explode();
            }
        }

        public int NewCoordinate(int coordinate, int delta)
        {
            int temp = coordinate + delta;
            
            if (temp==-1 || temp==10)
            { 
                return coordinate; 
            }
            return temp;
        }

        public void EndGame()
        {
            steps=0;
           
            health = 0;
           
            endGame = true;
        }

        public void StartGame()
        {
            steps = 10;
            
            health = 10;
            
            endGame = false;
        }

        public void InfoPrint()
        {
            Console.Write(Message);
            
            Console.Write($" moves left {steps} ,");
            
            Console.WriteLine($" health left {health}");
        }
    }
}
