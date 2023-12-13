﻿using System;
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
    public class N_SubFamilias
    {
        public static DataTable Litado_sf(string cTexto)
        {
            D_SubFamilia Datos = new D_SubFamilia();
            return Datos.Listado_sf(cTexto);
        }

        public static string Guardar_sf(int nOpcion, E_SubFamilias oPropiedad)
        {
            D_SubFamilia Datos = new D_SubFamilia();
            return Datos.Guardar_sf(nOpcion, oPropiedad);
        }

        public static string Eliminar_sf(int nCodigo)
        {
            D_SubFamilia Datos = new D_SubFamilia();
            return Datos.Eliminar_sf(nCodigo);
        }

        public static DataTable Litado_fa(string cTexto)
        {
            D_SubFamilia Datos = new D_SubFamilia();
            return Datos.Listado_fa(cTexto);
        }
    }
}
