namespace _1.Creacion_de_Objetos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Formas de crear un objeto de una clase

            Clase unObjetoClase = new Clase("una Caracteristica Cualquiera");

            var otroObjetoClase = new Clase("Otra Caracteristica Cualquiera");

            Clase otroObjetoClaseMas = new(" Otra Caracteristica Cualquiera mas");

            //ejemplo de propiedad privada --> error no accesible debido a su nivel de proteccion
            //var propiedadPrivada = otroObjetoClase.DevolverValorPropiedadPrivada()


            var mostrarPropiedad = unObjetoClase.DevolverValorPropiedad();

            Console.WriteLine(mostrarPropiedad);
        }

        //1.Crear una clase con una propiedad
        //Los modificadores de acceso de un miembro pueden hacerlo accesible:
        // public -->  desde cualquier parte del código, sin restricciones
        // private --> solo dentro de la clase o estructura en la que se declara
        // protected --> dentro de la clase donde se declara y en las clases que heredan de ella

        //Los getter y setter:
        //Permiten --> get/obtener y set/modificar una propiedad


        class Clase
        {
            //a.Propiedades o Caracteristicas
            public string Propiedad { get; set; }
            private string _PropiedadPrivada;

            //b.Constructor: sirve para definir
            //el contenido que las propiedades pueden tener al crear un objeto

            public Clase (string propiedad)
            {
                this.Propiedad = propiedad;
                this._PropiedadPrivada = "Propiedad Privada";
            }

            //c.Comportamientos/Metodos

            public string DevolverValorPropiedad()
            {
                return "La propiedad es " + Propiedad;
            }

            private string DevolverValorPropiedadPrivada()
            {
                return "Esta es una " + _PropiedadPrivada;
            }


        }

    }
}
