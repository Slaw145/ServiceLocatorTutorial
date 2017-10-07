using System;
using System.Collections.Generic;
using System.Text;

namespace dependencis
{
    public interface IWall
    {
        int GageWall { get; set; }
        string ColorWall { get; set; }

        void SetGageWall(int GageWall);
        void SetColorWall(string ColorWall);
    }

    public class Wall : IWall
    {
        public int GageWall { get; set; }
        public string ColorWall { get; set; }

        public void SetGageWall(int GageWall)
        {
            this.GageWall = GageWall;
        }

        public void SetColorWall(string ColorWall)
        {
            this.ColorWall = ColorWall;
        }
    }
}
