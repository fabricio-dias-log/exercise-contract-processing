namespace ExerciseContractProcessing.Entities;

public class Contract
{
    public int Number { get; set; }
    public DateOnly Date { get; set; }
    public double Value { get; set; }



    public Contract(int number, DateOnly date, double value)
    {
        Number = number;
        Date = date;
        Value = value;
    }
}