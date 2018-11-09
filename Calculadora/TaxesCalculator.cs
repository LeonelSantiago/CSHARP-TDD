using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class TaxesCalculator
    {
        const decimal ivaPercent = 0.16m;

        public decimal GetIVA(decimal reservationAmount)
        {
            return ivaPercent * reservationAmount;
        }
        public decimal GetISH(decimal reservationAmount, decimal percent)
        {
            return reservationAmount * percent;
        }

        public decimal GetTotalReservationAmount(decimal iva, decimal ish, decimal reservationAmount)
        {
            return iva + ish + reservationAmount;
        }
    }
}
