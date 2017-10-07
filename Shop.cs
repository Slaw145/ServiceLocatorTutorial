using kontener;
using System;
using System.Collections.Generic;
using System.Text;

namespace dependencis
{
    class Shop
    {

        public IRoof roof;

        public IFloor floor;

        public IWall wall;

        public Shop(IFloor floor, IRoof roof, IWall wall)
        {
            this.floor = floor;
            this.roof = roof;
            this.wall = wall;
        }

        public static void RegisterTypeInterface()
        {
            ServiceLocator.Register<IFloor, Floor>();
            ServiceLocator.Register<IRoof, Roof>();
            ServiceLocator.Register<IWall, Wall>();
        }

        public void BuildRoof()
        {
            roof.SetHeightRoof(3);
        }

        public void BuildWall()
        {
            wall.SetColorWall("Red");
            wall.SetGageWall(1);
        }

        public void BuildFloor()
        {
            floor.SetLenghtFloor(10);
            floor.SetNumberOfTilesOnFloor(100);
            floor.SetTypeGreatnessTiles("Medium");
        }

        public void BuildShop()
        {
            BuildRoof();
            BuildWall();
            BuildFloor();
        }

    }
}
