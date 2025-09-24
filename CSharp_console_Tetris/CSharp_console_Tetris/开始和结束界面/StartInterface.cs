using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_console_Tetris
{
    internal class StartInterface
    {
        //开始方法
        public void Start()
        {
            Console.WriteLine("游戏开始界面");
            Game.e_GameScene=E_GameScene.E_End;
        }
    }
}
