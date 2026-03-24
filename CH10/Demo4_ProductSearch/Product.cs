namespace Demo4_ProductSearch
{
    public class Product
    {
        // Fields
        private string _sku;
        private string _name;
        private string _brand;
        private double _price;
        private int _quantity;

        // Constructor
        public Product(string sku, string name, string brand, double price, int quantity)
        {
            _sku = sku;
            _name = name;
            _brand = brand;
            _price = price;
            _quantity = quantity;
        }

        // Properties
        public string SKU
        {
            get { return _sku; }
        }

        public string Name
        {
            get { return _name; }
        }

        public string Brand
        {
            get { return _brand; }
        }

        public double Price
        {
            get { return _price; }
        }

        public int Quantity
        {
            get { return _quantity; }
        }

        // Override ToString
        public override string ToString()
        {
            return $"[{_sku}] {_name} by {_brand} - ${_price:F2} (Qty: {_quantity})";
        }
    }
}
