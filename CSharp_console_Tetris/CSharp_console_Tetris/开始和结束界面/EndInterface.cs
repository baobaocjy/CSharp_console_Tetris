using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_console_Tetris
{
    internal class EndInterface: ParentForStartOrEndinterface
    {
        
        //构造函数
        public EndInterface()
        {
            title = "游戏结束";
            button1Text = "返回开始界面";
            Option1SwitchInterface = E_GameScene.E_Start;
            button2Text = "退出游戏";
            Option2SwitchInterface = E_GameScene.E_Exit;
        }
    }
}
