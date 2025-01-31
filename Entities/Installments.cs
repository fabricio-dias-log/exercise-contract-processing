namespace ExerciseContractProcessing.Entities;

public class Installments
{
    public double Value { get; set; }
    public DateOnly Date { get; set; }

    public Installments(double value, DateOnly date)
    {
        Value = value;
        Date = date;
    }
}