using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_console_Tetris
{
    public class DepositionSquare
    {
        BasicBlock block = new BasicBlock(new Position(0, 0), BlockType.FallingBlock);
      
        List<Position> positionList=new List<Position>(); // 初始化列表;

      

        // 添加方块位置
        public void AddPosition(MoveBrick moveBrick)
        {
            // 直接获取位置数组，无需冗余初始化
            Position[] positions = moveBrick.PrintPositions();
            positionList.AddRange(positions); // 安全调用（已初始化）
          
        }

        //绘制
        public void Draw()
        {
            // 先判断列表是否为空，避免误解
            if (positionList.Count == 0)
            {
                return;
            }

            // 方法1：foreach 循环（推荐，最简洁，无需关心索引）
            foreach (Position pos in positionList)
            {
                block.position=pos;
                block.Draw();
            }
        }

        //判断ship是否与方块重叠
        /// <summary>
        /// 判断ship是否与方块重叠
        /// </summary>
        /// <param name="moveBrick"></param>
        /// <returns></returns>
        public bool IsOverlap(MoveBrick moveBrick)
        {
            bool isOverlap = false;
           
            // 遍历位置数组
            foreach (Position pos in moveBrick.PrintPositions())
            {
                // 判断是否在列表中
                if (positionList.Contains(pos))
                {
                    isOverlap = true;
                    break;
                }
                if (pos.y == 19)
                {
                    isOverlap = true;
                    break;
                }
            }

          
            
            return isOverlap;
        }
    }
}
