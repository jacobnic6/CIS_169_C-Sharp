using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class StudentWorker:Student
    {
        decimal _hourlyRate;
        double _hoursWorked;

        decimal HourlyRate { get => _hourlyRate; set => _hourlyRate = value; }
        double HoursWorked { get => _hoursWorked; set => _hoursWorked = value; }
        
        public StudentWorker()
        {

        }

        public StudentWorker(decimal hourlyRate, double hoursWorked, string firstName, string lastName, DateTime dateOfBirth, int id): base(firstName, lastName, dateOfBirth, id)
        {
            _hourlyRate = hourlyRate;
            _hoursWorked = hoursWorked;
            
        }


        public override string ToString()
        {
            return base.ToString() + " Hourly pay: " + _hourlyRate + " Hours worked: " + _hoursWorked;
        }

        public override string MakeNamePlate()
        {
            return "Last name: " + LastName + ", First name: " + FirstName + ", Rate of pay: " + _hourlyRate;
        }

        public void CalculatePay()
        {
            decimal pay = _hourlyRate * (decimal)_hoursWorked;
            Console.WriteLine("Pay: " + pay);
        }
    }
}
