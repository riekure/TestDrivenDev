namespace TestDrivenDev
{
    public class Money
    {
        public int amount;

        public override bool Equals(object obj)
        {
            Money money = (Money) obj;
            return amount == money.amount && GetType() == money.GetType();
        }
    }
}