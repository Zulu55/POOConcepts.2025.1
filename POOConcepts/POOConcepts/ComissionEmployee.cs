using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOConcepts;

public class ComissionEmployee : Employee
{
    private float _comissionPercentaje;
    private decimal _sales;

    public ComissionEmployee(int id, string firstName, string lastName, bool isActive, Date? bornDate, Date? hireDate, float comissionPercentaje, decimal sales) : base(id, firstName, lastName, isActive, bornDate, hireDate)
    {
        ComissionPercentaje = comissionPercentaje;
        Sales = sales;
    }

    public float ComissionPercentaje { get => _comissionPercentaje; set => _comissionPercentaje = ValidateComissionPercentaje(value); }
    public decimal Sales { get => _sales; set => _sales = ValidateSales(value); }

    public override string ToString()
    {
        return $"{base.ToString()}\n\t" +
            $"Commision %....: {ComissionPercentaje,20:P2}\n\t" +
            $"Sales..........: {Sales,20:C2}\n\t" +
            $"Value to pay...: {GetValueToPay(),20:C2}";
    }

    public override decimal GetValueToPay()
    {
        return (decimal)_comissionPercentaje * _sales;
    }

    private float ValidateComissionPercentaje(float comissionPercentaje)
    {
        if (comissionPercentaje < 0 || comissionPercentaje > 0.3)
        {
            throw new Exception($"The comission percentaje: {comissionPercentaje:P2}, is not valid.");
        }
        return comissionPercentaje;
    }

    private decimal ValidateSales(decimal sales)
    {
        if (sales < 0)
        {
            throw new Exception($"The sales: {sales:C2}, is less than $0.00.");
        }
        return sales;
    }
}