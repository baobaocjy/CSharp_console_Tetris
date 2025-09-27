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

        //构造函数
        public GameInterface()
        {
            // 调用静态方法触发BrickInformation的静态构造函数
            BrickInformation.Initialize();
        }
        //开始方法
        public void Start()
        { 
            while (true)
            {
                DrawWall();//绘制墙
                moveBrick.GetRandomBrick();
                moveBrick.DrawBrick();
                Console.ReadKey();

                moveBrick.EraseBrick();
            }
           




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
    }
}
