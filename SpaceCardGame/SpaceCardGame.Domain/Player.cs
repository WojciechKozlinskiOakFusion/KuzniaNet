using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceCardGame.Domain
{
    public class Player
    {
        public int PlayerId { get; }
        public string Name { get; }
        public List<Card> Deck { get; } //
        public int MatchesCount { get; }
        public int WinCount { get; }
        public int LoseCount { get; }

        public Player(int playerId, string name, List<Card> deck, int matchesCount, int winCount, int loseCount)
        {
            this.PlayerId = playerId;
            this.Name = name;
            this.Deck = deck;
            this.MatchesCount = matchesCount;
            this.WinCount = winCount;
            this.LoseCount = loseCount;
        }

    }
}
