using System;
using System.Collections.Generic;
using System.Text;

namespace GruppInlUpp2kelett
{
    class ConsoleRenderer
    {
        private GameWorld world = new GameWorld();

        public ConsoleRenderer(GameWorld gameWorld)
        {
            // TODO Konfigurera Console-fönstret enligt världens storlek
            // med hjälp av Console.SetWindowSize(int, int)
            Console.Title = "Snake | Gruppuppgift";
            Console.SetWindowSize(50, 20);
            Console.SetBufferSize(50, 20);
            Console.CursorVisible = (false);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;

            world = gameWorld;

            world.listObj.Add(new Position(GameObject.pos.X, GameObject.pos.Y));
        }


        public bool Render()
        {
            Console.Clear();

            world.listObj.Clear();
            world.listObj.Add(new Position(GameObject.pos.X, GameObject.pos.Y));


            try
            {
                Console.SetCursorPosition(GameObject.pos.X, GameObject.pos.Y);
            }
            catch
            {
                return false;
            }


            for (int i = 0; i < world.listObj.Count(); i++)
            {
                Console.SetCursorPosition(world.listObj[i].X, world.listObj[i].Y);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("■");
                Console.SetCursorPosition(0, 0);
            }
            return true;
        }

    }
}
