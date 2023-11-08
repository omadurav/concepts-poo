using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptsPOO
{
    public class ComissionEmployee : Employee
    {
        public float ComissionPercentaje { get; set; }
        public decimal Sales { get; set; }
        public override decimal GetValueToPay()
        {
            return Sales * (decimal)ComissionPercentaje;
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"\n\tCommision percentaje: {$"{ComissionPercentaje:P2}",18}" +
                $"\n\tSales...............: {$"{Sales:C2}",18}" +
                $"\n\tValue to pay........: {$"{GetValueToPay}",18}";
        }
    }
}
