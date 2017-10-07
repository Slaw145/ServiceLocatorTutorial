using kontener;
using System;

namespace dependencis
{
    class Program
    {
        static void Main(string[] args)
        {
            Shop.RegisterTypeInterface();

            IFloor floor = ServiceLocator.Resolve<IFloor>();
            IRoof roof = ServiceLocator.Resolve<IRoof>();
            IWall wall = ServiceLocator.Resolve<IWall>();

            Shop shop = new Shop(floor, roof, wall);
            shop.BuildShop();
            Console.WriteLine(shop.wall.GageWall);

            Console.ReadKey();
        }
    }
}