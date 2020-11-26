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

        private string _pin;
        public decimal Balance => GetBalance();

        protected Bank(string pathToFile)
        {
            _pathToDataFile = pathToFile;
        }

        protected string InitializeClient(string name, int age, ClientScoringRate rate)
        {
            _pin = RequestPin();
            var pin = PinGenerator.GeneratePin();
            var newClient = new Client
            {
                Name = name,
                Age = age,
                ScoringRate = rate,
                Pin = pin
            };
            return  pin;
        }
        protected string RequestPin()
        {
            Console.WriteLine("Enter your PIN");
            _pin = Console.ReadLine();
            return _pin;
        }
        protected bool VerifyPin(Client client)
        {
            var _actualClientPin = client.Pin;
            var _pin = RequestPin();
            return _actualClientPin == _pin;
        }

        protected void GetClient(Client client)
        {
            WriteClientData(client);
        }


        protected void CashIn(decimal amount)
        {
            AddTransaction(amount);
        }

        protected void Withdraw(decimal amount)
        {
            AddTransaction(amount);
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
        protected decimal GetBalance()
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
