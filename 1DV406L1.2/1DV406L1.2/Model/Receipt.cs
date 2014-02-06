using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _1DV406L1._2.Model
{
    public class Receipt
    {
        //fields
        private double _subtotal;
        //properties
        public double DiscountRate { get; set; }
        public double MoneyOff { get; set; }
        public double Subtotal
        {
            get
            {
                return _subtotal;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                _subtotal = value;
            }
        }
        public double Total { get; set; }
        //methods
        public void Calculate(double subtotal)
        {
            this.Subtotal = subtotal;

            //checking what discount rate to use
            if (subtotal > 500)
            {
                DiscountRate = 0;
            }

            if (500 <= subtotal && subtotal < 1000)
            {
                DiscountRate = 0.05;
            }
            if (1000 <= subtotal && subtotal < 5000)
            {
                DiscountRate = 0.10;
            }
            if (5000 <= subtotal)
            {
                DiscountRate = 0.15;
            }

            //Calculating the discount
            MoneyOff = DiscountRate * subtotal;

            //Final sum after discount
            Total = subtotal - MoneyOff;
        }
        public Receipt(double subtotal)
        {
            Calculate(subtotal);
        }
    }
}