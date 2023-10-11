using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LottoNumbersJacobs.Controllers;
using System.ComponentModel.DataAnnotations;

namespace LottoNumbersJacobs.Models
{
    
    public class LottoNumberModel
    {
        
        public static Random getrandom = new Random();
        public int GetRandomNumber(int min, int max)
        {
            lock (getrandom)
            {
                return getrandom.Next(min, max);
            }
        }

        public int WinningNum1 =  LottoNumberModel.getrandom.Next(1, 72);
        public int WinningNum2 = LottoNumberModel.getrandom.Next(1, 72);

        public int WinningNum3 = LottoNumberModel.getrandom.Next(1, 72);

        public int WinningNum4 = LottoNumberModel.getrandom.Next(1, 72);




        [Required]
        [Range(1, 72)]
        public int LottoNumOne { get => lottoNumOne; set => lottoNumOne = value; }
        [Required]
        [Range(1, 72)]
        public int LottoNumTwo { get => lottoNumTwo; set => lottoNumTwo = value; }
        [Required]
        [Range(1, 72)]
        public int LottoNumThree { get => lottoNumThree; set => lottoNumThree = value; }
        [Required]
        [Range(1, 72)]
        public int LottoNumFour { get => lottoNumFour; set => lottoNumFour = value; }
        public int NumbersMatching { get => numbersMatching; set => numbersMatching = value; }
        private int lottoNumOne = 0;
        private int lottoNumTwo = 0;
        private int lottoNumThree = 0;
        private int lottoNumFour = 0;
        private int numbersMatching = 0;

        public int CalculateNumbersMatching()
        {
            
            if (lottoNumOne == WinningNum1)
            {
                if (lottoNumTwo == WinningNum2)
                {
                    if (lottoNumThree == WinningNum3)
                    {
                        if (lottoNumFour == WinningNum4)
                        {
                            return numbersMatching + 4;
                        }
                        return numbersMatching + 3;
                    }
                    return numbersMatching + 2;
                }
                return numbersMatching + 1;
            }
            
            else
            {
                return numbersMatching = 0;
            }
        }
    }
}
