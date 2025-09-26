using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_console_Tetris
{
    public static class BrickInformation
    {




#region 构造函数储存方块信息
        //构造函数
        static BrickInformation()
        {
            
            //Position为相对于中心点的偏移量
            // 初始化第I大组，第1小组
            BlockDataStorage<Position>.SetData(BlockType.I, 0, 0, new Position(-4, 0));
            BlockDataStorage<Position>.SetData(BlockType.I, 0, 1, new Position(-2, 0));
            BlockDataStorage<Position>.SetData(BlockType.I, 0, 2, new Position(0, 0));
            BlockDataStorage<Position>.SetData(BlockType.I, 0, 3, new Position(2, 0));
            // 初始化第I大组，第2小组
            BlockDataStorage<Position>.SetData(BlockType.I, 1, 0, new Position(0, -1));
            BlockDataStorage<Position>.SetData(BlockType.I, 1, 1, new Position(0, 0));
            BlockDataStorage<Position>.SetData(BlockType.I, 1, 2, new Position(0, 1));
            BlockDataStorage<Position>.SetData(BlockType.I, 1, 3, new Position(0, 2));
            // 初始化第I大组，第3小组
            BlockDataStorage<Position>.SetData(BlockType.I, 2, 0, new Position(-4, 0));
            BlockDataStorage<Position>.SetData(BlockType.I, 2, 1, new Position(-2, 0));
            BlockDataStorage<Position>.SetData(BlockType.I, 2, 2, new Position(0, 0));
            BlockDataStorage<Position>.SetData(BlockType.I, 2, 3, new Position(2, 0));
            // 初始化第I大组，第4小组
            BlockDataStorage<Position>.SetData(BlockType.I, 4, 0, new Position(0, -1));
            BlockDataStorage<Position>.SetData(BlockType.I, 4, 1, new Position(0, 0));
            BlockDataStorage<Position>.SetData(BlockType.I, 4, 2, new Position(0, 1));
            BlockDataStorage<Position>.SetData(BlockType.I, 4, 3, new Position(0, 2));



            // 初始化第O大组，第1小组
            BlockDataStorage<Position>.SetData(BlockType.O, 0, 0, new Position(-2, 0));
            BlockDataStorage<Position>.SetData(BlockType.O, 0, 1, new Position(0, 0));
            BlockDataStorage<Position>.SetData(BlockType.O, 0, 2, new Position(-2, 1));
            BlockDataStorage<Position>.SetData(BlockType.O, 0, 3, new Position(0, 1));
            // 初始化第O大组，第2小组
            BlockDataStorage<Position>.SetData(BlockType.O, 1, 0, new Position(-2, 0));
            BlockDataStorage<Position>.SetData(BlockType.O, 1, 1, new Position(0, 0));
            BlockDataStorage<Position>.SetData(BlockType.O, 1, 2, new Position(-2, 1));
            BlockDataStorage<Position>.SetData(BlockType.O, 1, 3, new Position(0, 1));
            // 初始化第O大组，第3小组
            BlockDataStorage<Position>.SetData(BlockType.O, 2, 0, new Position(-2, 0));
            BlockDataStorage<Position>.SetData(BlockType.O, 2, 1, new Position(0, 0));
            BlockDataStorage<Position>.SetData(BlockType.O, 2, 2, new Position(-2, 1));
            BlockDataStorage<Position>.SetData(BlockType.O, 2, 3, new Position(0, 1));
            // 初始化第O大组，第4小组
            BlockDataStorage<Position>.SetData(BlockType.O, 4, 0, new Position(-2, 0));
            BlockDataStorage<Position>.SetData(BlockType.O, 4, 1, new Position(0, 0));
            BlockDataStorage<Position>.SetData(BlockType.O, 4, 2, new Position(-2, 1));
            BlockDataStorage<Position>.SetData(BlockType.O, 4, 3, new Position(0, 1));



            // 初始化第_Z大组，第1小组
            BlockDataStorage<Position>.SetData(BlockType._Z, 0, 0, new Position(0, 0));
            BlockDataStorage<Position>.SetData(BlockType._Z, 0, 1, new Position(2, 0));
            BlockDataStorage<Position>.SetData(BlockType._Z, 0, 2, new Position(-2, 1));
            BlockDataStorage<Position>.SetData(BlockType._Z, 0, 3, new Position(0, 1));
            // 初始化第_Z大组，第2小组
            BlockDataStorage<Position>.SetData(BlockType._Z, 1, 0, new Position(0, -1));
            BlockDataStorage<Position>.SetData(BlockType._Z, 1, 1, new Position(0, 0));
            BlockDataStorage<Position>.SetData(BlockType._Z, 1, 2, new Position(2, 0));
            BlockDataStorage<Position>.SetData(BlockType._Z, 1, 3, new Position(2, 1));
            // 初始化第_Z大组，第3小组
            BlockDataStorage<Position>.SetData(BlockType._Z, 2, 0, new Position(0, 0));
            BlockDataStorage<Position>.SetData(BlockType._Z, 2, 1, new Position(2, 0));
            BlockDataStorage<Position>.SetData(BlockType._Z, 2, 2, new Position(-2, 1));
            BlockDataStorage<Position>.SetData(BlockType._Z, 2, 3, new Position(0, 1));
            // 初始化第_Z大组，第4小组
            BlockDataStorage<Position>.SetData(BlockType._Z, 4, 0, new Position(0, -1));
            BlockDataStorage<Position>.SetData(BlockType._Z, 4, 1, new Position(0, 0));
            BlockDataStorage<Position>.SetData(BlockType._Z, 4, 2, new Position(2, 0));
            BlockDataStorage<Position>.SetData(BlockType._Z, 4, 3, new Position(2, 1));



            // 初始化第Z大组，第1小组
            BlockDataStorage<Position>.SetData(BlockType.Z, 0, 0, new Position(-2, 0));
            BlockDataStorage<Position>.SetData(BlockType.Z, 0, 1, new Position(0, 0));
            BlockDataStorage<Position>.SetData(BlockType.Z, 0, 2, new Position(0, 1));
            BlockDataStorage<Position>.SetData(BlockType.Z, 0, 3, new Position(2, 1));
            // 初始化第Z大组，第2小组
            BlockDataStorage<Position>.SetData(BlockType.Z, 1, 0, new Position(2, -1));
            BlockDataStorage<Position>.SetData(BlockType.Z, 1, 1, new Position(0, 0));
            BlockDataStorage<Position>.SetData(BlockType.Z, 1, 2, new Position(2, 0));
            BlockDataStorage<Position>.SetData(BlockType.Z, 1, 3, new Position(0, 1));
            // 初始化第Z大组，第3小组
            BlockDataStorage<Position>.SetData(BlockType.Z, 2, 0, new Position(-2, 0));
            BlockDataStorage<Position>.SetData(BlockType.Z, 2, 1, new Position(0, 0));
            BlockDataStorage<Position>.SetData(BlockType.Z, 2, 2, new Position(0, 1));
            BlockDataStorage<Position>.SetData(BlockType.Z, 2, 3, new Position(2, 1));
            // 初始化第Z大组，第4小组
            BlockDataStorage<Position>.SetData(BlockType.Z, 4, 0, new Position(2, -1));
            BlockDataStorage<Position>.SetData(BlockType.Z, 4, 1, new Position(0, 0));
            BlockDataStorage<Position>.SetData(BlockType.Z, 4, 2, new Position(2, 0));
            BlockDataStorage<Position>.SetData(BlockType.Z, 4, 3, new Position(0, 1));


            // 初始化第J大组，第1小组
            BlockDataStorage<Position>.SetData(BlockType.J, 0, 0, new Position(-2, 0));
            BlockDataStorage<Position>.SetData(BlockType.J, 0, 1, new Position(0, 0));
            BlockDataStorage<Position>.SetData(BlockType.J, 0, 2, new Position(2, 0));
            BlockDataStorage<Position>.SetData(BlockType.J, 0, 3, new Position(2, 1));
            // 初始化第J大组，第2小组
            BlockDataStorage<Position>.SetData(BlockType.J, 1, 0, new Position(0, -1));
            BlockDataStorage<Position>.SetData(BlockType.J, 1, 1, new Position(2, -1));
            BlockDataStorage<Position>.SetData(BlockType.J, 1, 2, new Position(0, 0));
            BlockDataStorage<Position>.SetData(BlockType.J, 1, 3, new Position(0, 1));
            // 初始化第J大组，第3小组
            BlockDataStorage<Position>.SetData(BlockType.J, 2, 0, new Position(-2, -1));
            BlockDataStorage<Position>.SetData(BlockType.J, 2, 1, new Position(-2, 0));
            BlockDataStorage<Position>.SetData(BlockType.J, 2, 2, new Position(0, 0));
            BlockDataStorage<Position>.SetData(BlockType.J, 2, 3, new Position(2, 0));
            // 初始化第J大组，第4小组
            BlockDataStorage<Position>.SetData(BlockType.J, 4, 0, new Position(0, -1));
            BlockDataStorage<Position>.SetData(BlockType.J, 4, 1, new Position(0, 0));
            BlockDataStorage<Position>.SetData(BlockType.J, 4, 2, new Position(-2, -1));
            BlockDataStorage<Position>.SetData(BlockType.J, 4, 3, new Position(0, 1));

            // 初始化第L大组，第1小组
            BlockDataStorage<Position>.SetData(BlockType.L, 0, 0, new Position(-2, 0));
            BlockDataStorage<Position>.SetData(BlockType.L, 0, 1, new Position(0, 0));
            BlockDataStorage<Position>.SetData(BlockType.L, 0, 2, new Position(2, 0));
            BlockDataStorage<Position>.SetData(BlockType.L, 0, 3, new Position(-2, 1));
            // 初始化第L大组，第2小组
            BlockDataStorage<Position>.SetData(BlockType.L, 1, 0, new Position(0, -1));
            BlockDataStorage<Position>.SetData(BlockType.L, 1, 1, new Position(0, 0));
            BlockDataStorage<Position>.SetData(BlockType.L, 1, 2, new Position(0, 1));
            BlockDataStorage<Position>.SetData(BlockType.L, 1, 3, new Position(2, 1));
            // 初始化第L大组，第3小组
            BlockDataStorage<Position>.SetData(BlockType.L, 2, 0, new Position(-2, 0));
            BlockDataStorage<Position>.SetData(BlockType.L, 2, 1, new Position(0, 0));
            BlockDataStorage<Position>.SetData(BlockType.L, 2, 2, new Position(2, 0));
            BlockDataStorage<Position>.SetData(BlockType.L, 2, 3, new Position(2, -1));
            // 初始化第L大组，第4小组
            BlockDataStorage<Position>.SetData(BlockType.L, 4, 0, new Position(-2, -1));
            BlockDataStorage<Position>.SetData(BlockType.L, 4, 1, new Position(0, -1));
            BlockDataStorage<Position>.SetData(BlockType.L, 4, 2, new Position(0, 0));
            BlockDataStorage<Position>.SetData(BlockType.L, 4, 3, new Position(0, 1));

            // 初始化第T大组，第1小组
            BlockDataStorage<Position>.SetData(BlockType.T, 0, 0, new Position(-2, 0));
            BlockDataStorage<Position>.SetData(BlockType.T, 0, 1, new Position(0, 0));
            BlockDataStorage<Position>.SetData(BlockType.T, 0, 2, new Position(2, 0));
            BlockDataStorage<Position>.SetData(BlockType.T, 0, 3, new Position(0, 1));
            // 初始化第T大组，第2小组
            BlockDataStorage<Position>.SetData(BlockType.T, 1, 0, new Position(0, -1));
            BlockDataStorage<Position>.SetData(BlockType.T, 1, 1, new Position(0, 0));
            BlockDataStorage<Position>.SetData(BlockType.T, 1, 2, new Position(2, 0));
            BlockDataStorage<Position>.SetData(BlockType.T, 1, 3, new Position(0, 1));
            // 初始化第T大组，第3小组
            BlockDataStorage<Position>.SetData(BlockType.T, 2, 0, new Position(0, -1));
            BlockDataStorage<Position>.SetData(BlockType.T, 2, 1, new Position(-2, 0));
            BlockDataStorage<Position>.SetData(BlockType.T, 2, 2, new Position(0, 0));
            BlockDataStorage<Position>.SetData(BlockType.T, 2, 3, new Position(2, 0));
            // 初始化第T大组，第4小组
            BlockDataStorage<Position>.SetData(BlockType.T, 4, 0, new Position(0, -1));
            BlockDataStorage<Position>.SetData(BlockType.T, 4, 1, new Position(-2, 0));
            BlockDataStorage<Position>.SetData(BlockType.T, 4, 2, new Position(0, 0));
            BlockDataStorage<Position>.SetData(BlockType.T, 4, 3, new Position(0, 1));

        }
#endregion


    }


    #region 储存方块信息的数据结构


    // 静态数据存储类（使用BlockType枚举作为大组标识）
    public static class BlockDataStorage<T>
    {
        // 存储7个大组数据（用字典关联枚举与大组）
        private static readonly Dictionary<BlockType, BigGroup<T>> bigGroups;

        // 静态构造函数（初始化数据结构）
        static BlockDataStorage()
        {
            bigGroups = new Dictionary<BlockType, BigGroup<T>>();

            // 为每个枚举成员初始化一个大组（自动处理7个大组）
            foreach (BlockType blockType in Enum.GetValues<BlockType>())
            {
                bigGroups[blockType] = new BigGroup<T>();
            }
        }

        // 根据枚举获取数据
        public static T GetData(BlockType blockType, int groupIndex, int dataIndex)
        {
            // 验证索引有效性
            ValidateIndices(groupIndex, dataIndex);

            return bigGroups[blockType].Groups[groupIndex].Data[dataIndex];
        }

        // 设置数据
        public static void SetData(BlockType blockType, int groupIndex, int dataIndex, T value)
        {
            // 验证索引有效性
            ValidateIndices(groupIndex, dataIndex);

            bigGroups[blockType].Groups[groupIndex].Data[dataIndex] = value;
        }

        // 获取指定枚举对应的大组
        public static BigGroup<T> GetBigGroup(BlockType blockType)
        {
            return bigGroups[blockType];
        }

        // 获取指定大组中的小组
        public static Group<T> GetGroup(BlockType blockType, int groupIndex)
        {
            if (groupIndex < 0 || groupIndex >= 4)
                throw new ArgumentOutOfRangeException(nameof(groupIndex), "小组索引必须在0-3之间");

            return bigGroups[blockType].Groups[groupIndex];
        }

        // 获取所有大组的枚举类型
        public static IEnumerable<BlockType> GetAllBlockTypes()
        {
            return bigGroups.Keys;
        }

        // 验证小组和数据索引有效性
        private static void ValidateIndices(int groupIndex, int dataIndex)
        {
            if (groupIndex < 0 || groupIndex >= 4)
                throw new ArgumentOutOfRangeException(nameof(groupIndex), "小组索引必须在0-3之间");

            if (dataIndex < 0 || dataIndex >= 4)
                throw new ArgumentOutOfRangeException(nameof(dataIndex), "数据索引必须在0-3之间");
        }
    }

    // 大组类（包含4个小组）
    public class BigGroup<T>
    {
        public List<Group<T>> Groups { get; private set; }

        public BigGroup()
        {
            Groups = new List<Group<T>>(4);

            // 初始化4个小组
            for (int i = 0; i < 4; i++)
            {
                Groups.Add(new Group<T>());
            }
        }
    }

    // 小组类（包含4个数据）
    public class Group<T>
    {
        public List<T> Data { get; private set; }

        public Group()
        {
            Data = new List<T>(4);

            // 初始化4个数据位置
            for (int i = 0; i < 4; i++)
            {
                Data.Add(default(T));
            }
        }
    }

    #endregion
    // 使用示例
    //public class Program
    //{
    //    public static void Main()
    //    {
    //        // 直接通过枚举类型访问对应的大组
    //        BlockDataStorage<int>.SetData(BlockType.I, 0, 0, 100);   // I类型大组，第1小组，第1个数据
    //        BlockDataStorage<int>.SetData(BlockType.O, 2, 3, 200);   // O类型大组，第3小组，第4个数据
    //        BlockDataStorage<int>.SetData(BlockType.T, 3, 3, 999);   // T类型大组，第4小组，第4个数据

    //        // 查询数据
    //        int value = BlockDataStorage<int>.GetData(BlockType.I, 0, 0);
    //        Console.WriteLine($"查询I类型大组数据: {value}");  // 输出: 100

    //        // 遍历所有大组
    //        foreach (BlockType blockType in BlockDataStorage<int>.GetAllBlockTypes())
    //        {
    //            Console.WriteLine($"\n{blockType}类型大组数据:");
    //            var bigGroup = BlockDataStorage<int>.GetBigGroup(blockType);

    //            for (int i = 0; i < bigGroup.Groups.Count; i++)
    //            {
    //                var group = bigGroup.Groups[i];
    //                for (int j = 0; j < group.Data.Count; j++)
    //                {
    //                    Console.WriteLine($"小组 {i + 1}, 数据 {j + 1}: {group.Data[j]}");
    //                }
    //            }
    //        }
    //    }
    //}

}
