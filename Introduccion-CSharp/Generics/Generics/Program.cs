using System.Reflection;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numeros = new MiLista<int>(5);
            var nombres = new MiLista<string>(4);
            var cervezas = new MiLista<Cerveza>(3);


            numeros.Agregar(1);
            numeros.Agregar(2);
            numeros.Agregar(3);
            numeros.Agregar(4);
            numeros.Agregar(5);
            numeros.Agregar(6);

            nombres.Agregar("Pablo");
            nombres.Agregar("Marta");
            nombres.Agregar("Luis");
            nombres.Agregar("Carlos");
            nombres.Agregar("Beatriz");
            nombres.Agregar("Roman");


            //podemos crear objetos sin guardarlos en una variable

            cervezas.Agregar(
                new Cerveza() {
                    Nombre = "Quilmes",
                    Precio = 5
                });

            cervezas.Agregar(
                new Cerveza(){
                    Nombre = "Brahma",
                    Precio = 10
            });
            cervezas.Agregar(
                new Cerveza()
                {
                    Nombre = "Schneider",
                    Precio =  7  
                });

            cervezas.Agregar(
                new Cerveza()
                {
                    Nombre = "Andes Origen",
                    Precio = 3
                });


            Console.WriteLine(numeros.DevolverContenido());
            Console.WriteLine(nombres.DevolverContenido());
            Console.WriteLine(cervezas.DevolverContenido());

            Console.ReadKey();
        }


    }

    public class Cerveza
    {
        public string Nombre { get; set; }
        public decimal Precio { get; set; }


        public override string ToString()
        {
            return $"{Nombre}: ${Precio}";
        }
    }

    public class MiLista<T>
    {
        private List<T> _Lista;
        private int _Tamanio;

        public MiLista(int tamanio)
        {
            _Lista = new List<T>();
            _Tamanio = tamanio;
        }

        public void Agregar(T elemento)
        {
            if (_Lista.Count < _Tamanio)
            {
                _Lista.Add(elemento);
            }
        }


        public string DevolverContenido()
        {

            string contenido = "";

            foreach (var elemento in _Lista)
            {
                contenido += elemento + ", ";
            }

            return contenido;
        }
    }


}
