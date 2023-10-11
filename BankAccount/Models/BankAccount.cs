using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BankAccount.Models
{
    public class BankAccount
    {
        private decimal _balance;
        private decimal _amount;
        private int accountNumber;

        [Required]
        
        public decimal Balance
        {
            get { return _balance; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException($"{nameof(value)} must be  positive.");
                }
                _balance = value;
            }
        }

        [Required]
        //public decimal Amount { get => ; set => _amount = value; }
        public decimal Amount
        {
            get { return _amount; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException($"{nameof(value)} must be  positive.");
                }
                _amount = value;
            }
        }
        [Required]
        public int AccountNumber { get => accountNumber; set => accountNumber = value; }

    
        public void Withdraw()
        {
            if (_balance - _amount < 0)
            {
                throw new ArgumentOutOfRangeException($" Amount of {nameof(_amount)} will overdraft your account.");
             }
            else { _balance = _balance - _amount; }
                
        }
        public void Deposit()
        {
            _balance = (_balance + _amount);
        }

    }
}
