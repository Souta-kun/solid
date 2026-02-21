/*
 * Principio de Responsabilidad Única (SRP) - Single Responsibility Principle
 * Una clase debe tener una, y solo una, razón para cambiar.
 */
namespace solid
{
    // No cumple
    public class Calculadora
    {
        public double Sumar(double a, double b) => a + b;

        public double Restar(double a, double b) => a - b;
    }

    // Cumple
    public class Sumador
    {
        public double Sumar(double a, double b) => a + b;
    }

    public class Restador
    {
        public double Restar(double a, double b) => a - b;
    }
}
