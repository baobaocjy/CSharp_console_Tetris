using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_console_Tetris
{
    internal class StartInterface: ParentForStartOrEndinterface
    {
        //构造函数
        public StartInterface()
        {
            //清理
            Console.Clear();
            title= "俄罗斯方块";
            button1Text= "开始游戏";
            Option1SwitchInterface= E_GameScene.E_Playing;
            button2Text = "退出游戏";
            Option2SwitchInterface = E_GameScene.E_Exit;

        }
    }
}
