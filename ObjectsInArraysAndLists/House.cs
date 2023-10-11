using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectsInArraysAndLists
{
    public class House
    {
        // fields 
        private string _address;
        private int _numberBedrooms;
        private int _numberBathrooms;

        // Constructors
        public House() // default no-arg
        {
            Address = "";
            NumberBedrooms = 0;
            NumberBathrooms = 0;
        }

        public House(string address, int numberBathrooms, int numberBedrooms)
        {
            Address = address;
            NumberBathrooms = numberBathrooms;
            NumberBedrooms = numberBedrooms;
        }
        //Properties with public access to set and get values 
        public string Address { get => _address; set => _address = value; }
        public int NumberBedrooms { get => _numberBedrooms; set => _numberBedrooms = value; }
        public int NumberBathrooms { get => _numberBathrooms; set => _numberBathrooms = value; }

       



    public override string ToString()
        {
            return ("House at " + Address + " has " + NumberBedrooms + " bedrooms and " + NumberBathrooms + " bathrooms.");
        }
    }
}
