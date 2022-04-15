namespace SpaceCardGame.Domain
{
    class Card
    {

        private string name;
        private int strenght;
        private int power;
        private int DefenseFieldValue;
        private int DefenseArmor;

        public Card(string name, int strenght, int power, int DefenseFieldValue, int DefenseArmor)
        {
            this.name = name;
            this.strenght = strenght;
            this.power = power;
            this.DefenseFieldValue = DefenseFieldValue;
            this.DefenseArmor = DefenseArmor;
        }
        //Id
        //Name
        //Power 1
        //Power 2
        //Defense Field Value
        //Defense Armor
        //DPS - peer Round*?
    }
}





        