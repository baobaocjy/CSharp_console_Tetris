using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_console_Tetris
{
    public class BrickInformation
    {
        // 新增：用于触发静态构造函数的静态方法
        public static void Initialize() { }


        #region 构造函数储存方块信息
        static BrickInformation()
        {
            // -------------------------- I型方块 --------------------------
            BlockDataStorage<Position>.SetData(BlockType.I, 0, 0, new Position(-4, 0));
            BlockDataStorage<Position>.SetData(BlockType.I, 0, 1, new Position(-2, 0));
            BlockDataStorage<Position>.SetData(BlockType.I, 0, 2, new Position(0, 0));
            BlockDataStorage<Position>.SetData(BlockType.I, 0, 3, new Position(2, 0));

            BlockDataStorage<Position>.SetData(BlockType.I, 1, 0, new Position(0, -1));
            BlockDataStorage<Position>.SetData(BlockType.I, 1, 1, new Position(0, 0));
            BlockDataStorage<Position>.SetData(BlockType.I, 1, 2, new Position(0, 1));
            BlockDataStorage<Position>.SetData(BlockType.I, 1, 3, new Position(0, 2));

            BlockDataStorage<Position>.SetData(BlockType.I, 2, 0, new Position(-4, 0));
            BlockDataStorage<Position>.SetData(BlockType.I, 2, 1, new Position(-2, 0));
            BlockDataStorage<Position>.SetData(BlockType.I, 2, 2, new Position(0, 0));
            BlockDataStorage<Position>.SetData(BlockType.I, 2, 3, new Position(2, 0));

            BlockDataStorage<Position>.SetData(BlockType.I, 3, 0, new Position(0, -1));
            BlockDataStorage<Position>.SetData(BlockType.I, 3, 1, new Position(0, 0));
            BlockDataStorage<Position>.SetData(BlockType.I, 3, 2, new Position(0, 1));
            BlockDataStorage<Position>.SetData(BlockType.I, 3, 3, new Position(0, 2));

            // -------------------------- O型方块 --------------------------
            BlockDataStorage<Position>.SetData(BlockType.O, 0, 0, new Position(-2, 0));
            BlockDataStorage<Position>.SetData(BlockType.O, 0, 1, new Position(0, 0));
            BlockDataStorage<Position>.SetData(BlockType.O, 0, 2, new Position(-2, 1));
            BlockDataStorage<Position>.SetData(BlockType.O, 0, 3, new Position(0, 1));

            BlockDataStorage<Position>.SetData(BlockType.O, 1, 0, new Position(-2, 0));
            BlockDataStorage<Position>.SetData(BlockType.O, 1, 1, new Position(0, 0));
            BlockDataStorage<Position>.SetData(BlockType.O, 1, 2, new Position(-2, 1));
            BlockDataStorage<Position>.SetData(BlockType.O, 1, 3, new Position(0, 1));

            BlockDataStorage<Position>.SetData(BlockType.O, 2, 0, new Position(-2, 0));
            BlockDataStorage<Position>.SetData(BlockType.O, 2, 1, new Position(0, 0));
            BlockDataStorage<Position>.SetData(BlockType.O, 2, 2, new Position(-2, 1));
            BlockDataStorage<Position>.SetData(BlockType.O, 2, 3, new Position(0, 1));

            BlockDataStorage<Position>.SetData(BlockType.O, 3, 0, new Position(-2, 0));
            BlockDataStorage<Position>.SetData(BlockType.O, 3, 1, new Position(0, 0));
            BlockDataStorage<Position>.SetData(BlockType.O, 3, 2, new Position(-2, 1));
            BlockDataStorage<Position>.SetData(BlockType.O, 3, 3, new Position(0, 1));

            // -------------------------- _Z型方块 --------------------------
            BlockDataStorage<Position>.SetData(BlockType._Z, 0, 0, new Position(0, 0));
            BlockDataStorage<Position>.SetData(BlockType._Z, 0, 1, new Position(2, 0));
            BlockDataStorage<Position>.SetData(BlockType._Z, 0, 2, new Position(-2, 1));
            BlockDataStorage<Position>.SetData(BlockType._Z, 0, 3, new Position(0, 1));

            BlockDataStorage<Position>.SetData(BlockType._Z, 1, 0, new Position(0, -1));
            BlockDataStorage<Position>.SetData(BlockType._Z, 1, 1, new Position(0, 0));
            BlockDataStorage<Position>.SetData(BlockType._Z, 1, 2, new Position(2, 0));
            BlockDataStorage<Position>.SetData(BlockType._Z, 1, 3, new Position(2, 1));

            BlockDataStorage<Position>.SetData(BlockType._Z, 2, 0, new Position(0, 0));
            BlockDataStorage<Position>.SetData(BlockType._Z, 2, 1, new Position(2, 0));
            BlockDataStorage<Position>.SetData(BlockType._Z, 2, 2, new Position(-2, 1));
            BlockDataStorage<Position>.SetData(BlockType._Z, 2, 3, new Position(0, 1));

            BlockDataStorage<Position>.SetData(BlockType._Z, 3, 0, new Position(0, -1));
            BlockDataStorage<Position>.SetData(BlockType._Z, 3, 1, new Position(0, 0));
            BlockDataStorage<Position>.SetData(BlockType._Z, 3, 2, new Position(2, 0));
            BlockDataStorage<Position>.SetData(BlockType._Z, 3, 3, new Position(2, 1));

            // -------------------------- Z型方块 --------------------------
            BlockDataStorage<Position>.SetData(BlockType.Z, 0, 0, new Position(-2, 0));
            BlockDataStorage<Position>.SetData(BlockType.Z, 0, 1, new Position(0, 0));
            BlockDataStorage<Position>.SetData(BlockType.Z, 0, 2, new Position(0, 1));
            BlockDataStorage<Position>.SetData(BlockType.Z, 0, 3, new Position(2, 1));

            BlockDataStorage<Position>.SetData(BlockType.Z, 1, 0, new Position(2, -1));
            BlockDataStorage<Position>.SetData(BlockType.Z, 1, 1, new Position(0, 0));
            BlockDataStorage<Position>.SetData(BlockType.Z, 1, 2, new Position(2, 0));
            BlockDataStorage<Position>.SetData(BlockType.Z, 1, 3, new Position(0, 1));

            BlockDataStorage<Position>.SetData(BlockType.Z, 2, 0, new Position(-2, 0));
            BlockDataStorage<Position>.SetData(BlockType.Z, 2, 1, new Position(0, 0));
            BlockDataStorage<Position>.SetData(BlockType.Z, 2, 2, new Position(0, 1));
            BlockDataStorage<Position>.SetData(BlockType.Z, 2, 3, new Position(2, 1));

            // 修复原代码中可能的格式问题（逗号后加空格，避免语法误解）
            BlockDataStorage<Position>.SetData(BlockType.Z, 3, 0, new Position(2, -1));
            BlockDataStorage<Position>.SetData(BlockType.Z, 3, 1, new Position(0, 0));
            BlockDataStorage<Position>.SetData(BlockType.Z, 3, 2, new Position(2, 0));
            BlockDataStorage<Position>.SetData(BlockType.Z, 3, 3, new Position(0, 1));

            // -------------------------- J型方块 --------------------------
            BlockDataStorage<Position>.SetData(BlockType.J, 0, 0, new Position(-2, 0));
            BlockDataStorage<Position>.SetData(BlockType.J, 0, 1, new Position(0, 0));
            BlockDataStorage<Position>.SetData(BlockType.J, 0, 2, new Position(2, 0));
            BlockDataStorage<Position>.SetData(BlockType.J, 0, 3, new Position(2, 1));

            BlockDataStorage<Position>.SetData(BlockType.J, 1, 0, new Position(0, -1));
            BlockDataStorage<Position>.SetData(BlockType.J, 1, 1, new Position(2, -1));
            BlockDataStorage<Position>.SetData(BlockType.J, 1, 2, new Position(0, 0));
            BlockDataStorage<Position>.SetData(BlockType.J, 1, 3, new Position(0, 1));

            BlockDataStorage<Position>.SetData(BlockType.J, 2, 0, new Position(-2, -1));
            BlockDataStorage<Position>.SetData(BlockType.J, 2, 1, new Position(-2, 0));
            BlockDataStorage<Position>.SetData(BlockType.J, 2, 2, new Position(0, 0));
            BlockDataStorage<Position>.SetData(BlockType.J, 2, 3, new Position(2, 0));

          
            BlockDataStorage<Position>.SetData(BlockType.J, 3, 0, new Position(0, -1));
            BlockDataStorage<Position>.SetData(BlockType.J, 3, 1, new Position(0, 0));
            BlockDataStorage<Position>.SetData(BlockType.J, 3, 2, new Position(-2, 1));
            BlockDataStorage<Position>.SetData(BlockType.J, 3, 3, new Position(0, 1));

            // -------------------------- L型方块 --------------------------
            BlockDataStorage<Position>.SetData(BlockType.L, 0, 0, new Position(-2, 0));
            BlockDataStorage<Position>.SetData(BlockType.L, 0, 1, new Position(0, 0));
            BlockDataStorage<Position>.SetData(BlockType.L, 0, 2, new Position(2, 0));
            BlockDataStorage<Position>.SetData(BlockType.L, 0, 3, new Position(-2, 1));

            BlockDataStorage<Position>.SetData(BlockType.L, 1, 0, new Position(0, -1));
            BlockDataStorage<Position>.SetData(BlockType.L, 1, 1, new Position(0, 0));
            BlockDataStorage<Position>.SetData(BlockType.L, 1, 2, new Position(0, 1));
            BlockDataStorage<Position>.SetData(BlockType.L, 1, 3, new Position(2, 1));

            BlockDataStorage<Position>.SetData(BlockType.L, 2, 0, new Position(-2, 0));
            BlockDataStorage<Position>.SetData(BlockType.L, 2, 1, new Position(0, 0));
            BlockDataStorage<Position>.SetData(BlockType.L, 2, 2, new Position(2, 0));
            BlockDataStorage<Position>.SetData(BlockType.L, 2, 3, new Position(2, -1));

            BlockDataStorage<Position>.SetData(BlockType.L, 3, 0, new Position(-2, -1));
            BlockDataStorage<Position>.SetData(BlockType.L, 3, 1, new Position(0, -1));
            BlockDataStorage<Position>.SetData(BlockType.L, 3, 2, new Position(0, 0));
            BlockDataStorage<Position>.SetData(BlockType.L, 3, 3, new Position(0, 1));

            // -------------------------- T型方块 --------------------------
            BlockDataStorage<Position>.SetData(BlockType.T, 0, 0, new Position(-2, 0));
            BlockDataStorage<Position>.SetData(BlockType.T, 0, 1, new Position(0, 0));
            BlockDataStorage<Position>.SetData(BlockType.T, 0, 2, new Position(2, 0));
            BlockDataStorage<Position>.SetData(BlockType.T, 0, 3, new Position(0, 1));

            BlockDataStorage<Position>.SetData(BlockType.T, 1, 0, new Position(0, -1));
            BlockDataStorage<Position>.SetData(BlockType.T, 1, 1, new Position(0, 0));
            BlockDataStorage<Position>.SetData(BlockType.T, 1, 2, new Position(2, 0));
            BlockDataStorage<Position>.SetData(BlockType.T, 1, 3, new Position(0, 1));

            BlockDataStorage<Position>.SetData(BlockType.T, 2, 0, new Position(0, -1));
            BlockDataStorage<Position>.SetData(BlockType.T, 2, 1, new Position(-2, 0));
            BlockDataStorage<Position>.SetData(BlockType.T, 2, 2, new Position(0, 0));
            BlockDataStorage<Position>.SetData(BlockType.T, 2, 3, new Position(2, 0));

            BlockDataStorage<Position>.SetData(BlockType.T, 3, 0, new Position(0, -1));
            BlockDataStorage<Position>.SetData(BlockType.T, 3, 1, new Position(-2, 0));
            BlockDataStorage<Position>.SetData(BlockType.T, 3, 2, new Position(0, 0));
            BlockDataStorage<Position>.SetData(BlockType.T, 3, 3, new Position(0, 1));
        }
        #endregion
    }

    #region  数据存储结构（无需修改，保持原逻辑）
    public static class BlockDataStorage<T>
    {
        private static readonly Dictionary<BlockType, BigGroup<T>> bigGroups;

        static BlockDataStorage()
        {
            bigGroups = new Dictionary<BlockType, BigGroup<T>>();
            foreach (BlockType blockType in Enum.GetValues<BlockType>())
            {
                bigGroups[blockType] = new BigGroup<T>();
            }
        }

        public static T GetData(BlockType blockType, int groupIndex, int dataIndex)
        {
            ValidateIndices(groupIndex, dataIndex);
            return bigGroups[blockType].Groups[groupIndex].Data[dataIndex];
        }

        public static void SetData(BlockType blockType, int groupIndex, int dataIndex, T value)
        {
            ValidateIndices(groupIndex, dataIndex);
            bigGroups[blockType].Groups[groupIndex].Data[dataIndex] = value;
        }

        public static BigGroup<T> GetBigGroup(BlockType blockType) => bigGroups[blockType];

        public static Group<T> GetGroup(BlockType blockType, int groupIndex)
        {
            if (groupIndex < 0 || groupIndex >= 4)
                throw new ArgumentOutOfRangeException(nameof(groupIndex), "小组索引必须在0-3之间");
            return bigGroups[blockType].Groups[groupIndex];
        }

        public static IEnumerable<BlockType> GetAllBlockTypes() => bigGroups.Keys;

        private static void ValidateIndices(int groupIndex, int dataIndex)
        {
            if (groupIndex < 0 || groupIndex >= 4)
                throw new ArgumentOutOfRangeException(nameof(groupIndex), "小组索引必须在0-3之间");
            if (dataIndex < 0 || dataIndex >= 4)
                throw new ArgumentOutOfRangeException(nameof(dataIndex), "数据索引必须在0-3之间");
        }
    }

    public class BigGroup<T>
    {
        public List<Group<T>> Groups { get; private set; }
        public BigGroup()
        {
            Groups = new List<Group<T>>(4);
            for (int i = 0; i < 4; i++)
                Groups.Add(new Group<T>());
        }
    }

    public class Group<T>
    {
        public List<T> Data { get; private set; }
        public Group()
        {
            Data = new List<T>(4);
            for (int i = 0; i < 4; i++)
                Data.Add(default(T));
        }
    }
    #endregion

#region  使用实例
    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine("Hello, World!");


    //        // 查询数据
    //        // 调用静态方法触发BrickInformation的静态构造函数
    //        BrickInformation.Initialize();
    //        Position position = BlockDataStorage<Position>.GetData(BlockType.J, 0, 3);// 获取I型方块大组数据
    //        Console.WriteLine($"查询I类型大组数据: {position.X}, {position.Y}");  // 输出
    //        Console.ReadKey();
    //    }
    //}
#endregion
}
