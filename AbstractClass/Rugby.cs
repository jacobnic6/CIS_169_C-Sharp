using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
    class Rugby : Sport
    {
        // take input and assign it to our properties
        public Rugby( string _teamName, string _equipment, int _numPlayers)
        {
            equipment = _equipment;
            teamName = _teamName;
            numPlayersOnTeam = _numPlayers;
        }
        //overidden method to describe the sport 
        public override string Play()
        {
            return "Rugby is a team sport where your team tries to get the ball across the goal line.";
        }

        //returns num of players on a team
        public int FormTeam()
        {
            return numPlayersOnTeam;
        }
    }
}
