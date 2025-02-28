namespace POOConcepts;

public class Invoice : IPay
{
    private float _quantity;
    private decimal _value;

    public Invoice(int id, string description, Date date, decimal value, float quantity)
    {
        Id = id;
        Description = description;
        Date = date;
        Value = value;
        Quantity = quantity;
    }

    public int Id { get; set; }
    public string Description { get; set; } = null!;
    public Date Date { get; set; } = null!;
    public decimal Value { get => _value; set => _value = ValidateValue(value); }
    public float Quantity { get => _quantity; set => _quantity = ValidateQuantity(value); }

    public override string ToString()
    {
        return $"{Id}\t{Description}\n\t" +
            $"Date...........: {Date,20}\n\t" +
            $"Quantity.......: {Quantity,20:N2}\n\t" +
            $"Value..........: {Value,20:C2}\n\t" +
            $"To pay.........: {GetValueToPay(),20:C2}";
    }

    public decimal GetValueToPay()
    {
        return (decimal)Quantity * Value;
    }

    private float ValidateQuantity(float quantity)
    {
        if (quantity < 0)
        {
            throw new Exception($"The quantity: {quantity}, is not valid.");
        }
        return quantity;
    }

    private decimal ValidateValue(decimal value)
    {
        if (value < 0)
        {
            throw new Exception($"The value: {value}, is not valid.");
        }
        return value;
    }
}