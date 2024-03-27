namespace Struct_øvelse
{
    class Program
    {
        static void Main(string[] args)
        {
            Time t1, t2;
            t1 = new Time("08:30:00");
            t2 = new Time(12, 30, 00);
            t2.Hour = t2.Hour + 2;
            Console.Write(t1.ToString());
            Console.WriteLine();
            Console.Write(t2.ToString());
        }
    }


    struct Time
    {
        private int _secondsSinceMidnight;
        private const int _maxSeconds = 86400;

        public int Hour
        {
            set
            {
                int hour = value;
                int temp = _secondsSinceMidnight % 3600;
                _secondsSinceMidnight = (temp + hour * 3600) % _maxSeconds;
            }
            get { return _secondsSinceMidnight / 3600; }
        }

        public int Minute
        {
            set
            {
                int minute = value;
                int temp = _secondsSinceMidnight % 3600;
                _secondsSinceMidnight = (temp + minute * 60) % _maxSeconds;
            }
            get { return (_secondsSinceMidnight % 3600) / 60; }
        }

        public int Second
        {
            set
            {
                int second = value;
                _secondsSinceMidnight = (_secondsSinceMidnight % 3600) + second;
            }
            get { return _secondsSinceMidnight % 60; }
        }

        public Time(string time = "00:00:00")
        {
            Hour = Int32.Parse(time.Substring(0, 2));
            Minute = Int32.Parse(time.Substring(3, 2));
            Second = Int32.Parse(time.Substring(6, 2));
        }

        public Time(int hour, int minute, int second)
        {
            Hour = hour;
            Minute = minute;
            Second = second;
        }

        public override string ToString()
        {
            return $"{Hour:D2}:{Minute:D2}:{Second:D2}";
        }
    }
}
