using System;

namespace Demo6_PaintEstimator
{
    public class Wall
    {
        // Private fields
        private string _roomName;
        private int _height;
        private int _width;
        private int _area;
        private int _gallons;

        // Constant: one gallon covers 350 square feet
        private const int SQ_FT_PER_GALLON = 350;

        // Constructor
        public Wall(string roomName, int height, int width)
        {
            _roomName = roomName;
            _height = height;
            _width = width;
            
            // Calculate area
            _area = _height * _width;
            
            // Calculate gallons: (area / 350) rounded up + 1 for touch-ups
            _gallons = (int)Math.Ceiling((double)_area / SQ_FT_PER_GALLON) + 1;
        }

        // Read-only properties
        public string RoomName
        {
            get { return _roomName; }
        }

        public int Height
        {
            get { return _height; }
        }

        public int Width
        {
            get { return _width; }
        }

        public int Area
        {
            get { return _area; }
        }

        public int Gallons
        {
            get { return _gallons; }
        }

        // Display method returns formatted string
        public string Display()
        {
            return $"{_roomName} ({_height}x{_width}) needs {_gallons} gallons";
        }
    }
}
