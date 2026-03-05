using System;
using System.Threading.Tasks;
namespace ConsoleApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("計算面積開始:");
            new AreaFactory(new CircleArea(2)).Area();
            new AreaFactory(new RectangleArea(2,3)).Area();
            new AreaFactory(new TriangleArea(2,3)).Area();
            new AreaFactory(new TrapezoidArea(2, 3,2)).Area();
        }
    }
}
