using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace bookflow
{
    class ClaseConexion
    {
        SqlConnection conexion = new SqlConnection(
        @"Data Source=DESKTOP-IITRQ04\SQLEXPRESS;
        Initial Catalog=BookFlow;
        Integrated Security=True");
        SqlCommand comando;
        SqlDataAdapter adaptador;
        DataSet datos;

        public DataSet Consultar(string consulta)
        {
            datos = new DataSet();

            try
            {
                conexion.Open();

                adaptador = new SqlDataAdapter(consulta, conexion);
                adaptador.Fill(datos);

                conexion.Close();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            return datos;
        }
        public bool ABM(string consulta)
        {
            bool resultado = false;

            try
            {
                conexion.Open();

                comando = new SqlCommand(consulta, conexion);
                comando.ExecuteNonQuery();

                conexion.Close();

                resultado = true;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            return resultado;
        }
    }
}
