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
        public BlockType brickType= BlockType.I;
        //当前方块的位置(中心位置)
        public Position positionCentre= new Position(10, 5);
        //当前方块的旋转状态
        public int rotation= 0;

        BasicBlock block= new BasicBlock(new Position(10, 5), BlockType.I); // 方块对象

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
            for (int i = 0; i <4 ; i++)//绘制方块的四个小方块
            {
                block.position = positionCentre+BlockDataStorage<Position>.GetData(brickType, rotation, i);
                block.type = brickType;
                block.Draw();

            }
          
        }
        //擦除方块
        public void EraseBrick()
        {
            for (int i = 0; i <4; i++)//擦除方块的四个小方块
            {
                block.position = positionCentre + BlockDataStorage<Position>.GetData(brickType, rotation, i);
                block.type = brickType;
                block.Erase();
            }
        }

    }
    



}
