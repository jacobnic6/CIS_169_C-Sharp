using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
    class ShotPut : Sport
    {
        // take input and assign it to our properties
        public ShotPut(string _teamName, string _equipment, int _numPlayers)
        {
            equipment = _equipment;
            teamName = _teamName;
            numPlayersOnTeam = _numPlayers;
        }

        //overidden method to describe the sport
        public override string Play()
        {
            return "Shotput is a sport where a single individual competes at a time by throwing a weighted ball as far as they can.";
        }
    }
}
