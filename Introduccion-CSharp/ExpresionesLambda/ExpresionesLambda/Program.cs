namespace ExpresionesLambda
{
    internal class Program
    {

        //Lambda, R f(x), f(x) flecha

        //Es una forma de escribir una f(x) anonima, que no necesita crearse, declararse, no tiene nombre
        //pero si tiene definido lo que hace, sirve para no crear f que se ejecutan una sola vez
        //o f(x) que van como parametro de f(x) de orden superior
        static void Main(string[] args)
        {
            //Lambda expression

            Func<int, int, int> sub = (int a, int b) => a - b;


            //es lo mismo que esto...
            int sub2(int a, int b)
            {
                return a - b;
            }

            //no es necesario aclarar el tipo de dato en los parentesis xq ya se paso en la f(x)
            //si hay una solo tipo de dato de entrada no es necesario el parentesis
            Func<int, int> algo = a => a * 2;


            //tmb se puede escribir varias lineas de codigo

            Func<int, int> algo2 = a =>
            {
                a = a + 1;
                return a * 5;
            };

            //esta expresion se guardo en una variable: sub, algo, algo2
            //asi se ejecuta

            sub(1,2);
            algo(3);
            algo2(5);

            //el mayor beneficio de las expresiones lambda es cuando tenes una f(x) que recibe f(x)
            //una f(x) de orden superior
            //ya que puedo mandar una expresion lambda como parametro

            void AlgunFunc(Func<int,int,int> funcion, int numero)
            {
                var resultado = funcion(numero, numero);
            }

            AlgunFunc((a, b)=>a + b, 5);

            //que hace esto?
            //void AlgunFunc(Func<int, int, int> funcion, 5)
            //{
            //    var resultado = funcion(5, 5);
            //}

            //AlgunFunc((5, 5) => 5 + 5, ...);

            //resultado = 5 + 5 = 10


        }
    }
}
