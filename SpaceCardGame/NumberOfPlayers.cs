using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//dodane
using System.ComponentModel.DataAnnotations;

namespace CreateGamePropertiesModel
{
    public class NumberOfPlayers
    {
        [Required]
        [MaxLength(6)]

        public int NumberOfPlayersInGame { get; set; }

        int NumberOfPlayersInYourTeam { get; set; }

        int NumberOfPlayersInEnemyTeam { get; set; }

        int NumberOfPlayersInBattle { get; set; }
    }
}
