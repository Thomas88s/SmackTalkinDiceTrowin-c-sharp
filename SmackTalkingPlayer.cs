using System;
using System.Linq;
using System.Collections.Generic;

namespace ShootingDice
{
    // TODO: Complete this class

    // A Player who shouts a taunt every time they roll dice
    public class SmackTalkingPlayer : Player
    {
        public string Taunt { get; set; }

     public override int Roll()
       {
           Console.WriteLine($"{Name} says {Taunt}");
           return new Random().Next(DiceSize) + 1;
       }
    }

    
    
}