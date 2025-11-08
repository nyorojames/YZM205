using System;
using System.Runtime.InteropServices;

BankAccount myAccount = new BankAccount();
BankAccount myAccount2 = new BankAccount();
BankAccount myAccount3 = new BankAccount();

//3 hesap oluşturun ve bunları depoya ekleyin.
myAccount.AccountNumber = 123456;
myAccount.FirstName = "James";
myAccount.LastName = "Nyoro";
myAccount.Balance = -27500.75;

myAccount2.AccountNumber = 789101;
myAccount2.FirstName = "Reggy";
myAccount2.LastName = "Waithera";
myAccount2.Balance = 23900.50;

myAccount3.AccountNumber = 852476;
myAccount3.FirstName = "Kevin";
myAccount3.LastName = "Maina";
myAccount3.Balance = 25850.25;

BankRepository bankRepository = new BankRepository();

bankRepository.AddAccount(myAccount);
bankRepository.AddAccount(myAccount2);
bankRepository.AddAccount(myAccount3);
Console.WriteLine("Accounts created");
PrintAllAccounts(bankRepository);

//Bir hesaba para yatırın ve diğer hesaptan para çekin.
bankRepository.DepositToAccount(1, 25000);
Console.WriteLine("Money deposited");
PrintAllAccounts(bankRepository);
bankRepository.WithdrawFromAccount(2, 5000);
Console.WriteLine("Money withdrawn");
PrintAllAccounts(bankRepository);

//Bir hesap sahibinin adını güncelleyin.
bankRepository.UpdateAccountName(3, "Michael", "Kiptoo");
Console.WriteLine("Name updated");
PrintAllAccounts(bankRepository);
bankRepository.UpdateAccountName(4, "Michael", "Kiptoo");
Console.WriteLine("Name updated");
PrintAllAccounts(bankRepository);

//Bir hesabı silin ve toplam sayının azaldığını onaylayın.
bankRepository.DeleteAccount(1);
Console.WriteLine("Accounts deleted");
PrintAllAccounts(bankRepository);

void PrintAllAccounts(BankRepository bankRepository)
{
    var accounts = bankRepository.GetAllAccounts();
    foreach (var account in accounts)
    {
        Console.WriteLine($"Account Number: {account.AccountNumber}, Name: {account.FirstName} {account.LastName}, Balance: {account.Balance}");
    }
}



