using System;
using System.Collections.Generic;
using System.Text;

namespace Resistance.Domain.Exceptions
{
    public class PlayerAlreadyAddedException : Exception
    {
        public PlayerAlreadyAddedException() : base("Game cannot add multiple players with the same name.")
        {

        }
    }
}
