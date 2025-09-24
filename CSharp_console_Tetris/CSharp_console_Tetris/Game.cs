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
        public static E_GameScene e_GameScene = E_GameScene.E_Start;
        //场景宽度
        public int sceneWidth = 30;
        //场景高度
        public int sceneHeight = 20;

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
            

            while (true)
            {
                SwitchScene(e_GameScene);
                Console.ReadKey();
                

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



        //场景切换函数
        /// <summary>
        /// 场景切换函数
        /// </summary>
        /// <param name="e_GameScene">游戏场景</param>
        public static void SwitchScene(E_GameScene e_GameScene)
        {
            switch (e_GameScene)
            {
                case E_GameScene.E_Start:
                    //游戏开始
                    StartInterface startInterface = new StartInterface();
                    startInterface.Start();
                    break;
                case E_GameScene.E_Playing:
                    //游戏进行中
                    GameInterface gameInterface = new GameInterface();
                    gameInterface.Start();
                    break;
                case E_GameScene.E_End:
                    //游戏结束
                    EndInterface endInterface = new EndInterface();
                    endInterface.Start();
                    break;
                case E_GameScene.E_Exit:
                    //退出游戏
                  
                    break;
            }
        }


    }
}
