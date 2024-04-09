using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
// librerias
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace EF_Aaron_Mayhua_Najarro_POOII.Models
{
    public class DaoPasajero
    {
        static string cadena = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        private SqlConnection cn = new SqlConnection(cadena);
        SqlTransaction tran;

        // Formulario Crear Nuevos Pasajeros
        public string CrearPasajero(Pasajero bean)
        {
            string mensaje = null;
            SqlCommand cmd = new SqlCommand("usp_crear_pasajero", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nombre", bean.nombre);
            cmd.Parameters.AddWithValue("@aPaterno", bean.aPaterno);
            cmd.Parameters.AddWithValue("@aMaterno", bean.aMaterno);
            cmd.Parameters.AddWithValue("@tipo_documento", bean.tipoDocumento);
            cmd.Parameters.AddWithValue("@num_documento", bean.numDocumento);
            cmd.Parameters.AddWithValue("@fecha_nacimiento", bean.fechaNacimiento);
            cmd.Parameters.AddWithValue("@idPais", bean.nombrePais);
            cmd.Parameters.AddWithValue("@telefono", bean.telefono);
            cmd.Parameters.AddWithValue("@email", bean.email);
            try
            {
                cn.Open();
                tran = cn.BeginTransaction();
                cmd.Transaction = tran;
                cmd.ExecuteNonQuery();
                tran.Commit();
                mensaje = "!Registro de Pasajero Exitoso¡";
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
                tran.Rollback();
            }
            finally
            {
                cmd.Dispose();
                cn.Close();
            }
            return mensaje;
        }
    }
}