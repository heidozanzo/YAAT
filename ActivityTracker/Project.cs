﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActivityTracker
{
    class Project
    {
        public string name;
        public TimeSpan elapsed;
        public int id;

    }


    class Stopwatch : System.Diagnostics.Stopwatch
    {
        TimeSpan _offset = new TimeSpan();

        public Stopwatch()
        {
        }

        public Stopwatch(TimeSpan offset)
        {
            _offset = offset;
        }

        public void SetOffset(TimeSpan offsetElapsedTimeSpan)
        {
            _offset = offsetElapsedTimeSpan;
        }

        public TimeSpan Elapsed {
            get { return base.Elapsed + _offset; }
            set { _offset = value; }
        }

        public long ElapsedMilliseconds {
            get { return base.ElapsedMilliseconds + _offset.Milliseconds; }
        }

        public long ElapsedTicks {
            get { return base.ElapsedTicks + _offset.Ticks; }
        }
    }
}
