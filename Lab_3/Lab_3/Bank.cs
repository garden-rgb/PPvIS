using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Lab_3
{
    public abstract class Bank
    {
        private readonly string _pathToDataFile;
        public decimal Balance => GetBalance();

        protected Bank(string pathToFile)
        {
            _pathToDataFile = pathToFile;
        }

        protected string CreateClient(string name, int age, ClientScoringRate rate)
        {
            var pin = PinGenerator.GeneratePin();
            var newClient = new Client
            {
                Name = name,
                Age = age,
                ScoringRate = rate,
            };
            return  pin;
        }

        
        
        protected void CashIn(Guid id, decimal amount)
        {
            AddTransaction(amount);
        }

        protected void Withdraw(Guid id, decimal amount)
        {
            AddTransaction(amount * -1);

        }
        protected decimal CalculateRate(ClientScoringRate rate, decimal lowRate, decimal mediumRate, decimal highRate)
        {
            var taxRate = default(decimal);
            switch (rate)
            {
                case ClientScoringRate.Low:
                    taxRate = highRate;
                    break;
                case ClientScoringRate.Average:
                    taxRate = mediumRate;
                    break;
                case ClientScoringRate.High:
                    taxRate = highRate;
                    break;
            }
            return taxRate/100+1;
        }
        protected ClientScoringRate EvaluateScoringRate(int clientAge, int lowAgeLimit, int averageAgeLimit)
        {
            var rate = ClientScoringRate.Low;

            if (clientAge <= lowAgeLimit)
            {
                rate = ClientScoringRate.Low;
            }
            else if (clientAge <= averageAgeLimit)
            {
                rate = ClientScoringRate.Average;
            }
            else
            {
                rate = ClientScoringRate.High;
            }

            return rate;
        }
        private decimal GetBalance()
        {
            var client = ReadClientData();
            return client.Transactions.Sum();
        }
        private void AddTransaction(decimal amount)
        {
            var client = ReadClientData();
            client.Transactions.Add(amount);
            WriteClientData(client);

        }
        private Client ReadClientData()
        {
            var serializedData = File.ReadAllText(_pathToDataFile);
            return JsonConvert.DeserializeObject<Client>(serializedData);
        }
        private void WriteClientData(Client client)
        {
            var serializedClient = JsonConvert.SerializeObject(client);
            File.WriteAllText(_pathToDataFile, serializedClient);
        }
    }
}
