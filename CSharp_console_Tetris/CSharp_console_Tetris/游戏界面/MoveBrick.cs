using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_console_Tetris
{
    public class MoveBrick//搬砖工人
    {
        //当前方块的类型
        public BlockType brickType = BlockType.I;
        //当前方块的位置(中心位置)
        public Position positionCentre = new Position(14, 2);
        //当前方块的旋转状态
        public int rotation = 0;

        BasicBlock block = new BasicBlock(new Position(10, 5), BlockType.I); // 方块对象

        private Random random = new Random(); // 全局随机数生成器

        //获得随机方块
        public void GetRandomBrick()
        {
            brickType = (BlockType)new Random().Next(2, 8);//随机生成2-7的数字，代表方块的类型
            positionCentre = new Position(10, 5);
            rotation = random.Next(0, 4); // 随机生成0到3之间的数字，代表方块的初始旋转状态
        }

        //绘制方块
        public void DrawBrick()
        {
            for (int i = 0; i < 4; i++)//绘制方块的四个小方块
            {
                block.position = positionCentre + BlockDataStorage<Position>.GetData(brickType, rotation, i);
                block.type = brickType;
                block.Draw();

            }

        }
        //擦除方块
        public void EraseBrick()
        {
            for (int i = 0; i < 4; i++)//擦除方块的四个小方块
            {
                block.position = positionCentre + BlockDataStorage<Position>.GetData(brickType, rotation, i);
                block.type = brickType;
                block.Erase();
            }
        }

        public void MoveTheBrick(ConsoleKey keyDirection)
        {



            EraseBrick();
            switch (keyDirection) // 使用 key.Key 提取按键的值
            {
                case ConsoleKey.A: // 使用 ConsoleKey 枚举值进行判断

                    positionCentre += new Position(-2, 0); // 左移
                    if (CheckWallCollision())
                    {
                        positionCentre += new Position(2, 0); // 右移
                    }

                    break;

                case ConsoleKey.D: // 使用 ConsoleKey 枚举值进行判断

                    positionCentre += new Position(2, 0); // 右移
                    if (CheckWallCollision())
                    {
                        positionCentre += new Position(-2, 0); // 左移
                    }

                    break;
                case ConsoleKey.S: // 使用 ConsoleKey 枚举值进行判断
                    positionCentre += new Position(0, 1); // 下移
                    break;
                //否则
                default:
                    positionCentre += new Position(0, 1); // 下移
                    break;
            }
            DrawBrick();
        }
        //检测是否与左右红墙相撞
        public bool CheckWallCollision()
        {
            bool isCollision = false;
            for (int i = 0; i < 4; i++)
            {
                block.position = positionCentre + BlockDataStorage<Position>.GetData(brickType, rotation, i);
                if (block.position.x == 0)
                { isCollision = true; }
                else if (block.position.x == 28)
                { isCollision = true; }

            }

            return isCollision;

        }

    }




}
