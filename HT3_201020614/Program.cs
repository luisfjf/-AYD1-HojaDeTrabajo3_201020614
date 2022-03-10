using System;

namespace HT3_201020614
{
    /// <summary>
    /// Creación de la billeta virtual de un cliente
    /// </summary>
    public class Cliente
    {
        private readonly string nombre;
        private double disponible;

        private Cliente() { }

        public Cliente(string nombreCliente, double disponible)
        {
            nombre = nombreCliente;
            this.disponible = disponible;
        }

        public string NombreCliente
        {
            get { return nombre; }
        }

        public double Disponible
        {
            get { return disponible; }
        }

        public void Pagar(double cantidad)
        {
            if (cantidad > disponible)
            {
                throw new ArgumentOutOfRangeException("disponible");
            }

            if (cantidad < 0)
            {
                throw new ArgumentOutOfRangeException("disponible");
            }

            if (cantidad > 5000)
            {
                throw new ArgumentOutOfRangeException("cantidad");
            }

            disponible -= cantidad; // intentionally incorrect code
        }

        public void Acreditar(double cantidad)
        {
            if (cantidad < 0)
            {
                throw new ArgumentOutOfRangeException("cantidad");
            }

            disponible += cantidad;
        }

        public static void Main()
        {
            Cliente billetera = new Cliente("Luis Jimenez", 100);

            billetera.Acreditar(2000);
            billetera.Pagar(6000);
            Console.WriteLine("El saldo disponible es ${0}", billetera.disponible);
        }
    }
}
