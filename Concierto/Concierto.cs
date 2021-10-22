using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concierto
{
    public class CONCIERTO
    {
        // propiedades
        /*
            NroEntrada       
            Sector     
            Precio       
            TipoComprador
            Cantidad
            Subtotal
            Descuento
            TotalPago
        */
        public string NroEntrada { get; set; }
        public string Sector { get; set; }
        public decimal Precio { get; set; }
        public string TipoComprador { get; set; }
        public int Cantidad { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Descuento { get; set; }
        public decimal TotalPago { get; set; }

        // método para obtener el precio
        public decimal ObtenerPrecio(string xSector)
        {
            decimal xprecio = 0;
            //
            switch (xSector)
            {
                case "GENERAL": xprecio = 98; break;
                case "VIP": xprecio = 165; break;
                case "PLATINUM LATERAL": xprecio = 228; break;
                case "PLATINUM CENTRAL": xprecio = 275; break;
                default:
                    break;
            }
            return xprecio;
        }

        public decimal ObtenerSubTotal(decimal xPrecio, int xCantidad)
        {
            decimal xsubtotal = 0;

            xsubtotal = xPrecio * xCantidad;
            
            return xsubtotal;
        }

        // método para calcular el Descuento x Tipo Comprador
        public decimal CalcularDescuentoxTipoComprador(string xTipoComprador, decimal xSubTotal)
        {
            decimal xdescuento = 0;
            switch (xTipoComprador)
            {
                case "ESTUDIANTE": xdescuento = xSubTotal * (8 / 100.0M); break;
                case "BOMBERO": xdescuento = xSubTotal * (5 / 100.0M); break;
                case "NORMAL": xdescuento = 0; break;
                default:
                    break;
            }

            return xdescuento;
        }

        // método para calcular el Total
        public decimal CalcularTotalPago(decimal xSubTotal, decimal xDescuento)
        {
            decimal xTotal = xSubTotal - xDescuento;
            return xTotal;
        }

        // constructor(es)
        public CONCIERTO() { }

        public CONCIERTO(string xNroEntrada, string xSector, string xTipoComprador, int xCantidad)
        {
            NroEntrada = xNroEntrada;
            Sector = xSector;
            TipoComprador = xTipoComprador;
            Cantidad = xCantidad;
            //
            Precio = ObtenerPrecio(Sector);
            Subtotal = ObtenerSubTotal(Precio, Cantidad);
            Descuento = CalcularDescuentoxTipoComprador(TipoComprador, Subtotal);
            TotalPago = CalcularTotalPago(Subtotal, Descuento);
        }

    }
}

