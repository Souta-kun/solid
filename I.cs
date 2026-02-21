/*
 * Principio de segregacion de interfaces (ISP) - Interface Segregation Principle
 * Los clientes no deben verse obligados a depender de interfaces que no utilizan.
 */

namespace solid
{
    public interface ITrabajador
    {
        public void Trabajar();
        public void Dormir();
    }

    public class Robot : ITrabajador
    {
        public void Trabajar() => Console.WriteLine("El robot esta trabajando.");

        public void Dormir()
        {
            // Los robots no duermen
        }
    }

    public class Empleado : ITrabajador
    {
        public void Trabajar() => Console.WriteLine("El empleado esta trabajando.");

        public void Dormir() => Console.WriteLine("El empleado esta durmiendo.");
    }

    // Cumple con ISP
    public interface ITrabajador2
    {
        public void Trabajar();
    }

    public interface IDormidor
    {
        public void Dormir();
    }

    public class Robot2 : ITrabajador2
    {
        public void Trabajar() => Console.WriteLine("El robot esta trabajando.");
    }

    public class Empleado2 : ITrabajador2, IDormidor
    {
        public void Trabajar() => Console.WriteLine("El empleado esta trabajando.");

        public void Dormir() => Console.WriteLine("El empleado esta durmiendo.");
    }
}
