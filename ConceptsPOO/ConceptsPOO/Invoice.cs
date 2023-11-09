using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptsPOO
{
    public class Invoice : IPay
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public float Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal GetValueToPay()
        {
            return (decimal)Quantity * Price;
        }

        public override string ToString()
        {
            return $"Description: {Description}" +
                $"\n\tQuantity................: {$"{Quantity}",18}" +
                $"\n\tPrice...................: {$"{Price:C2}",18}" +
                $"\n\tTotal...................: {$"{GetValueToPay():C2}",18}";
        }
    }
}
