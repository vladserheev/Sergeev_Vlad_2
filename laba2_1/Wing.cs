
namespace laba2_1
{
    class Wing
    {
        private int _width;
        private int _length;
        public int width
        {
            get { return _width; }
            set { _width = value; }
        }
        public int length
        {
            get { return _length; }
            set { _length = value; }
        }

        public Wing()
        {
            _width = 25;
            _length = 500;
        }
        public Wing(int width, int length)
        {
            _width = width;
            _length = length;
        }

        public override string ToString()
        {
            return $"{_length}{_width}";
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

    }
}
