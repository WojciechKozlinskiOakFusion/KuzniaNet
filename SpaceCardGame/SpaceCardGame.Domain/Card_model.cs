using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore.Tools;
namespace SpaceCardGame.Domain
{
    public class Card
    {

        public string Name { get; }
        public int Strenght { get; }
        public int Power { get; }
        public int DefenseFieldValue { get; }
        public int DefenseArmor { get; }

        public Card(string Name, int Strenght, int Power, int DefenseFieldValue, int DefenseArmor)
        {
            this.Name = Name;
            this.Strenght = Strenght;
            this.Power = Power;
            this.DefenseFieldValue = DefenseFieldValue;
            this.DefenseArmor = DefenseArmor;
        }
    
        //DPS - peer Round*?
    }
}





        