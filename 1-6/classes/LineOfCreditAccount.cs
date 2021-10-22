// 与信枠
// ・残高を負の値にすることができますが、与信限度額よりも絶対値を大きくすることはできません。
// ・月末の残高が 0 ではない場合は、毎月利息を請求されます。
// ・与信限度額を超えた引き出しごとに手数料が発生します。

namespace classes
{
  public class LineOfCreditAccount : BankAccount
  {
    // コンストラクター
    public LineOfCreditAccount(string name, decimal initialBalance, decimal creditLimit) : base(name, initialBalance, -creditLimit)
    {
    }

    // オーバーライド
    public override void PerformMonthEndTransactions()
    {
        if (Balance < 0)
        {
            // Negate the balance to get a positive interest charge:
            var interest = -Balance * 0.07m;
            MakeWithdrawal(interest, DateTime.Now, "Charge monthly interest");
        }
    }

    protected override Transaction? CheckWithdrawalLimit(bool isOverdrawn)
      => isOverdrawn
      ? new Transaction(-20, DateTime.Now, "Apply overdraft fee")
      : default;
  }
}