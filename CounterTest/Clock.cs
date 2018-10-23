using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Clock
{
    public class Clock
    {

        Counter _seconds = new Counter("seconds");
        Counter _minutes = new Counter("minutes");
        Counter _hours = new Counter("hours");

        //Saves the clock data
        public Clock()
        {
            Restart();
        }

        //Increments the time
        public void Second()
        {
            _seconds.Increment();
            if (_seconds.Value >= 60)
            {
                _seconds.Reset();
                _minutes.Increment();
                if (_minutes.Value >= 60)
                {
                    _minutes.Reset();
                    _hours.Increment();
                    if (_hours.Value >= 24)
                    {
                        _hours.Reset();
                    }
                }
            }
            
        }

        //Resets the clock to 00:00:00
        public void Restart()
        {
            _seconds.Reset();
            _minutes.Reset();
            _hours.Reset();
        }

        //returns the time
        public string Print()
        {
            return _hours.Value.ToString("D2") + ":" + _minutes.Value.ToString("D2") + ":" + _seconds.Value.ToString("D2");
        }
    }
}
