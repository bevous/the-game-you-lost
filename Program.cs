using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orbiter1
{
    struct position
        {
            public double playerX;
            public double playerY;
        }
    struct planetLocation
    {
        public double planetX;
        public double planetY;
    }
    class Window
    {
        private 
            int height=500;
            int width = 500;

        public
            void OpenWindow()
        {

        }
            void DrawElements()
        {

        }


    }
    class Planet
    {
        private double radius = 20.0;
        private planetLocation earth;
        public planetLocation WhereIsIt()
        {
            return earth;
        }
        public bool Collision()
        {
            bool crashed = false;


            return crashed;
        }
        public void Draw()
        {



        }

    }
    class player
    {
        private Planet home;//main orbiting body
        private position player1;//player location
        private bool playerStat;// true is alive false is dead
        public

            double speed = 0.0;
            bool compare(planetLocation home ,position player1 )
        {
            bool equal = false;

            if (home.planetX == player1.playerX && home.planetY == player1.playerY)
            {
                equal = true;
            }

            return equal;
        }
            position playerPos()
            {
                position playerlocation;
                playerlocation.playerX = 0;//this will be equal to where in the windo the player is located
                playerlocation.playerY = 0;
                return playerlocation;
            }
            bool Alive()
        {
            bool isAlive = true;
            if (Collision())
            {
                isAlive = false;
            }

            return isAlive;
        }
            bool Collision()
        {
            bool crashed = false;
            // need to add detection of other players
            if (compare(home.WhereIsIt(), player1 ))
            {
                crashed = true;
            }

            return crashed;
        }
            void Draw()
        {

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            //need a class for the player
                //collision detection
                //speed 
                //direction
            //class for planets
                //collision detection
                //needs to have gravity


        }
    }
}
