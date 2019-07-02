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
    public class Fraterno
    {
        public enum Bloques{fachas=0,Tigritos,Cholita1, Tiguresas};
        public int id { get; set; }
        public long cel { get; set; }
        public Bloques bloque{ get; set; }

        public int estado { get; set; }
        private string tabla;
        public Persona persona { get; set; }
        public Fraterno()
        {

            tabla = "tbfraterno";
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
            datos.Add(new SqlParameter() { ParameterName = "id", Value = persona.id });
            datos.Add(new SqlParameter() { ParameterName = "cel", Value = cel });
            datos.Add(new SqlParameter() { ParameterName = "bloque", Value = bloque });
            datos.Add(new SqlParameter() { ParameterName = "estado", Value = 1 });

            int? x = conexion.querySimple("insert into " + tabla + "(id,cel,bloque,estado) " +
                "values (@id,@cel,@bloque,1)", datos);
            conexion.close();
            return x > 0 || x == null ? true : false;
        }
        public bool Edit(DBModelo conexion)
        {
            conexion.open();
            List<SqlParameter> datos = new List<SqlParameter>();
            datos.Add(new SqlParameter() { ParameterName = "cel", Value = cel });
            datos.Add(new SqlParameter() { ParameterName = "bloque", Value = bloque });
            datos.Add(new SqlParameter() { ParameterName = "id", Value = id });

            int? x = conexion.querySimple("update " + tabla + " set cel=@cel,bloque=@bloque " +
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
        public List<Fraterno> Select(DBModelo conexion)
        {
            conexion.open();
            DataTable t = conexion.query("select * from  " + tabla + " inner join tbpersona on tbpersona.id=" + tabla + ".id  where estado=1 "
                    , null);
            conexion.close();
            List<Fraterno> lista = new List<Fraterno>();
            if(t!=null)
            for (int i = 0; i < t.Rows.Count; i++)
            {
                lista.Add(new Fraterno()
                {
                    id = (int)t.Rows[i]["id"],
                    estado = (int)t.Rows[i]["estado"],
                    bloque = (Bloques)t.Rows[i]["bloque"],
                    cel = (long)t.Rows[i]["cel"],
                    persona = new Persona()
                    {
                        apellidos = t.Rows[i]["apellidos"].ToString(),
                        nombre = t.Rows[i]["nombre"].ToString(),
                        ci = t.Rows[i]["ci"].ToString(),
                        estado = (int)t.Rows[i]["estado"],
                        id = (int)t.Rows[i]["id"]
                    }
                });
            }

            return lista;
        }
        public List<Fraterno> Select(string que, DBModelo conexion)
        {

            List<SqlParameter> datos = new List<SqlParameter>();
            datos.Add(new SqlParameter() { ParameterName = "buscar", Value = que });
            conexion.open();
            DataTable t = conexion.query("select * from  " + tabla + " inner join tbpersona on tbpersona.id="+tabla+
                ".id  where "+tabla+".estado=1 and tbpersona.nombre like'%" + que + "%'"
                    , null);
            conexion.close();
            List<Fraterno> lista = new List<Fraterno>();
            if(t!=null)
            for (int i = 0; i < t.Rows.Count; i++)
            {

                lista.Add(new Fraterno()
                {
                    id = (int)t.Rows[i]["id"],
                    estado = (int)t.Rows[i]["estado"],
                    bloque = (Bloques)t.Rows[i]["bloque"],
                    cel = (long)t.Rows[i]["cel"],
                    persona = new Persona() {
                        apellidos = t.Rows[i]["apellidos"].ToString(),
                        nombre= t.Rows[i]["nombre"].ToString(),
                        ci = t.Rows[i]["ci"].ToString(),
                        estado = (int)t.Rows[i]["estado"],
                        id=(int)t.Rows[i]["id"]
                    }
                });
                //lista
            }

            return lista;
        }
        
    }
}
