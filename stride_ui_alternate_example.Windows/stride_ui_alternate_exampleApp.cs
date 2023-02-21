using Stride.Engine;
using stride_ui_alternate_example.Views;

namespace stride_ui_alternate_example
{
    class stride_ui_alternate_exampleApp
    {
        static void Main(string[] args)
        {
            using (var game = new Game())
            {
                game.Run();
            }
        }
    }
}
