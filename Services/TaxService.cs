namespace ExerciseContractProcessing.Services;

public class TaxService : ITaxService
{
    public double Tax(double amount, int currentInstallment,int installment)
    {
        double totalValue = amount /installment;
        totalValue += (totalValue * 0.01) * currentInstallment;
        totalValue += totalValue * 0.02;

        return totalValue;
    }
}