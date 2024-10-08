﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotApp.Classes
{
    public class Room
    {
        private int _depth;
        private int _height;
        public int Depth { get => _depth; set => _depth = value; }
        public int Height { get => _height; set => _height = value; }
        public Room(){}

        public Room(int depth, int height)
        {
            _depth = depth;
            _height = height;
        }
    }
}
