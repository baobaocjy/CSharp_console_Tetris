namespace CSharp_console_Tetris
{
    //游戏场景枚举
    /// <summary>
    /// 游戏场景枚举
    /// </summary>

    internal class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.MainLoop();
        }
    }
}
