using System;
using System.Collections.Generic;
using System.Text;

namespace dependencis
{
    public interface IFloor
    {
        int LenghtFloor { get; set; }
        int NumberOfTilesOnFloor { get; set; }
        string TypeGreatnessTiles { get; set; }

        void SetLenghtFloor(int LenghtFloor);
        void SetNumberOfTilesOnFloor(int NumberOfTilesOnFloor);
        void SetTypeGreatnessTiles(string TypeGreatnessTiles);
    }

    public class Floor : IFloor
    {
        public int LenghtFloor { get; set; }
        public int NumberOfTilesOnFloor { get; set; }
        public string TypeGreatnessTiles { get; set; }

        public void SetLenghtFloor(int LenghtFloor)
        {
            this.LenghtFloor = LenghtFloor;
        }
        public void SetNumberOfTilesOnFloor(int NumberOfTilesOnFloor)
        {
            this.NumberOfTilesOnFloor = NumberOfTilesOnFloor;
        }
        public void SetTypeGreatnessTiles(string TypeGreatnessTiles)
        {
            this.TypeGreatnessTiles = TypeGreatnessTiles;
        }
    }
}
