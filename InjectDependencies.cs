using System;
using System.Collections.Generic;
using System.Text;

namespace dependencis
{
    interface IDependency
    {
        void InjectDependencyFloor(IFloor floor);

        void InjectDependencyRoof(IRoof roof);

        void InjectDependencyWall(IWall wall);
    }
}
