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
            Console.SetCursorPosition(position.x, position.y);//设置光标位置
            //根据类型绘制不同颜色的方块
            switch (type)
            {
                case BlockType.RedWall:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("■");
                    break;
                case BlockType.FallingBlock:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
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
            Console.SetCursorPosition(position.x, position.y);
            Console.Write("  ");
        }

    }


    //位置结构体
    public struct Position
    {
        public int x;
        public int y;

        //构造函数
        public Position(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        // 关键：重写ToString()方法，返回"（X,Y）"格式的字符串
        public override string ToString()
        {
            return $"({x},{y})";
        }

        // 重载==运算符，用于比较两个Position对象是否在x和y坐标上都相等
        public static bool operator ==(Position p1, Position p2)
        {
            return p1.x == p2.x && p1.y == p2.y; // 如果p1的x坐标等于p2的x坐标且p1的y坐标等于p2的y坐标，则返回true
        }

        // 重载!=运算符，用于比较两个Position对象是否在x和y坐标上不完全相等
        public static bool operator !=(Position p1, Position p2)
        {
            return p1.x != p2.x || p1.y != p2.y; // 如果p1的x坐标不等于p2的x坐标或p1的y坐标不等于p2的y坐标，则返回true
        }

        //重载+运算符，用于两个Position对象相加
        public static Position operator +(Position p1, Position p2)
        {
            return new Position(p1.x + p2.x, p1.y + p2.y); // 返回两个Position对象相加后的新Position对象
        }
        //重载-运算符，用于两个Position对象相减
        public static Position operator -(Position p1, Position p2)
        {
            return new Position(p1.x - p2.x, p1.y - p2.y); // 返回两个Position对象相减后的新Position对象
        }


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






