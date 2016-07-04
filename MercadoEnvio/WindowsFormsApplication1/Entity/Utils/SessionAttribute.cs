using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1.Entity.Utils
{
    static class SessionAttribute    {
        public static Usuario user { get; set; }
        public static Cliente clienteUser { get; set; }
        public static Empresa empresaUser { get; set; }
        public static int perfiles { get; set; }
        public static string fechaSistema { get; set; }
    }
}
