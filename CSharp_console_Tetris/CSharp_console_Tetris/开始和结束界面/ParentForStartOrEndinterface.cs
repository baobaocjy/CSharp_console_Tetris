using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_console_Tetris
{
    public class ParentForStartOrEndinterface
    {
        public string title;
        public string button1Text;
        public E_GameScene Option1SwitchInterface;
        public string button2Text;
        public E_GameScene Option2SwitchInterface;
        public int CurrentOption = 1;

        int w = Game.sceneWidth;
        int h = Game.sceneHeight;

        //绘制方法
        public void Draw()
        {
            //清理
            Console.Clear();
            //修改文字颜色为白色
            Console.ForegroundColor = ConsoleColor.White;
            //移动光标到指定位置
            Console.SetCursorPosition(w / 2 - title.Length, 2);
            Console.Write(title);

            //移动光标到指定位置
            Console.SetCursorPosition(w / 2 - button1Text.Length, 7);
            //改变文字颜色
            Console.ForegroundColor = CurrentOption == 1 ? ConsoleColor.Red : ConsoleColor.White;
            Console.Write(button1Text);
            //移动光标到指定位置
            Console.SetCursorPosition(w / 2 - button2Text.Length, 8);
            //改变文字颜色
            Console.ForegroundColor = CurrentOption == 2 ? ConsoleColor.Red : ConsoleColor.White;
            Console.Write(button2Text);

        }
        // 更新方法 - 改为等待用户输入后才继续
        public void Update()
        {
            
            Draw(); // 先绘制界面

            // 阻塞等待用户输入（不再检查是否有按键，而是直接等待）
            ConsoleKeyInfo key = Console.ReadKey(true); // true表示不显示输入的字符
            // 根据按下的键执行不同操作
            if (key.Key == ConsoleKey.W)
            {
                CurrentOption = 1; // 选中第1个选项
            }
            else if (key.Key == ConsoleKey.S)
            {
                CurrentOption = 2; // 选中第2个选项
            }
            else if (key.Key == ConsoleKey.Enter)
            {
                // 按回车时执行选中的选项
                if (CurrentOption == 1)
                {
                    Game.e_GameScene = Option1SwitchInterface;
                }
                else if (CurrentOption == 2)
                {
                    Game.e_GameScene = Option2SwitchInterface;
                }
                //清理控制台
                Console.Clear();

            }
        }
    }
}
