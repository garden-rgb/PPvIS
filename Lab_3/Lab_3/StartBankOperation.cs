using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_3
{
     public class StartBankOperation
     {
        public void BankOperation()
        {
            decimal _sumCashIn;
            decimal _sumWithdraw;

            var path = @"C:\Users\J\Desktop\test.txt";
            var sampleBank = new SampleBank(29,200,"Eugene");

            sampleBank.InitializeClient();
            
            Console.WriteLine("********Welcome to ATM Service**************\n");
            Console.WriteLine("1. Deposit Cash\n");
            Console.WriteLine("2. Withdraw Cash\n");
            Console.WriteLine("*********************************************\n\n");
            Console.WriteLine("Enter your choice: ");

            int typeOperation = int.Parse(Console.ReadLine());
            switch (typeOperation)
            {
                case 1:
                    Console.Write("Enter amount of deposit");

                    if (decimal.TryParse(Console.ReadLine(), out _sumCashIn))
                    {
                        decimal sumCashIn = _sumCashIn;
                        void ViewBankCashIn(IBank bankOut)
                        {
                            bankOut.CashIn(sumCashIn);
                        }
                        Console.ReadKey();
                        break;
                    }
                    else
                    {
                        Console.Write("Wrong amount");
                        Console.ReadKey();
                        break;
                    }

                case 2:
                    Console.Write("Enter amount of withdraw");
                    if (decimal.TryParse(Console.ReadLine(), out _sumWithdraw))
                    {
                        decimal sumWithdraw = _sumWithdraw;

                        void ViewBankWithdraw(IBank bankOut)

                        {
                            bankOut.Withdraw(sumWithdraw);
                        }

                        Console.ReadKey();
                        break;
                    }
                    else
                    {
                        Console.Write("Wrong amount");
                        Console.ReadKey();
                        break;
                    }

                default:
                    Console.Write("Wrong type of operation");
                    Console.ReadKey();
                    break;
            }
        }

     }
}

