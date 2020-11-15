using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_3
{
    class SampleBank:Bank,IBank
    {
        private const decimal LowRate = 10;

        private const int LowRateAgeLimit = 28;

        private const decimal AverageRate = 20;

        private const int AverageRateAgeLimit = 45;

        private const decimal HighRate = 30;

        private Client client;
        public SampleBank(string pathToFile):base(pathToFile)
        {

        }

        public string CreateClient(string name, int age)
        {
            var clientRate = base.EvaluateScoringRate(age, LowRateAgeLimit, AverageRateAgeLimit);
            return base.CreateClient(name, age, clientRate);
        }
        public decimal Balance(Guid id)
        {
            return base.Balance;
        }
    }
}
