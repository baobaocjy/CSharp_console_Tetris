using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CSharp_console_Tetris.BasicBlock;
using System.Collections.Generic;

namespace CSharp_console_Tetris
{
    public class GameInterface
    {
        int n = 0;
        MoveBrick moveBrick = new MoveBrick();
        ConsoleKey keyDirection = ConsoleKey.S;
        //是否延迟变量
        bool isDelay = false;


        //构造函数
        public GameInterface()
        {
            // 调用静态方法触发BrickInformation的静态构造函数
            BrickInformation.Initialize();

        }
        //开始方法
        public void Start()
        {
            moveBrick.GetRandomBrick();
            DrawWall();//绘制墙

            
            //开启第二线程
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(thread2));
            t.Start();
            
           
            while (true)
            {
                moveBrick.DrawBrick();

                
                System.Threading.Thread.Sleep(1000);

                moveBrick.MoveTheBrick(keyDirection);
               
            }
           
            //结束第二线程
            t.Abort();

        }

        //绘制不变的红墙
        public void DrawWall()
        {
            BasicBlock RedWall = new BasicBlock(new Position(0, 0), BlockType.RedWall);
            for (int i = 0; i < 20; i++)
            {
                RedWall.position = new Position(0, i);
                RedWall.Draw();
            }
            for (int i = 0; i < 20; i++)
            {
                RedWall.position = new Position(28, i);
                RedWall.Draw();
            }
            for (int i = 0; i < 28; i += 2)
            {
                RedWall.position = new Position(i, 19);
                RedWall.Draw();
            }


        }

        //新线程逻辑
        public void thread2()
        {
            while (true)
            {  //赋值给key1
                keyDirection = Console.ReadKey(true).Key;//获取键盘输入
                Console.SetCursorPosition(16, 3);
                Console.Write(keyDirection);

            }
        }
    }
}
