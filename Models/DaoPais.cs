using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
// Librerias
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace EF_Aaron_Mayhua_Najarro_POOII.Models
{
    public class DaoPais
    {
        static string cadena = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        private SqlConnection cn = new SqlConnection(cadena);

        // listado para el combo
        public List<Pais> listarPais()
        {
            List<Pais> listado = new List<Pais>();
            SqlCommand cmd = new SqlCommand("usp_listar_pais", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = null;
            try
            {
                cn.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    listado.Add(new Pais(
                        dr.GetString(0),dr.GetString(1)));
                }
            }catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                cn.Close();
                dr.Close();
                cmd.Dispose();
            }

            return listado;
        }
        
    }
}