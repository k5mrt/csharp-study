// オブジェクト指向プログラミング (C#)

using System;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // 口座を開く
            var account = new BankAccount("<name>", 1000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial balance.");

            // 引き出し
            account.MakeWithdrawal(500, DateTime.Now, "Rent payment");
            Console.WriteLine(account.Balance);
            // 預け入れ
            account.MakeDeposit(100, DateTime.Now, "Friend paid me back");
            Console.WriteLine(account.Balance);

            // Test: 口座開設時の残高は正の値
            // エラーがキャッチされる
            BankAccount invalidAccount;
            try
            {
                invalidAccount = new BankAccount("invalid", -55);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Exception caught creating account with negative balance");
                Console.WriteLine(e.ToString());
                return;
            }

            // Test: 残高が負になる場合
            // エラーがキャッチされる
            try
            {
                account.MakeWithdrawal(750, DateTime.Now, "Attempt to overdraw");
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("Exception caught trying to overdraw");
                Console.WriteLine(e.ToString());
            }
        }
    }
}