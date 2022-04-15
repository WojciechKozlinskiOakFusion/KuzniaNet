using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceCardGame.Domain
{
    enum OperationType
    {
        Battle,
        CaptureTheFlag,
        Elimination,
        AllForOne
    }

    class CreateRoundModel
    {
        private List<int> PlayerID;
        private List<int> CardID;
        private OperationType operationType;

        void SaveGame()
        {
            // SaveGame
        }

        public CreateRoundModel(List<int> PlayerID, List<int> CardID, OperationType operationType)
        {
            this.PlayerID = PlayerID;
            this.CardID = CardID;
            this.operationType = operationType;
            SaveGame();
        }

        
    }
}
