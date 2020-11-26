using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_3
{
     public class StartBankOperation
     {
        public void BankOperation()
        {
            var path = @"C:\Users\J\Desktop\test.txt";
            var sampleBank = new SampleBank(path);

            sampleBank.InitializeClient();
        }
     }
}
