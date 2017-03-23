namespace Resistance.Domain
{
    public class Player
    {
        public string Name { get; }
        
        internal Group Group { get; set; }

        public Player(string name)
        {
            Name = name;
        }
    }
}
