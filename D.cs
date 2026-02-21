
/*
 * Principio de inversion de dependencias (DIP) - Dependency Inversion Principle
 * Los módulos de alto nivel no deben depender de módulos de bajo nivel.
 * Ambos deben depender de abstracciones.
 * 
 * 'Indica que se debe' depender de abstracciones en lugar de implementaciones concretas.
 */

namespace solid;

public class D
{
    // Abstraccion comun para naves espaciales
    public interface INaveEspacial
    {
        void Despegar();
        void Aterrizar();
    }

    public class SistemaControlNaves
    {
        private readonly INaveEspacial nave;

        public SistemaControlNaves(INaveEspacial nave)
        {
            this.nave = nave;
        }

        public void OperarNave()
        {
            nave.Despegar();
            nave.Aterrizar();
        }
    }

    // Modulo de bajo nivel
    public class NaveCaza : INaveEspacial
    {
        public void Aterrizar() => Console.WriteLine("Nave caza aterrizando.");
        public void Despegar() => Console.WriteLine("Nave caza despegando.");
    }

    public class NaveRecolectora : INaveEspacial
    {
        public void Aterrizar() => Console.WriteLine("Nave recolectora aterrizando.");
        public void Despegar() => Console.WriteLine("Nave recolectora despegando.");
    }
}
