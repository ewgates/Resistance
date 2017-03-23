using System;

namespace Resistance.Domain
{
    public class Player
    {
        public string Name { get; }
        
        internal Group Group { get; set; }

        internal Player(string name)
        {
            if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException(nameof(name));
            Name = name;
        }

        public override bool Equals(object that)
        {
            return that != null && this.GetType() == that.GetType() && this.Name == ((Player)that).Name;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}