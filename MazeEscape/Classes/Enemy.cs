﻿using System;
using MazeEscape.Enums;
namespace MazeEscape.Classes

{
    public class Enemy
    {
        public string name { get; set; }
        public double attack { get; set; }
        public double defense { get; set; }
        public EnemyTypes target {get; set;}
    }
}

