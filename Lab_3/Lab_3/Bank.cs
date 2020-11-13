using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_3
{
    public abstract class Bank
    {
        protected Bank()
        {

        }
        protected void CreateClient(string name, int age, ClientScoringRate rate)
        {
            var pin = PinGenerator.GeneratePin();
            var newClient = Client.Add()
        }
    }
}
