namespace TestDrivenDev
{
    public interface IExpression
    {
        IExpression Times(int multiplier);
        IExpression Plus(IExpression added);
        Money Reduce(Bank bank, string to);
    }
}