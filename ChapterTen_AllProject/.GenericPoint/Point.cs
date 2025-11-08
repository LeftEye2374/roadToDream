namespace GenericPoint
{
    public struct Point<T>
    {
        private T _xPos;
        private T _yPos;

        public Point(T x, T y)
        {
            _xPos = x;
            _yPos = y;
        }

        public T X
        {
            get => _xPos;
            set => _xPos = value;
        }

        public T Y
        {
            get => _yPos;
            set => _yPos = value;
        }

        public override string ToString() => $"[{_xPos}, {_yPos}]";

        public void ResetPoint()
        {
            _xPos = default;
            _yPos = default;
        }
    }
}