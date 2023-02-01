using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameObject.BL;

namespace GameObject.DL
{
    internal class GameObjectDL
    {
        public static List<GameObjects> objectList = new List<GameObjects>();

        public static void AddGameObject(GameObjects newObject)
        {
            objectList.Add( newObject );
        }
    }
}
