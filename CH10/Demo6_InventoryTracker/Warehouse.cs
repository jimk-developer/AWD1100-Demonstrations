using System.Collections.Generic;

namespace Demo6_InventoryTracker
{
    public class Warehouse
    {
        // Fields
        private string _name;
        private Dictionary<string, Item> _inventory; // Key = ItemId

        // Constructor
        public Warehouse(string name)
        {
            _name = name;
            _inventory = new Dictionary<string, Item>();
        }

        // Properties
        public string Name
        {
            get { return _name; }
        }

        public Dictionary<string, Item> Inventory
        {
            get { return _inventory; }
        }

        // Methods
        public bool AddItem(Item item)
        {
            if (_inventory.ContainsKey(item.ItemId))
            {
                return false; // Duplicate ID
            }
            _inventory.Add(item.ItemId, item);
            return true;
        }

        public bool RemoveItem(string itemId)
        {
            return _inventory.Remove(itemId);
        }

        public Item SearchById(string itemId)
        {
            if (_inventory.ContainsKey(itemId))
            {
                return _inventory[itemId];
            }
            return null;
        }

        // Override ToString
        public override string ToString()
        {
            string result = $"Warehouse: {_name} ({_inventory.Count} items)\n";
            result += new string('=', 50) + "\n";
            foreach (KeyValuePair<string, Item> pair in _inventory)
            {
                result += $"  {pair.Value.ToString()}\n";
            }
            return result;
        }
    }
}
