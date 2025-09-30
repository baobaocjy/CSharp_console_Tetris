using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_console_Tetris
{
   

    public class BasicBlock
    {
        public Position position; // 位置
        public BlockType type; // 类型

        //构造函数
        public BasicBlock(Position position, BlockType type)
        {
            this.position = position;
            this.type = type;
        }
        //绘制方法
        public void Draw()
        {
            if (position.y < 0)
            {
                return;
            }
            Console.SetCursorPosition(position.x, position.y);//设置光标位置
            //根据类型绘制不同颜色的方块
            switch (type)
            {
                case BlockType.RedWall:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("■");
                    break;
                case BlockType.FallingBlock:
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write("■");
                    break;
                case BlockType.I:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("■");
                    break;
                case BlockType.O:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("■");
                    break;
                case BlockType.Z:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("■");
                    break;
                case BlockType._Z:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("■");
                    break;
                case BlockType.J:
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("■");
                    break;
                case BlockType.L:
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.Write("■");
                    break;
                case BlockType.T:
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write("■");
                    break;
                default:
                    break;
            }

        }

        //擦除方法
        /// <summary>
        ///  擦除方法
        /// </summary>
        public void Erase()
        {
            if (position.y < 0)
            { 
                return;
            }
            Console.SetCursorPosition(position.x, position.y);
            Console.Write("  ");
        }

    }


    //位置结构体
    public struct Position
    {
        public int x;
        public int y;

        public Position(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        // 重写 Equals，确保 Contains 等方法正确判断
        public override bool Equals(object obj)
        {
            if (obj is Position other)
            {
                return x == other.x && y == other.y;
            }
            return false;
        }

        // 重写 GetHashCode，与 Equals 逻辑一致（用于哈希表等场景）
        public override int GetHashCode()
        {
            return HashCode.Combine(x, y); // 组合 x 和 y 的哈希值
        }

        // 已有的运算符重载（保持不变）
        public static bool operator ==(Position p1, Position p2) => p1.Equals(p2);
        public static bool operator !=(Position p1, Position p2) => !p1.Equals(p2);

        // 其他运算符和 ToString 保持不变...
        public override string ToString() => $"({x},{y})";
        public static Position operator +(Position p1, Position p2) => new Position(p1.x + p2.x, p1.y + p2.y);
        public static Position operator -(Position p1, Position p2) => new Position(p1.x - p2.x, p1.y - p2.y);
    }


    //方块类型枚举（红墙，沉积的方块，I, O, FZ, Z, J, L, T）
    public enum BlockType
    {
        RedWall,
        FallingBlock,
        I,
        O,
        _Z,
        Z,
        J,
        L,
        T
    }
}






