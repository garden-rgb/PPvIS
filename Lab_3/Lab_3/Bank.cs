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
        protected Client _client;

        private readonly string _pathToDataFile;

        private string _pin;
        public decimal Balance => GetBalance();
        string _name = "Eugene";
        decimal _balance = 100;
        protected Bank(string name, decimal balance, int age)
        {
            _name = name;
            _client.Age = age;
            _balance = balance;
        }
        /// <summary>
        /// Свойство для инициализации клиента
        /// </summary>
        /// <returns></returns>
        public string InitializeClient()
        {
            _pin = PinGenerator.GeneratePin();
            var Client = new Client
            {
                Name = _client.Name,
                Age = _client.Age,
                ScoringRate = _client.ScoringRate,
                Pin = _pin
            };
            WriteClientData(_client);
            return _pin;
        }
        /// <summary>
        /// Запрос Пин-Кода
        /// </summary>
        /// <returns></returns>
        protected string RequestPin()
        {
            Console.WriteLine("Enter your PIN");
            _pin = Console.ReadLine();
            return _pin;
        }
        /// <summary>
        /// Проверка Пин-Кода
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
        protected bool VerifyPin(Client client)
        {
            var _actualClientPin = client.Pin;
            var _pin = RequestPin();
            return _actualClientPin == _pin;
        }
        /// <summary>
        /// Запись клиента
        /// </summary>
        /// <param name="client"></param>
        protected void GetClient(Client client)
        {
            WriteClientData(client);
        }

        /// <summary>
        /// Операция пополнения 
        /// </summary>
        /// <param name="amount"></param>
        protected void CashIn(decimal amount)
        {
            AddTransaction(amount);
        }
        /// <summary>
        /// Операция вывода
        /// </summary>
        /// <param name="amount"></param>
        protected void Withdraw(decimal amount)
        {
            AddTransaction(amount);
        }
        /// <summary>
        /// Расчёт размера комиссии по рейтингу клиента
        /// </summary>
        /// <param name="rate"></param>
        /// <param name="lowRate"></param>
        /// <param name="mediumRate"></param>
        /// <param name="highRate"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Расчёт рейтинга клиента по возрасту
        /// </summary>
        /// <param name="clientAge"></param>
        /// <param name="lowAgeLimit"></param>
        /// <param name="averageAgeLimit"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Получение баланса
        /// </summary>
        /// <returns></returns>
        protected decimal GetBalance()
        {
            var client = ReadClientData();
            return client.Transactions.Sum();
        }
        /// <summary>
        /// Запись новой транзакции
        /// </summary>
        /// <param name="amount"></param>
        private void AddTransaction(decimal amount)
        {

            var client = ReadClientData();
            client.Transactions.Add(amount);
            WriteClientData(client);

        }
        /// <summary>
        /// Чтение клиента из файла
        /// </summary>
        /// <returns></returns>
        private Client ReadClientData()
        {
            var serializedData = File.ReadAllText(_pathToDataFile);
            return JsonConvert.DeserializeObject<Client>(serializedData);
        }
        /// <summary>
        /// Запись информации о клиенте в файл
        /// </summary>
        /// <param name="client"></param>
        private void WriteClientData(Client client)
        {
            var serializedClient = JsonConvert.SerializeObject(client);
            File.WriteAllText(_pathToDataFile, serializedClient);
        }
    }
}
