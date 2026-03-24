namespace Demo6_InventoryTracker
{
    public class Item
    {
        // Fields
        private string _itemId;
        private string _name;
        private string _category;
        private double _price;
        private int _stockCount;

        // Constructor
        public Item(string itemId, string name, string category, double price, int stockCount)
        {
            _itemId = itemId;
            _name = name;
            _category = category;
            _price = price;
            _stockCount = stockCount;
        }

        // Properties
        public string ItemId
        {
            get { return _itemId; }
        }

        public string Name
        {
            get { return _name; }
        }

        public string Category
        {
            get { return _category; }
        }

        public double Price
        {
            get { return _price; }
        }

        public int StockCount
        {
            get { return _stockCount; }
        }

        // Override ToString
        public override string ToString()
        {
            return $"[{_itemId}] {_name} ({_category}) - ${_price:F2} | Stock: {_stockCount}";
        }
    }
}
