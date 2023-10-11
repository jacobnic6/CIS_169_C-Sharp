using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace LoanCalculator.Models
{

    public class LoanCalculatorModel

    {

        private double? _loanAmount;
        private double? _interestRate;
        private int? _yearLoan;

        [Required(ErrorMessage = "Please enter a loan amount")]
        [Range(1, 1000000, ErrorMessage = "Loan amount must be between 1 and 1000000")]
        //public double? LoanAmount { get; set; }
        public double? LoanAmount
        {
            get { return _loanAmount; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException($"{nameof(value)} must be positive.");
                }
                if (value < 1 || value > 1000000)
                {
                    throw new ArgumentOutOfRangeException($"{nameof(value)} be between 1 and 1000000.");
                }
                _loanAmount = value;
            }
        }


        [Required(ErrorMessage = "Please enter an interest rate")]
        [Range(0.01, .50, ErrorMessage = "Interest rate must be between 0.1 and 50.0")]
        //public double? InterestRate { get; set; }
        public double? InterestRate
        {
            get { return _interestRate; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException($"{nameof(value)} must be positive.");
                }
                if (value < 0.01 || value > 0.50)
                {
                    throw new ArgumentOutOfRangeException($"{nameof(value)} be between 0.1 and 0.50.");
                }
                _interestRate = value;
            }
        }

        [Required(ErrorMessage = "Please enter a year amount")]
        [Range(1, 50, ErrorMessage = "Year amount must be between 1 and 50")]
        //public int? YearLoan { get; set; }
        public int? YearLoan
        {
            get { return _yearLoan; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException($"{nameof(value)} must be positive.");
                }
                if (value < 1 || value > 50)
                {
                    throw new ArgumentOutOfRangeException($"{nameof(value)} be between 1 and 50.");
                }
                _yearLoan = value;
            }
        }





        public double MortgagePayment { get; set; }
        public double TotalCost { get; set; }
        public double InterestPaid { get; set; }


        public double CalculatePayment()
        {
            int months = YearLoan.Value * 12;
            double monthlyRate = InterestRate.Value / 12;
            double firstHalfOfEquation = monthlyRate * Math.Pow((1 + monthlyRate), months);
            double secondHalfOfEquation = Math.Pow((1 + monthlyRate), months);
            MortgagePayment = LoanAmount.Value * firstHalfOfEquation / (secondHalfOfEquation - 1);

            //M = P[r(1+r)^n/((1+r)^n)-1)]
            //M = monthly payment
            //P LoanAmount = Principal amount
            //r monthlyRate = monthly interest rate(annual rate/12)
            //n months  = number of payments over loans lifetime (years of loan *12)
            return MortgagePayment;
        }
        public double CalculateTotalCost()
        {
          
            int months = YearLoan.Value * 12;
            double monthlyRate = InterestRate.Value / 12;
            double firstHalfOfEquation = monthlyRate * Math.Pow((1 + monthlyRate), months);
            double secondHalfOfEquation = Math.Pow((1 + monthlyRate), months);
            MortgagePayment = LoanAmount.Value * firstHalfOfEquation / (secondHalfOfEquation - 1);
            double totalCost = MortgagePayment * months;
            return totalCost;
        }

        public double CalculateInterestPaid()
        {

            int months = YearLoan.Value * 12;
            double monthlyRate = InterestRate.Value / 12;
            double firstHalfOfEquation = monthlyRate * Math.Pow((1 + monthlyRate), months);
            double secondHalfOfEquation = Math.Pow((1 + monthlyRate), months);
            MortgagePayment = LoanAmount.Value * firstHalfOfEquation / (secondHalfOfEquation - 1);
            double totalCost = MortgagePayment * months;
            double interestPaid = totalCost - LoanAmount.Value;
            return interestPaid;
        }
    }
}
