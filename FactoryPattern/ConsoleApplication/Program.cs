using FactoryPattern.Monster;
using FactoryPattern.Player;
using System;
using System.Collections.Generic;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Original
            //Player myPlayer = new Player(10, 0, 50);
            #endregion

            #region First factory example
            //Player myPlayer = Player.CreateNewPlayer(10, 0, 50);
            #endregion

            #region Second factory example
            //Player myPlayer = PlayerFactory.LoadPlayer();
            #endregion

            #region Third factory example
            //Player myPlayer = PlayerFactory.LoadPlayer();
            #endregion

            #region Forth factory example
            Monster monster;
            for (int i = 0; i < 20; i++)
            {
                monster = MonsterFactory.GetRandomMonster();
                Console.WriteLine(monster.ToString());

            }
            #endregion

            Console.ReadLine();
        }
    }
}
