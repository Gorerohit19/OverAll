using BankingLogic;
using Notification;
using GovtLib;


Account acct = new Account(5000);
Receiver receiver = new Receiver();
TaxManager txmgr = new TaxManager();


acct.underBalance += receiver.BlockAccount;
acct.underBalance += receiver.SendEmail;
acct.underBalance += receiver.SendSMS;

acct.overBalance += txmgr.PayIncomeTax;
acct.overBalance += txmgr.PayServiceTax;
acct.overBalance += txmgr.PayTDSTax;

/*
// Account Withdraw Operation 
Console.WriteLine(" Enter Amount To Withdraw");
double amount = double.Parse(Console.ReadLine());
acct.Withdraw(amount);
Console.WriteLine(acct.Balance);*/

//Account Deposite Opration
Console.WriteLine(" Enter Amount to Deposite");
double amount = double.Parse(Console.ReadLine());
acct.Deposite(amount);
Console.WriteLine(acct.Balance);


