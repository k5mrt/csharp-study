using System;
using System.Collections.Generic; // List<T> クラスでは、別の名前空間をインポートする必要がある

// コードを論理的に整理
namespace classes
{
    // クラスまたは型を定義
    public class BankAccount
    {
        // データメンバー
        // private: BankAccountクラス内のコードのみがアクセス可能
        // static: 全てのBankAccountオブジェクトに共有
        private static int accountNumberSeed = 1234567890;

        // メンバー：3つプロパティ
        public string Number { get; }
        public string Owner { get; set; }
        public decimal Balance
        {
            get
            {
                decimal balance = 0;
                foreach (var item in allTransactions)
                {
                    balance += item.Amount;
                }

                return balance;
            }
        }

        // コンストラクター
        // クラスと同じ名前を持つメンバー。そのクラス型のオブジェクトを初期化。
        public BankAccount(string name, decimal initialBalance)
        {
            tthis.Number = accountNumberSeed.ToString();
            accountNumberSeed++;

            this.Owner = name;
            MakeDeposit(initialBalance, DateTime.Now, "Initial balance");
        }

        // メンバー：TransactionオブジェクトのList<T>を追加
        private List<Transaction> allTransactions = new List<Transaction>();

        // メンバー：MakeDepositメソッド
        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
            }
            var deposit = new Transaction(amount, date, note);
            allTransactions.Add(deposit);
        }

        // メンバー：MakeWithdrawalメソッド
        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive");
            }
            if (Balance - amount < 0)
            {
                throw new InvalidOperationException("Not sufficient funds for this withdrawal");
            }
            var withdrawal = new Transaction(-amount, date, note);
            allTransactions.Add(withdrawal);
        }

        // メンバー：GetAccountHistoryメソッド
        // トランザクション履歴の string を作成
        public string GetAccountHistory()
        {
            var report = new System.Text.StringBuilder();

            decimal balance = 0;
            report.AppendLine("Date\t\tAmount\tBalance\tNote");
            foreach (var item in allTransactions)
            {
                balance += item.Amount;
                report.AppendLine($"{item.Date.ToShortDateString()}\t{item.Amount}\t{balance}\t{item.Notes}");
            }

            return report.ToString();
        }
    }
}