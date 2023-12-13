using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Sol_PuntoVenta.Datos;
using Sol_PuntoVenta.Entidades;

namespace Sol_PuntoVenta.Negocio
{
    public class N_Familias
    {
        public static DataTable Litado_fa(string cTexto)
        {
            D_Familia Datos = new D_Familia();
            return Datos.Listado_fa(cTexto);
        }

        public static string Guardar_fa(int nOpcion, E_Familias oPropiedad)
        {
            D_Familia Datos = new D_Familia();
            return Datos.Guardar_fa(nOpcion, oPropiedad);
        }

        public static string Eliminar_fa(int nCodigo)
        {
            D_Familia Datos = new D_Familia();
            return Datos.Eliminar_fa(nCodigo);
        }
    }
}
