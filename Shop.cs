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

        public Shop()
        {
            RegisterTypeInterface();

            floor = ServiceLocator.Resolve<IFloor>();
            roof = ServiceLocator.Resolve<IRoof>();
            wall = ServiceLocator.Resolve<IWall>();
        }

        public void RegisterTypeInterface()
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
