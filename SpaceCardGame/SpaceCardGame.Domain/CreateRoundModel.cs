using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceCardGame.Domain
{
    public enum OperationType
    {
        Battle,
        CaptureTheFlag,
        Elimination,
        AllForOne
    }

    public class CreateRoundModel
    {
        public List<int> PlayerIDList { get; }
        public List<int> CardIDList { get; }
        public OperationType operationType;

        public void SaveGame()
        {
            // SaveGame
        }

        public CreateRoundModel(List<int> PlayerIDList, List<int> CardIDList, OperationType operationType)
        {
            this.PlayerIDList = PlayerIDList;
            this.CardIDList = CardIDList;
            this.operationType = operationType;
        }
    }
}
