namespace Stragety;

public class InterestOperation(ITaxStragety taxStragety)
{
    private readonly ITaxStragety stragety = taxStragety;

    public double GetTax(double income) => stragety.CalculateTax(income);
}
