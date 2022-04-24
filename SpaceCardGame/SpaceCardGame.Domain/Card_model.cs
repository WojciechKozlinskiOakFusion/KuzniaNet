namespace SpaceCardGame.Domain
{
    public class Card
    {

        public string Name { get; }
        public int Strenght { get; }
        public int Power { get; }
        public int DefenseFieldValue { get; }
        public int DefenseArmor { get; }

        public Card(string Name, int Strenght, int Power, int DefenseFieldValue, int DefenseArmor)
        {
            this.Name = Name;
            this.Strenght = Strenght;
            this.Power = Power;
            this.DefenseFieldValue = DefenseFieldValue;
            this.DefenseArmor = DefenseArmor;
        }
    
        //DPS - peer Round*?
    }
}





        