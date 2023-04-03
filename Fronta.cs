namespace TestVlakna
{
    internal class Fronta
    {
        private static List<int> _seznam = new();
        private static readonly object _lock = new();

        public Fronta()
        {
        }

        public void Vloz(int a)
        {
            lock (_lock)
            {
                _seznam.Add(a);
            }
        }

        public int Ziskej(int b)
        {
            lock (_lock)
            {
                if (_seznam.Count > 0)
                {
                    int y = _seznam[b];
                    _seznam.RemoveAt(b);
                    return y;
                }
                return 0;
            }
        }

        public override string ToString()
        {
            if (_seznam.Count != 0)
                return _seznam.Select(x => x.ToString()).Aggregate((a, b) => a + ", " + b);
            else
                return "List je prázdný.";
        }

    }
}