using System.Text.Json;

namespace Serializacion_Deserializacion_objetos_JSON
{
    internal class Program
    {
        static void Main(string[] args)
        {


            var hernan = new Persona()
            {
                Nombre = "Hernan",
                Edad = 30,
            };


            //Serealizar un JSON
            //JsonSerializer es una clase
            //.Serialize es un metodo estatico (no necesita ser inicializado)
            string personaJSON = JsonSerializer.Serialize(hernan);

            Console.WriteLine(personaJSON);
            Console.WriteLine();

            //-------------------------------------------------------------------------


            //Deserealizar un JSON
            string miJSON = @"{
                ""Nombre"":""Hernan"",
                ""Edad"":30
            }";

            //Persona Juan = JsonSerializer.Deserialize<Persona>(miJSON);

            //Console.WriteLine(Juan.Nombre);
            //Console.WriteLine(Juan.Edad);


            // el ? despues de una clase o un objeto indica que este podria ser nulo
            Persona? Juan = JsonSerializer.Deserialize<Persona>(miJSON);

            Console.WriteLine(Juan?.Nombre);
            Console.WriteLine(Juan?.Edad);

            Console.ReadKey();
        }
    }

    public class Persona
    {
        public string? Nombre { get; set; }
        public int Edad { get; set; }

        //public static string Devolver() { return "Hola"};
        //public static string Devolver() => "Hola";
    }
}
