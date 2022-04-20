using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateGamePropertiesModel
{
    public class Level
    {
        [Required]
        public int IdLevel { get; set; }

        public string LevelName { get; set; }

        public int LevelOfDifficulty { get; set; }

        public int EnemiesOnLevel { get; set; }

        public string TypeEnemiesOnLevel { get; set; }

        public string Description { get; set; }

    }
}
