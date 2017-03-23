using System;

namespace Resistance.Domain.Exceptions
{
    public class MaximumNumberOfPlayersExceededException : Exception
    {
        public MaximumNumberOfPlayersExceededException() : base("Game cannot have more than ten players.")
        {

        }
    }
}
