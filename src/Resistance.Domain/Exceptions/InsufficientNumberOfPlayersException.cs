using System;

namespace Resistance.Domain.Exceptions
{
    public class InsufficientNumberOfPlayersException : Exception
    {
        public InsufficientNumberOfPlayersException() : base("Cannot start game with less than five players.")
        {

        }
    }
}