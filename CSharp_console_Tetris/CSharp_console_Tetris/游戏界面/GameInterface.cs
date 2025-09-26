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
       

        //开始方法
        public void Start()
        {

            // Console.WriteLine(n++);
            DrawWall();//绘制墙
            //移动光标
            Console.SetCursorPosition(BlockDataStorage<Position>.GetData(BlockType.I, 0, 0).x, BlockDataStorage<Position>.GetData(BlockType.I, 0, 0).y);
            BasicBlock block = new BasicBlock (new Position(10, 5), BlockType.I);

            for (int i = 0; i < 3; i++)
            {

                block.position = BlockDataStorage<Position>.GetData(BlockType.I, 0, 2) + new Position(2, 2);
                block.Draw();
                Console.Write("BlockDataStorage<Position>.GetData(BlockType.I, 0, 0).x");
                
            }
            
            //显示游戏标题

        }

        //绘制不变的红墙
        public void DrawWall()
        {
            BasicBlock RedWall =  new BasicBlock(new Position(0, 0), BlockType.RedWall);
            for (int i = 0; i < 20; i++)
            {
                RedWall.position=new Position(0, i);
                RedWall.Draw();
            }
            for (int i = 0; i < 20; i++)
            {
                RedWall.position = new Position(28, i);
                RedWall.Draw();
            }
            for (int i = 0; i < 28; i+=2)
            {
                RedWall.position = new Position(i, 19);
                RedWall.Draw();
            }
           
           
        }
    }
}
