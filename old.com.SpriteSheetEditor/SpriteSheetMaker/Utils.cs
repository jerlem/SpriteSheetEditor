﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpriteSheetMaker
{
    class Utils
    {
        Benchmark Bench = new Benchmark();
    }

    public class Benchmark
    {
        private static DateTime startDate = DateTime.MinValue;
        private static DateTime endDate = DateTime.MinValue;

        public static TimeSpan Span { get { return endDate.Subtract(startDate); } }

        public static void Start() { startDate = DateTime.Now; }

        public static void End() { endDate = DateTime.Now; }

        public static double GetSeconds()
        {
            if (endDate == DateTime.MinValue) return 0.0;
            else return Span.TotalSeconds;
        }
    }

}
