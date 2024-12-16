namespace ProgamacionFuncional
{
    internal class Program
    {

        //Action f(x) que no retorna nada(void)

        //Func f(x) que retorna algo

        static void Main(string[] args)
        {
            //Programacion Funcional
                //Funcion Pura --> Si envio el mismo valor la f(x) siempre retorna lo mismo
                //             --> No deberia alterar un elemento exterior a la funcion
            int Sub(int a, int b)
            {
                return a - b;
            }


            //DateTime es un struct, es un elemento que se pasa por valor no por referencia como pasa en los objetos
            //no altera el objeto

            //esta funcion regresa el dia de mañana, no es pura porque para cada dia retorna valor diferente
            DateTime DevolverManiana()
            {
                return DateTime.Now.AddDays(1);
            }



            //Esta si es una funcion pura porque dada la misma entrada devuelve el mismo valor

            DateTime DevolverManianaParametro(DateTime dia)
            {
                return dia.AddDays(1);
            }


            
            var cerveza = new Cerveza()
            {
                Nombre = "Schneider"
            };

            Console.WriteLine(ToUpper(cerveza).Nombre);
            Console.WriteLine(cerveza.Nombre);


            //una funcion no deberia modificar un elemento externo como la variable cerveza Schneider 
            //Cerveza ToUpper(Cerveza cerveza)
            //{
            //    cerveza.Nombre = cerveza.Nombre.ToUpper();
            //    return cerveza;
            //}



            //entonces podemos optar por la tecnica de clonar el elemento
            //o usar el elemento record que es inmutable y no puede modificarse
            //en vez de modificar, clona al elemento


            Cerveza ToUpper(Cerveza cerveza)
            {
                var cerveza2 = new Cerveza()
                {
                    Nombre = cerveza.Nombre.ToUpper(),
                };

                return cerveza2;
            }





            //Funcion de primera clase:
            //Una f(x) puede guardarse en una variable
            //Se puede usar la variable para ejecutar la f(x)

            var mostrar = Mostrar;

            //mostrar("Hola");

            void Mostrar(string mensaje)
            {
                Console.WriteLine(mensaje);
            }

            
            
            Alguna(mostrar, "Hola, como estas");

            //una f(x) se puede mandar como parametro
            //El tipo Action es una f(x) que recibe elementos pero NO RETORNA NADA (es tipo void)
            //Puede recibir uno o mas tipos de datos asi: Action<T,T,T...> action
            //f(x) Alguna --> es una f(x) de orden superior, recibe f(x) como parametro
            
            void Alguna(Action<string> funcion, string mensaje)
            {
                Console.WriteLine("Hace algo al inicio");
                funcion(mensaje);

                //Esto se llama callback, hacer algo cuando la funcion termnie
                Console.WriteLine("Hace algo al final");

            }



            //Func sirve para especificar el tipo de dato de entrada y salida y crear una f(x) que RETORNA algo

            void Algo(Func<string, string> funcion, string mensaje)
            {
                Console.WriteLine("Hace algo al inicio");
                //puedo imprimirlo o guardar en una variable
                Console.WriteLine(funcion(mensaje));
                Console.WriteLine("Hace algo al final");
            }

            string MostrarFunc(string mensaje)
            {
                return mensaje.ToUpper();
            }


            var mostrarFunc = MostrarFunc;

            Algo(mostrarFunc, "Hola como estas");
        }



        public class Cerveza
        {
            public string Nombre { get; set; }
        }


    }
}
