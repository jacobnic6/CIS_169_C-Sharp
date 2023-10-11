using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
   public abstract class Sport
    {
       //name properties
        protected string equipment;
        protected int numPlayersOnTeam;
        protected string teamName;

        //abstract method
        public abstract string Play();

        //to string method to be used to describe our classes
        public override string ToString()
        {
            return teamName + " requires " + numPlayersOnTeam + " people, and " + equipment +".";
        }



    }
}
