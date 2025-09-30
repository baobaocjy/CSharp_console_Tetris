using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_console_Tetris
{
    public enum E_GameScene
    {
        //游戏开始
        /// <summary>
        /// 游戏开始
        /// </summary>
        E_Start,
        //游戏进行中
        /// <summary>
        /// 游戏进行中
        /// </summary>
        E_Playing,
        //游戏结束
        /// <summary>
        /// 游戏结束
        /// </summary>
        E_End,
        //退出游戏
        /// <summary>
        /// 退出游戏
        /// </summary>
        E_Exit

    }
    public class Game
    {

        //声明场景枚举变量
        public static E_GameScene e_GameScene = E_GameScene.E_Playing;
        //场景宽度
        public static int sceneWidth = 30;
        //场景高度
        public static int sceneHeight = 20;

        //构造函数
        /// <summary>
        /// 构造函数
        /// </summary>
        public Game()
        {
            InitConsole();//初始化控制台
            


        }

        //主循环函数
        /// <summary>
        /// 主循环函数
        /// </summary>
        public void MainLoop()
        {
            StartInterface startInterface = new StartInterface();
            GameInterface gameInterface = new GameInterface();
            EndInterface endInterface = new EndInterface();

            while (true)
            {
                switch(e_GameScene)
                {
                    case E_GameScene.E_Start:
                        //游戏开始
                        startInterface.Update();
                        break;
                    case E_GameScene.E_Playing:
                        //游戏进行中
                        gameInterface.Start();
                        break;
                    case E_GameScene.E_End:
                        //游戏结束
                        endInterface.Update();
                        break;
                    case E_GameScene.E_Exit://退出游戏
                        //关闭游戏
                        Environment.Exit(0);
                        break;
                }
                
            }
        }


        //初始化控制台
        /// <summary>
        /// 初始化控制台
        /// </summary>
        public void InitConsole()
        {
            Console.CursorVisible = false;
            Console.WindowWidth = sceneWidth;
            Console.WindowHeight = sceneHeight;
            Console.BufferWidth = sceneWidth;
            Console.BufferHeight = sceneHeight;
            Console.Title = "Tetris";
        }



       
      


    }
}
