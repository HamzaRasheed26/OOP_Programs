using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameObject.BL;
using GameObject.DL;

namespace GameObject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[,] triangle = new char[5, 3] { { '@', ' ', ' ' },
                                                { '@', '@', ' ' },
                                                { '@', '@', '@' },
                                                { '@', '@', ' ' },
                                                { '@', ' ', ' ' } };

            Boundary b = new Boundary();
            GameObjects ob = new GameObjects(triangle, new Point(30, 10), b, "Projectile");

            char[,] triangle2 = new char[5, 3] {{ ' ', ' ', '*' },
                                                { ' ', '*', '*' },
                                                { '*', '*', '*' },
                                                { ' ', '*', '*' },
                                                { ' ', ' ', '*' } };

            Boundary b2 = new Boundary();
            GameObjects ob2 = new GameObjects(triangle2, new Point(6, 6), b2, "Projectile");



            GameObjectDL.AddGameObject(ob);
            GameObjectDL.AddGameObject(ob2);

            while(true)
            {

                foreach (GameObjects o in GameObjectDL.objectList)
                {
                    System.Threading.Thread.Sleep(200);

                    o.Erase();
                    o.Move();
                    o.Draw();
                }
            }

        }
    }
}
