// ギフトカード口座。
// 1 回の預金で始まり、支払いのみが可能です。
// ・毎月 1 回、月の最終日に指定した金額を補充できます。

namespace classes
{
  public class GiftCardAccount : BankAccount
  {
    // コンストラクター
    private decimal _monthlyDeposit = 0m;
    public GiftCardAccount(string name, decimal initialBalance, decimal monthlyDeposit = 0) : base(name, initialBalance)
      => _monthlyDeposit = monthlyDeposit;
    
    // オーバーライド
    public override void PerformMonthEndTransactions()
    {
        if (_monthlyDeposit != 0)
        {
            MakeDeposit(_monthlyDeposit, DateTime.Now, "Add monthly deposit");
        }
    }
  }
}