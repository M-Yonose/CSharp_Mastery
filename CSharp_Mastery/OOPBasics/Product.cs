using System;
using System.Collections.Generic;
using System.Text;

namespace OOPBasics
{
    internal class Product
    {
        private const string _hashkey = "PROD001";
        public string name { get; set; }
        public double price { get; set; }

        ~Product()
        {

        }

        public double CalculateDiscountedPrice(double discount)
        {
            return (price - (price * (discount / 100)));
        }

        public double CalculateDiscountedPrice(double discount, double maxDiscount)
        {
            var discountAmount = (price - (price * (discount / 100)));

            return discountAmount > maxDiscount ? maxDiscount : discountAmount;
        }
        
        public double CalculateDiscountedAmount(double discount, int maxDiscount)
        {
            var discountAmount = (price - (price * (discount / 100)));

            return discountAmount > maxDiscount ? maxDiscount : discountAmount;
        }

        public decimal CalculateDiscountedPrice(decimal discount, decimal maxDiscount)
        {
            var discountAmount = (decimal)price - ((decimal)(price)) * (discount / 100));

            return discountAmount > maxDiscount ? maxDiscount : discountAmount;
        }
}
