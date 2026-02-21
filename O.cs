/*
 * Principio de abierto cerrado (OCP) - Open/Closed Principle
 * Las entidades de software (clases, módulos, funciones, etc.) deben estar abiertas para
 * la extensión, pero cerradas para la modificación.
 */

namespace solid
{
    // No cumple
    public class CalculadoraDescuento
    {
        public double AplicarDescuento(double precion, string tipoProducto)
        {
            if (tipoProducto == "Electrónica")
            {
                return precion * 0.9; // 10% de descuento
            }
            else if (tipoProducto == "Ropa")
            {
                return precion * 0.8; // 20% de descuento
            }
            else
            {
                return precion; // Sin descuento
            }
        }
    }

    // Cumple
    public interface IDescuento
    {
        double AplicarDescuento(double precio);
    }

    public class DescuentoElectronico : IDescuento
    {
        public double AplicarDescuento(double precio)
        {
            return precio * 0.9; // 10% de descuento
        }
    }

    public class DescuentoRopa : IDescuento
    {
        public double AplicarDescuento(double precio)
        {
            return precio * 0.8; // 20% de descuento
        }
    }

    public class SinDescuento : IDescuento
    {
        public double AplicarDescuento(double precio)
        {
            return precio; // Sin descuento
        }
    }

    public class CalculadoraDescuentoMejorada
    {
        public double CalcularConDescuento(IDescuento descuento, double precio)
        {
            return descuento.AplicarDescuento(precio);
        }
    }
}
