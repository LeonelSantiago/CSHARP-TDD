using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;

namespace TaxesCalculatorTest
{

    /*
     ** Get VAT from the amount of a reservation. (16%)
     ** Get the state lodging tax from the amount of a reservation. 
     ** Get total reservation amount.
        Taxes to consider VAT (Value agregated tax), LAT (Lodging agregated tax).
        %VAT = 0.16
        %LAT = 0.03
        Reservation amount = 1550

         */
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void TaxesTest()
        {
            //Arrange
            var taxesCalculator = new TaxesCalculator();

            //Act
            decimal VAT = taxesCalculator.GetIVA(1550.00m);
            //Assert
            //VAT% = 16%
            //Reservation amount = 1550
            //1550.00 * 0.16 = 248.00

            Assert.AreEqual(248.00m, VAT);
        }

        [TestMethod]
        public void LATTest()
        {
            //Arrange
            var taxesCalculator = new TaxesCalculator();

            //Act
            decimal lat = taxesCalculator.GetISH(1550.00m, 0.03m);
            //Assert
            //LAT% = 3%
            //Reservation Amount = 1550
            //1550.00 * 0.03 = 46.50

            Assert.AreEqual(46.50m, lat);
        }

        [TestMethod]
        public void TotalReservationAmountTest()
        {
            //Arrange
            var taxesCalculator = new TaxesCalculator();

            //Act
            decimal vat = taxesCalculator.GetIVA(1550.00m);
            decimal lat = taxesCalculator.GetISH(1550.00m, 0.03m);
            decimal totalReservationAmount = taxesCalculator.GetTotalReservationAmount(vat, lat, 1550m);

            //Assert
            //VAT = 248
            //LAT = 46.5
            //Reservation Amount = 1550
            //1550.00 + 248 + 46.5 = 1844.5

            Assert.AreEqual(1844.5m, totalReservationAmount);
        }
    }
}
