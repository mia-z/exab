using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Models
{
    class Enemy
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public int Hp { get; set; }
        public int Stamina { get; set; }
        public int Strength { get; set; }
        public int Agility { get; set; }
        public int Intelligence { get; set; }
        public int CurrentHp { get; set; }
        public int Damage { get; set; }
        public int GoldReward { get; set; }
        public int XpReward { get; set; }
    }
}
