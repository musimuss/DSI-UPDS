using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using modelo;
using System.Data;
using System.Data.SqlClient;

namespace CAAPoral.modelo
{
    class Pagos
    {
        private string tabla;
        public int id { get; set; }
        public int id_fraterno { get; set; }
        public DateTime fecha { get; set; }
        public decimal acuenta { get; set; }
        public decimal saldo { get; set; }
        public Pagos()
        {
            tabla = "tbpago";
        }
        public bool Add(DBModelo conexion)
        {
            if (Registro(General.conexion) > 0)
            {
                return false;
            }
            else
            {
                conexion.open();
                List<SqlParameter> data = new List<SqlParameter>();
                data.Add(new SqlParameter() { ParameterName = "id_fraterno", Value = id_fraterno });
                data.Add(new SqlParameter() { ParameterName = "fecha", Value = fecha });
                data.Add(new SqlParameter() { ParameterName = "acuenta", Value = acuenta });
                

                int? x = conexion.querySimple("INSERT INTO " + tabla + "(id_fraterno,fecha,acuenta) " +
                " VALUES(@id_fraterno,@fecha,@acuenta)", data);
                conexion.close();
                return x > 0 || x == null ? true : false;
            }
        }
        public int Registro(DBModelo conexion)
        {
            SqlCommand comand = new SqlCommand("SELECT COUNT(*) FROM " + tabla + " WHERE id_fraterno=" + id_fraterno + ";", conexion.conectar);
            conexion.open();
            int contar = (int)comand.ExecuteScalar();
            conexion.close();
            return contar;
        }
        public DataTable Select(int id,DBModelo conexion)
        {
            List<SqlParameter> datos = new List<SqlParameter>();
            datos.Add(new SqlParameter() { ParameterName = "buscar", Value = id });
            conexion.open();
            DataTable t = conexion.query("SELECT * FROM " + tabla + " t1 " +
                " INNER JOIN tbfraterno t2 ON t1.id_fraterno = t2.id " + " " +
                " INNER JOIN tbpersona t3 ON t2.id = t3.id WHERE t1.fecha = '" + id + "' ORDER BY t1.id; ", null);
            conexion.close();
            return t;
        }

    }
}
