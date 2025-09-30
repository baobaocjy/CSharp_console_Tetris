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
        DepositionSquare depositionSquare = new DepositionSquare();//实例化一个沉积方块的类




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
            moveBrick.DrawBrick();
            DrawWall();//绘制墙
            ConsoleKey keyDirection = ConsoleKey.S;

            //开启第二线程
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(thread2));
            t.Start();


            while (true)
            {
                moveBrick.MoveTheBrick(ConsoleKey.S);
                if (depositionSquare.IsOverlap(moveBrick)) //判断是否与方块重叠
                {
                    moveBrick.MoveUp(keyDirection);
                    depositionSquare.AddPosition(moveBrick);
                    depositionSquare.Draw();
                    moveBrick.GetRandomBrick();
                }
                moveBrick.DrawBrick();

                System.Threading.Thread.Sleep(1500);
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
            ConsoleKey keyDirection;
            while (true)
            {
                keyDirection = Console.ReadKey(true).Key;


                if (keyDirection == ConsoleKey.E)
                {
                    moveBrick.EraseBrick();
                    moveBrick.GetRandomBrick();


                }

                //判断是否是空格键
                if (keyDirection == ConsoleKey.Spacebar)
                {

                    moveBrick.EraseBrick();
                    if (moveBrick.rotation == 3)
                    {
                        moveBrick.rotation = 0;
                    }
                    else
                    {
                        moveBrick.rotation++;
                    }


                    if (moveBrick.CheckWallCollision())//判断是否与墙碰撞
                    {
                        if (moveBrick.rotation == 0)
                        {
                            moveBrick.rotation = 3;
                        }
                        else
                        {
                            moveBrick.rotation--;
                        }
                    }

                    if (depositionSquare.IsOverlap(moveBrick)) //判断是否与方块重叠
                    {
                        if (moveBrick.rotation == 0)
                        {
                            moveBrick.rotation = 3;
                        }
                        else
                        {
                            moveBrick.rotation--;
                        }
                    }

                    moveBrick.DrawBrick();
                }
                else
                {

                    if (keyDirection == ConsoleKey.S)
                    {

                        moveBrick.MoveTheBrick(keyDirection);//移动方块
                        if (depositionSquare.IsOverlap(moveBrick)) //判断是否与方块重叠
                        {
                            moveBrick.MoveUp(keyDirection);
                            depositionSquare.AddPosition(moveBrick);
                            depositionSquare.Draw();
                            moveBrick.GetRandomBrick();
                        }
                    }
                    else
                    {
                        moveBrick.MoveTheBrick(keyDirection);//移动方块
                        if (depositionSquare.IsOverlap(moveBrick)) //判断是否与方块重叠
                        {
                            moveBrick.MoveUp(keyDirection);
                        }
                    }



                    moveBrick.DrawBrick();
                    // 2. 线程阻塞500ms（期间的按键会进入缓冲区，需要被丢弃）
                    System.Threading.Thread.Sleep(50);
                    // 3. 清空Sleep期间积累的无效按键
                }
                ////检测是否与墙碰撞
                //if (moveBrick.CheckWallCollision() == "left")
                //{
                //    moveBrick.MoveTheBrick(ConsoleKey.D);

                //}
                //else if (moveBrick.CheckWallCollision() == "right")
                //{
                //    moveBrick.MoveTheBrick(ConsoleKey.A);
                //}





                while (Console.KeyAvailable)
                {
                    Console.ReadKey(true); // 读取并丢弃缓冲区中的按键
                }



            }



        }
    }
}
