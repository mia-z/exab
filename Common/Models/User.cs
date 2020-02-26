using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Common.Models
{
    public class User
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public int Hp { get; set; }
        public int Stamina { get; set; }
        public int Strength { get; set; }
        public int Agility { get; set; }
        public int Intelligence { get; set; }
        public int CurrentHp { get; set; }
        public int Xp { get; set; }
        public int Gold { get; set; }

        public User ()
        {

        }

        public User(string name)
        {
            Name = name;
            Level = 1;
            Hp = 10;
            Stamina = 1;
            Strength = 1;
            Agility = 1;
            Intelligence = 1;
            CurrentHp = Hp;
            Xp = 0;
            Gold = 0;
        }
    }
}
