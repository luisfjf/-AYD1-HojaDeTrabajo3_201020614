using NUnit.Framework;

using HT3_201020614;

namespace TestBilletera
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Debit_WithValidAmount_UpdatesBalance()
        {
            // Arrange
            double beginningBalance = 11.99;
            double debitAmount = 4.55;
            double expected = 7.44;
            Cliente billetera = new Cliente("Mr. Bryan Walton", beginningBalance);

            // Act
            billetera.Pagar(debitAmount);

            // Assert
            double actual = billetera.Disponible;
            Assert.AreEqual(expected, actual, 0.001, "Account not debited correctly");
        }

        [Test]
        public void Pagar_CuandoMontoMayorA5000()
        {
            // Arrange
            double saldoInicial = 1500;
            double montoPagar = 6000;
            Cliente billetera = new Cliente("Luis Jimenez", saldoInicial);

            // Act and assert
            Assert.Throws<System.ArgumentOutOfRangeException>(() => billetera.Pagar(montoPagar));
        }


    }
}