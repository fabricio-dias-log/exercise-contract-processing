namespace ExerciseContractProcessing.Services;

public interface ITaxService
{
    public double Tax(double amount, int currentInstallment, int installment);
}