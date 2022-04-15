using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceCardGame.Domain
{
    public class Player
    {
        public int PlayerId { get; set; }
        public string Name { get; set; }
        public List<Card> Deck { get; set; } //
        public int MatchesCount { get; set; }
        public int WinCount { get; set; }
        public int LoseCount { get; set; }

    }
}
