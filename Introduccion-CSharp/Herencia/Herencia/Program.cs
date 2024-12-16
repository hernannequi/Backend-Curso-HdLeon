using System.Globalization;
using System.Timers;

namespace Herencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ventaConImpuestos = new VentaConImpuesto(15, 1.16m);

            var mensaje = ventaConImpuestos.ObtenerInfo();

            Console.WriteLine(mensaje);
        }


        //Clase Hija
        class VentaConImpuesto : Venta
        {
            public decimal Impuesto { get; set; }

            public VentaConImpuesto(decimal total, decimal impuesto) : base(total)
            {
                Impuesto = impuesto;
            }

            //Nuevo Metodo usando los valores heredados
            public string ObtenerInfoConImpuesto()
            {
                return "El total es: " + Total + "\nEl impuesto es: " + Impuesto;
            }

            //Sobreescritura de Metodos
            public override string ObtenerInfo()
            {
                return "El total es: " + Total + "\nEl impuesto es: " + Impuesto;
            }

            //Sobrecarga de Metodos

            public string ObtenerInfo(string mensaje)
            {
                return mensaje;
            }



        }

        //Clase Padre
        class Venta
        {
            public decimal Total { get; set; }
            public Venta(decimal total)
            {
                this.Total = total;
            }


            //La palabra reservada virtual permite la Sobreescritura de Metodos
            public virtual string ObtenerInfo()
            {
                return "El total es: " + Total;
            }

            private string ObtnerInfoPrivado()
            {
                return "El total es: " + Total;
            }

            protected String ObtenerInfoProtegida()
            {
                return "El total es: " + Total;
            }
        }
    }
}
