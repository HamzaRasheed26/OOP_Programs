using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameObject.BL
{
    internal class GameObjects
    {
        private char[,] shape ;
        private Point startingPoint;
        private Boundary premises;
        private string direction;
        private int flag = 1;

        public GameObjects()
        {
            shape = new char[3, 2] { { '@', '@' }, { '@', '@' }, { '@', '@' } };
            startingPoint = new Point();
            premises = new Boundary();
            direction = "LeftToRight";
        }

        public GameObjects(char[,] shape, Point startingPoint, Boundary premises, string direction)
        {
            this.shape = shape;
            this.startingPoint = startingPoint;
            this.premises = premises;
            this.direction = direction;
        }

        public char[,] getShape()
        {
            return shape;
        }
        public Point getStartingPoint()
        {
            return startingPoint;
        }
        public Boundary getPermises()
        {
            return premises;
        }
        public string getDirection()
        {
            return direction;
        }

        public bool MoveLeftToRight()
        {
            Point bottomRight = premises.getBottomRight();

            if (startingPoint.getX() < bottomRight.getX())
            {
                int x = startingPoint.getX();
                x++;
                startingPoint.setX(x);
                return true;
            }
            return false;
        }

        public bool MoveRightToLeft()
        {
            Point topLeft = premises.getTopLeft();

            if (startingPoint.getX() > topLeft.getX())
            {
                int x = startingPoint.getX();
                x--;
                startingPoint.setX(x);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Patroling()
        {
            if ( flag == 1 && MoveRightToLeft() )
            {
                return true;
            }
            else
            {
                flag = 0;
            }

            if(flag == 0 && MoveLeftToRight() )
            {
                return true;
            }
            else
            {
                flag = 1;
            }

            return false;

        }

        public bool projectileMotion()
        {
            if(flag <= 5)
            {
                int x = startingPoint.getX();
                int y = startingPoint.getY();
                if (x < premises.getBottomLeft().getX() && y > premises.getBottomLeft().getY())
                {                    
                    x++;
                    startingPoint.setX(x);                   
                    y--;
                    startingPoint.setY(y);
                }

                flag++;
                return true;
            }
            else if (flag <= 7)
            {
                MoveLeftToRight();

                flag++;
                return true;
            }
            else if(flag <= 12)
            {
                MoveDiagonal();

                flag++;
                return true;
            }
            else
            {
                flag = 0;
            }
            return false;
        }

        public void MoveDiagonal()
        {
            Point bottomRight = premises.getBottomRight();

            if (startingPoint.getX() < bottomRight.getX() && startingPoint.getY() < bottomRight.getY())
            {
                int x = startingPoint.getX();
                x++;
                startingPoint.setX(x);

                int y = startingPoint.getY();
                y++;
                startingPoint.setY(y);
            }
        }

        public bool Move()
        {
            if(direction == "LeftToRight")
            {
               return MoveLeftToRight();
            }
            else if (direction == "RightToLeft")
            {
                return MoveRightToLeft();
            }
            else if(direction == "Patrol" || direction == "patrol")
            {
                return Patroling();
            }
            else if(direction == "Projectile" || direction == "projectile")
            {
                return projectileMotion();
            }
            else if(direction == "Diagonal" || direction == "diagonal")
            {
                MoveDiagonal();
            }
            return true;
        }

        public void Draw()
        {
            int x = startingPoint.getX();
            int y = startingPoint.getY();

            for (int i = 0; i < 5; i++)
            {
                Console.SetCursorPosition(x, y + i);
                for (int u = 0; u < 3; u++)
                {
                    Console.Write(shape[i, u]);
                }
            }
        }        

        public void Erase()
        {
            int x = startingPoint.getX();
            int y = startingPoint.getY();
            for(int i=0; i< 5; i++)
            {
                Console.SetCursorPosition(x, y + i);
                for (int u=0; u < 3; u++)
                {
                    Console.Write(" ");
                }
            }     
        }

    }
}
