namespace Stragety;

public class InterestOperation
{
    private readonly ITaxStragety stragety;

    public InterestOperation(ITaxStragety taxStragety) => stragety = taxStragety;

    public double GetTax(double income) => stragety.CalculateTax(income);
}
