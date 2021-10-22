// 利息つき口座
// ・月末の残高の 2% が振り込まれます。

namespace classes
{
  public class InterestEarningAccount : BankAccount
  {
    // コンストラクター
    public InterestEarningAccount(string name, decimal initialBalance) : base(name, initialBalance) 
    {
    }

    // 基底クラスの実装のオーバーライド
    public override void PerformMonthEndTransactions()
    {
        if (Balance > 500m)
        {
            var interest = Balance * 0.05m;
            MakeDeposit(interest, DateTime.Now, "apply monthly interest");
        }
    }
  }
}