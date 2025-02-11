﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Datos
{
    public class Conexion
    {
            private string Servidor;
            private string Base;
            private string Usuario;
            private string Clave;
            private static Conexion Cn = null;

            private Conexion()
            {
                this.Servidor = "DESKTOP-C55CHJN";
                this.Base = "Inicio_de_Sesion";
                this.Usuario = "sa";
                this.Clave = "12345";
            }

            public SqlConnection CreaConexion()
            {
                SqlConnection cadena = new SqlConnection();
                try
                {
                    cadena.ConnectionString = "Server=" + this.Servidor + ";Database=" + this.Base +
                        ";User Id=" + this.Usuario + ";Password=" + this.Clave;
                }
                catch (Exception ex)
                {
                    cadena = null;
                    throw ex;
                }
                return cadena;
            }

            public static Conexion GetInstancia()
            {
                if (Cn == null)
                {
                    Cn = new Conexion();
                }
                return Cn;
            }


        }
    }

