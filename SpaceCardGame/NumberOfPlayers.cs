using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateGamePropertiesModel
{
    public class NumberOfPlayers
    {
        [Required]
        [MaxLength(6)]

        public int NumberOfPlayersInGame { get; set; }

        public int NumberOfPlayersInYourTeam { get; set; }

        public int NumberOfPlayersInEnemyTeam { get; set; }

        public int NumberOfPlayersInBattle { get; set; }
    }
}
