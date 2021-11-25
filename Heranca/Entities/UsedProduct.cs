using System;
using System.Collections.Generic;
namespace Heranca.Entities {
    class UsedProduct : Product {
        public DateTime manufactureDate { get; set; }

        public UsedProduct() {
        }

        public UsedProduct(string name, double price, DateTime manufactureDate) : base(name, price) {
            this.manufactureDate = manufactureDate;
        }

        public override string PriceTag() {
            string s =  $"{name}, (used) $ {price} (Manufacture date: {manufactureDate.ToString("dd/MM/yyyy")})";
            return s;
        }

    }
}
