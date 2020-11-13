using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_3
{
    public static class PinGenerator
    {
        private static Random Rnd;

        private const int PinStart = 1;

        private const int PinEnd = 9999;

        static PinGenerator()
        {
            Rnd = new Random();
        }
        public static string GeneratePin()
        {
            return Rnd.Next(PinStart, PinEnd).ToString("D4");
        }
    }
}
