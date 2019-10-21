namespace TestDrivenDev
{
    public abstract class Money
    {
        public int amount;

        public abstract Money Times(int multiplier);
        
        public override bool Equals(object obj)
        {
            Money money = (Money) obj;
            return amount == money.amount && GetType() == money.GetType();
        }

        static public Dollar _Dollar(int amount)
        {
            return new Dollar(amount);
        }

        static public Franc _Frunc(int amount)
        {
            return new Franc(amount);
        }
    }
}