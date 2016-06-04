using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    public class DateUtils
    {
        private static IFormatProvider Culture = new System.Globalization.CultureInfo("es-AR", true);

        public static  DateTime convertirStringEnFecha(String fecha)  {
            DateTime fehaSistema = DateTime.ParseExact(fecha, "dd/MM/yyyy", Culture);
            return fehaSistema;
        }

        
    }
}
