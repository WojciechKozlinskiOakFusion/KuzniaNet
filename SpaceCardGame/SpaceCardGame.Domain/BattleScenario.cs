using System;


namespace SpaceCardGame.Domain
{
    public abstract class BattleScenario
    {
        private List<Player> players;

        public void addPlayers(//Lista graczy?, pojedynczy gracze?)
        {
             
        }

        public void selectTypeOfBattle() // typ bitwy, odwołanie do enum OperationType?
        {

        }

        private virtual bool victoryCondition() // każdy gracz będzie miał właściwość zwycięstwo, przegrana?
        {

        }

        private virtual bool lossCondition()
        {

        }
        
        private virtual DateTime roundTime() // argument wejściowy string z eum OperationType?
        {

        }

        private virtual int numberOfRounds() // argument wejściowy string z enum OperationType?
        {

        }


}

}
