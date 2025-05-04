using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alquilando.Aplicacion.Entidades
{
    public class TarjetaCredito
    {
		public int id { get; set; }
		private double nro { get; set; }
        private DateOnly vencimiento { get; set; }
        private double cdoSeguridad { get; set; }
    }
}
