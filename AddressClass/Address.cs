using System;
using System.Collections.Generic;
using System.Text;

namespace AddressClass
{
    public class Address
    {
        private int _streetNum;
        private string _streetName;
        private string _cityName;
        private string _unitNum;
        private string _stateName;
        private int _zipCode;

        public Address() // had to add a no arg constructor to be able to call it in the house class
        { 
        }

        public Address(int streetNum, string streetAddress, string unitNum, string cityName, string stateName, int zipCode)
        {
            _streetNum = streetNum;
            _streetName = streetAddress;
            _unitNum = unitNum;
            _cityName = cityName;
            _stateName = stateName;
            _zipCode = zipCode;
        }

        public int StreetNum
        {
            get { return _streetNum; }
            set { _streetNum = value; }
        }
        public string StreetName
        {
            get { return _streetName; }
            set { _streetName = value; }
        }

        public string UnitNum
        {
            get { return _unitNum; }
            set { _unitNum = value; }
        }

        public string CityName
        {
            get { return _cityName; }
            set { _cityName = value; }
        }

        public string StateName
        {
            get { return _stateName; }
            set { _stateName = value; }
        }

        public int ZipCode
        {
            get { return _zipCode; }
            set { _zipCode = value; }
        }

        public override string ToString()
        {
            return "Address: \n" + StreetNum + " " +  StreetName + UnitNum + "\n" + CityName + ", " + StateName + " " + ZipCode;
        }


    }
}
