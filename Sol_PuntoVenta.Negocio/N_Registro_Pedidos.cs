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
    public class N_Registro_Pedidos
    {
        public static DataTable Listado_pv(string cTexto)
        {
            D_Registro_Pedidos Datos = new D_Registro_Pedidos();
            return Datos.Listado_pv(cTexto);
        }
        public static DataTable Estado_Turno_pv(int nCodigo_pv)
        {
            D_Registro_Pedidos Datos = new D_Registro_Pedidos();
            return Datos.Estado_Turno_pv(nCodigo_pv);
        }
    }
}
