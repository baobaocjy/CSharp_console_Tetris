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

        //清除
        public void Clear()
        {
            // 方法1：foreach 循环（推荐，最简洁，无需关心索引）
            foreach (Position pos in positionList)
            {
                block.position = pos;
                block.Erase();
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

        //清空行
        /// <summary>
        /// 清空行
        /// </summary>
        public void ClearLine()
        {
            // 从下往上遍历行（i从18到0），避免多行清除时的顺序冲突
            for (int j = 19; j >= 0; j--)
            {
                // 收集当前行需要检查的所有位置（j=2,4,...,24，因为j<26且j+=2，最后一个是24）
                List<Position> linePositions = new List<Position>();
                for (int i = 2; i < 28; i += 2)
                {
                    linePositions.Add(new Position(i, j));
                }

                // 检查当前行是否填满
                bool isLineFull = linePositions.All(pos => positionList.Contains(pos));// 调用All方法，返回布尔值

                if (isLineFull)
                {
                    //擦除原列表
                    Clear();
                    // 1. 清除当前满行的所有元素
                    positionList.RemoveAll(pos => linePositions.Contains(pos));

                    // 2. 将当前行上方（x < i）的所有元素下移一行（x坐标+1）
                    // 由于Position是结构体（值类型），需要先收集旧元素，再替换为新元素
                    List<Position> newPositions = new List<Position>();
                    foreach (var pos in positionList)
                    {
                        // 如果元素在当前行上方（x < i），则下移一行（x+1）
                        if (pos.y < j)
                        {
                            newPositions.Add(new Position(pos.x , pos.y+1));
                        }
                        else
                        {
                            // 不在上方的元素保持不变
                            newPositions.Add(pos);
                        }
                    }
                   
                   

                    // 用下移后的新列表替换原列表
                    positionList = newPositions;
                    //绘制新列表
                    Draw();

                   
                }
            }

            //检查第0行是否有元素
            List<Position> line0 = new List<Position>();
            for (int i = 2; i < 28; i += 2)
            {
                line0.Add(new Position(i, 0));
            }
            bool hasIntersection = line0.Any(pos => positionList.Contains(pos));
            if (hasIntersection)
            {
                Game.e_GameScene = E_GameScene.E_End;

            }
        }

        /// <summary>
        /// 清理全部元素
        /// </summary>
        /// <returns></returns>
        public void ClearAll()
        {
            // 调用 List 的 Clear() 方法，移除所有元素
            positionList.Clear();
        }
        
    }
}
