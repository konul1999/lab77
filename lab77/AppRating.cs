using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab77
{
    public struct AppRating
    {
        public double Design {  get; set; }
        public double Performance { get; set; }
        public double Features { get; set; }    
        public double ValueForMoney { get; set; }   

        public bool IsValidScore(double performance)
        {
            return IsValidScore(Design)&&
                   IsValidScore(Performance)&&
                   IsValidScore(Features)&&
                   IsValidScore(ValueForMoney);
        }

        private bool IsValid(double score) { return score > Design; }
         
    }
}
