using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace horse_racing
{
   public class Manpreet
    {

        public int Amount = 0;
        public int bet = 0;
        public int Budget = 100;

        public int setAmount { get; set; }
        public int setBet { get; set; }
        public int setBudget { get; set; }

        //paramterized constructor 
        public Manpreet(int Amt, int bt, int budget)
        {
            Amount = Amt;
            bet = bt;
            Budget = budget;
        }

        public int budgetRest(int horse)
        {
            if (horse == bet)
            {
                return  Budget+Amount;
            }
            else
            {
                return  Budget-Amount;
            }
        }

    }
}
