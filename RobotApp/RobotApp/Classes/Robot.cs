using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RobotApp.Classes
{
    public class Robot
    {
        private string _facing;
        private int _positionX;
        private int _positionY;
        private string[]? _userMove;
        public string Facing { get => _facing; set => _facing = value; }
        public int PositionX { get => _positionX; set => _positionX = value; }
        public int PositionY { get => _positionY; set => _positionY = value; }
        public string[] UserMove { get => _userMove!; set => _userMove = value; }

        public Robot(int startX, int startY, string facing)
        {
            _positionX = startX;
            _positionY = startY;
            _facing = facing.ToUpper();
        }

        public string[] splitMove(string move)
        {
            var inputMove = new string[move.Length];

            for (int i = 0; i < move.Length; i++)
            {
                inputMove[i] = move[i].ToString();
            }
            return inputMove;
        }
        public void DoMove()
        {
            foreach (string move in UserMove)
            {
                switch (move)
                {
                    case "F":
                        switch (Facing)
                        {
                            case "E":
                                PositionX++;
                                break;
                            case "W":
                                PositionX--;
                                break;
                            case "N":
                                PositionY--; break;
                            case "S":
                                PositionY++; break;
                        }
                        break;
                    case "R":
                        switch (Facing)
                        {
                            case "E":
                                Facing = "S";
                                break;
                            case "W":
                                Facing = "N";
                                break;
                            case "N":
                                Facing = "E";
                                break;
                            case "S":
                                Facing = "W";
                                break;
                        }
                        break;
                    case "L":
                        switch (Facing)
                        {
                            case "E":
                                Facing = "N";
                                break;
                            case "W":
                                Facing = "S";
                                break;
                            case "N":
                                Facing = "W";
                                break;
                            case "S":
                                Facing = "E";
                                break;
                        }
                        break;
                    default:
                        break;
                    
                }
            }
        }
    }
   
}
