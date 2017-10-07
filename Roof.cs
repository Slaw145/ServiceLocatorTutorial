using System;
using System.Collections.Generic;
using System.Text;

namespace dependencis
{
    public interface IRoof
    {
        int HeightRoof { get; set; }

        void SetHeightRoof(int HeightRoof);
    }

    public class Roof : IRoof
    {
        public int HeightRoof { get; set; }

        public void SetHeightRoof(int HeightRoof)
        {
            this.HeightRoof = HeightRoof;
        }
    }
}
