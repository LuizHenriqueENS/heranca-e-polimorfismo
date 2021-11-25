using System.Globalization;

namespace Heranca.Entities {
    class ImportedProduct : Product{
        public double customsFees { get; set; }

        public ImportedProduct() {
        }

        public ImportedProduct(string name, double price, double customsFees) : base(name, price) {
            this.customsFees = customsFees;
        }

        public double TotalPrice() {
            return base.price += customsFees;
        }
        public override string PriceTag() {
            return $"{name}, $ {TotalPrice().ToString("F2", CultureInfo.InvariantCulture)}, (Custom fee: $ {customsFees.ToString("F2", CultureInfo.InvariantCulture)})";
        }
    }
}
