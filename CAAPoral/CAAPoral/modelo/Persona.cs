using modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAAPoral.modelo
{
    public class Persona
    {

        public int id { get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public string ci { get; set; }
        public int estado { get; set; }
        private string tabla;
        public Usuario usuario { get; set; }
        public Persona()
        {

            tabla = "tbpersona";
        }
        public bool Add()
        {
            //....
            return true;
        }
        public bool Add(DBModelo conexion)
        {
            conexion.open();
            List<SqlParameter> datos = new List<SqlParameter>();
            datos.Add(new SqlParameter() { ParameterName = "nombre", Value = nombre });
            datos.Add(new SqlParameter() { ParameterName = "apellidos", Value = apellidos });
            datos.Add(new SqlParameter() { ParameterName = "ci", Value = ci });
            datos.Add(new SqlParameter() { ParameterName = "estado", Value = 1 });

            int? x = conexion.querySimple("insert into " + tabla + "(nombre,apellidos,ci) " +
                "values (@nombre,@apellidos,@ci)", datos);
            DataTable t= conexion.query("select IDENT_CURRENT('"+tabla+"') as id");
            conexion.close();

            this.estado= 1;
            int id_;
            int.TryParse(t.Rows[0]["id"].ToString(),out id_);
            this.id = id_;
            return x > 0 || x == null ? true : false;
        }
        public bool Edit(DBModelo conexion)
        {
            conexion.open();
            List<SqlParameter> datos = new List<SqlParameter>();
            datos.Add(new SqlParameter() { ParameterName = "nombre", Value = nombre });
            datos.Add(new SqlParameter() { ParameterName = "apellidos", Value = apellidos });
            datos.Add(new SqlParameter() { ParameterName = "ci", Value = ci });
            datos.Add(new SqlParameter() { ParameterName = "id", Value = id });

            int? x = conexion.querySimple("update " + tabla + " set nombre=@nombre,apellidos=@apellidos,ci=@ci " +
               "where id=@id", datos);
            conexion.close();
            return x > 0 || x == null ? true : false;
        }
        public bool Delete(DBModelo conexion)
        {
            conexion.open();
            List<SqlParameter> datos = new List<SqlParameter>();
            datos.Add(new SqlParameter() { ParameterName = "id", Value = id });

            int? x = conexion.querySimple("update " + tabla + " set estado=0 " +
               "where id=@id", datos);
            conexion.close();
            return x > 0 || x == null ? true : false;
        }
        public List<Persona> Select(DBModelo conexion)
        {
            conexion.open();
            DataTable t = conexion.query("select * from  " + tabla + " where estado=1 "
                    , null);
            conexion.close();
            List<Persona> lista = new List<Persona>();
            for (int i = 0; i < t.Rows.Count; i++)
            {
                lista.Add(new Persona()
                {
                    id = (int)t.Rows[i]["id"],
                    estado = (int)t.Rows[i]["estado"],
                    apellidos = t.Rows[i]["apellidos"].ToString(),
                    nombre = t.Rows[i]["nombre"].ToString()
                });
            }

            return lista;
        }
        public List<Persona> Select(string que, DBModelo conexion)
        {

            List<SqlParameter> datos = new List<SqlParameter>();
            datos.Add(new SqlParameter() { ParameterName = "buscar", Value = que });
            conexion.open();
            DataTable t = conexion.query("select * from  " + tabla + " where estado=1 and nombre like'%" + que + "%'"
                    , null);
            conexion.close();
            List<Persona> lista = new List<Persona>();
            for (int i = 0; i < t.Rows.Count; i++)
            {
                lista.Add(new Persona()
                {
                    id = (int)t.Rows[i]["id"],
                    estado = (int)t.Rows[i]["estado"],
                    apellidos = t.Rows[i]["apellidos"].ToString(),
                    nombre = t.Rows[i]["nombre"].ToString(),
                    ci = t.Rows[i]["ci"].ToString()
                });
            }

            return lista;
        }

        override
        public string ToString()
        {
            return string.Format("{0} {1} ",nombre,apellidos);
        }
        
    }
}
