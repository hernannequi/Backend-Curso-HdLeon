namespace Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            var venta = new Venta();
            var bebida = new Bebida();

            Algo(venta);
            Algo(bebida);
        }

        static void Algo(IGuardar guardar)
        {
            guardar.Guardar();
        }
        //Las interfaces establecen las firmas/nombres
        //de caracteristicas y comportamientos (propiedades y metodos)
        //que una clase esta obligada a aplicar
        interface IVenta
        {
            public decimal Total { get; set; }
        }
         interface IGuardar
        {
            public void Guardar();
        }

        //A una clase se le puede aplicar una o mas interfaces 
        class Venta : IVenta, IGuardar
        {
            public decimal Total { get; set; }
            public void Guardar()
            {
                Console.WriteLine("Se guardo correctamente!");
            }

        }

        class Bebida : IGuardar
        {
            public void Guardar()
            {
                Console.WriteLine("Se guardo la Bebida correctamente");
            }
        }


        //puedo pasar como parametro una implementacion de una interface a una funcion
        //obligandola a aplicar las firmas de las propiedades y metodos declarados en la interface previamente
        //permitiendo recibir como parametro a cualquier clase que haya aplicado esta interface
        

        
    }
}
