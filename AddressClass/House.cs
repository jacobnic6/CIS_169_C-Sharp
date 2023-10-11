using System;
using System.Collections.Generic;
using System.Text;

namespace AddressClass
{
    public class House
    {
        private Address _houseAddress;
        private string _houseColor; // added color for another property

        //Constructors
        //no-arg default constructor
        public House()
        {
            _houseAddress = new Address(); // Call no arg address constructor
            _houseColor = "unknown";
        }
        
        public House(int streetNum, string streetAddress, string unitNum, string cityName, string stateName, int zipCode, string houseColor)
        {
            _houseAddress = new Address(streetNum, streetAddress, unitNum, cityName, stateName, zipCode); // call address constructor and set the new address to our _houseAddress property
            _houseColor = houseColor;
        }
        //get and set 
        
        public Address HouseAddress { get => _houseAddress; set => _houseAddress = value; } //get and set class address as a property in class house
        public string HouseColor { get => _houseColor; set => _houseColor = value; }

        public override string ToString()
        {
            return _houseAddress.ToString() + "\n" + "House Color: " + _houseColor;
        }
    }
}
