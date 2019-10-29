namespace TestDrivenDev
{
    public interface IExpression
    {
        IExpression Plus(IExpression added);
        Money Reduce(Bank bank, string to);
    }
}