using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore.Tools;

namespace SpaceCardGame.Domain;

public class GamePropertiesModel
{
    //Number of Card
    //Number of Players
    //Game Time
    //Stage Id / Level ??
    public int NumberOfCards { get; }
    public int NumberOfPlayers { get; }
    public int GameTime { get; }
    public int StageId { get; }

    public GamePropertiesModel(int numberOfCards, int numberOfPlayers, int GameTime, int stageId)
    {
        this.NumberOfCards = numberOfCards;
        this.NumberOfPlayers = numberOfPlayers;
        this.GameTime = gameTime;
        this.StageId = stageId;
    }
}
