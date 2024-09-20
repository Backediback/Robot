using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotApp.Classes
{


    public class Robot
    {
        private string _facing;
        private int _positionX;
        private int _positionY;
        public string Facing { get => _facing; set => _facing = value; }
        public int PositionX { get => _positionX; set => _positionX = value; }
        public int PositionY { get => _positionY; set => _positionY = value; }

        public Robot(int startXh, int startY, string facing)
        {
            _positionX = startXh;
            _positionY = startY;
            _facing = facing;
        }
    }
}
