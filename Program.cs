using kontener;
using System;

namespace dependencis
{
    class Program
    {
        static void Main(string[] args)
        {
            Shop shop = new Shop();
            shop.BuildShop();
            Console.WriteLine(shop.wall.GageWall);

            Console.ReadKey();
        }
    }
}
