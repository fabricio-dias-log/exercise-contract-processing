using ExerciseContractProcessing.Entities;

namespace ExerciseContractProcessing.Services;

public class PaymentService
{
    private ITaxService _taxService;

    public PaymentService(ITaxService taxService)
    {
        _taxService = taxService;
    }

    public void ProcessingContract(Contract contract, int installments)
    {
        for (int i = 1; i <= installments; i++)
        {
            DateOnly installmentDate = contract.Date.AddMonths(i);
            double installmentValue = _taxService.Tax(contract.Value, i, installments);

            Installments installment = new Installments(installmentValue, installmentDate);
            contract.InstallmentsList.Add(installment);
        }
    }
}