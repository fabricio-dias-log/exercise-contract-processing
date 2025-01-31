using ExerciseContractProcessing.Entities;

namespace ExerciseContractProcessing.Services;

public class PaymentService
{
    private ITaxService _taxService;

    public PaymentService(ITaxService taxService)
    {
        _taxService = taxService;
    }

}