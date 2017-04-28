﻿using Microsoft.Xna.Framework;
using MonoGame.Spritesheet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace attack_gamer
{
    public enum UsableType
    {
        HealthPot,
        ManaPot
    }
    public class Usable : Item
    {
        public UsableType type;

        public double Value { get; set; }

        public Usable(UsableType type, GridSheet sheet)
        {
            this.type = type;
            GSheet = sheet;

            switch (this.type)
            {
                case UsableType.HealthPot:
                    Value = 10;
                    Color = new Color(Color.IndianRed, 255);
                    break;
                case UsableType.ManaPot:
                    break;
            }
        }

        public void Use(Usable u, LivingObject o)
        {
            switch (u.type)
            {
                case UsableType.HealthPot:
                    o.Health += u.Value;
                    break;
                case UsableType.ManaPot:
                    o.Mana += u.Value;
                    break;
            }
            u.Exist = false;
        }
    }
}