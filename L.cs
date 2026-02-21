/*
 * Principio Liskov (LSP) - Liskov Substitution Principle
 * Los objetos de una clase derivada deben poder sustituir a los objetos de la clase base
 */

namespace solid
{
    public abstract class Vehiculo
    {
        public abstract void Conducir();
    }

    public class Auto : Vehiculo
    {
        public override void Conducir() => Console.WriteLine("Conduciendo auto");
    }

    public class Camion : Vehiculo
    {
        public override void Conducir() => Console.WriteLine("Conduciendo camión");
    }

    public class Programa
    {
        public static void ProbarConduccion(Vehiculo vehiculo)
        {
            vehiculo.Conducir();
        }

        public static void Main(string[] args)
        {
            Vehiculo miAuto = new Auto();
            ProbarConduccion(miAuto); // Funciona bien

            Vehiculo miCamion = new Camion();
            ProbarConduccion(miCamion);  // Funciona bien

            Vehiculo miAvion = new Avion();
            ProbarConduccion(miAvion);   // Lanza excepción
        }
    }

    // Viola el principio de Liskov, ya que Avion no puede sustituir a Vehiculo correctamente
    public class Avion : Vehiculo
    {
        public override void Conducir() => throw new NotImplementedException("Un avión no puede conducir en tierra");
    }
}
