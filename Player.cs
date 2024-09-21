using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    internal class Player
    {
        public string Name { get; private set; }
        public Hand Hand;

        public Player(string name)
        {
            this.Name = name;
            Hand = new Hand();
        }
    }
}
