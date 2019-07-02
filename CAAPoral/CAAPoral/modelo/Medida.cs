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
    class Medida
    {
        private string tabla;
        public int id { get; set; }
        public int id_fraterno { get; set; }
        public decimal torso { get; set; }
        public decimal cintura { get; set; }
        public decimal brazos { get; set; }
        public decimal piernas { get; set; }
        public decimal zapato { get; set; }
        public decimal cabeza { get; set; }
        public Medida()
        {
            tabla = "tbmedida";
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
            datos.Add(new SqlParameter() { ParameterName = "id_fraterno", Value = id_fraterno });
            datos.Add(new SqlParameter() { ParameterName = "torso", Value = torso });
            datos.Add(new SqlParameter() { ParameterName = "cintura", Value = cintura });
            datos.Add(new SqlParameter() { ParameterName = "brazos", Value = brazos });
            datos.Add(new SqlParameter() { ParameterName = "piernas", Value = piernas }); ;
            datos.Add(new SqlParameter() { ParameterName = "zapato", Value = zapato });
            datos.Add(new SqlParameter() { ParameterName = "cabeza", Value = cabeza });

            int? x = conexion.querySimple("INSERT INTO " + tabla + "(id_fraterno,torso,cintura,brazos,piernas,zapato,cabeza) " +
                "values (@id_fraterno,@torso,@cintura,@brazos,@piernas,@zapato,@cabeza)", datos);
            conexion.close();
            return x > 0 || x == null ? true : false;
        }
        public bool Edit(DBModelo conexion)
        {
            conexion.open();
            List<SqlParameter> datos = new List<SqlParameter>();
            datos.Add(new SqlParameter() { ParameterName = "id_fraterno", Value = id_fraterno });
            datos.Add(new SqlParameter() { ParameterName = "torso", Value = torso });
            datos.Add(new SqlParameter() { ParameterName = "cintura", Value = cintura });
            datos.Add(new SqlParameter() { ParameterName = "brazos", Value = brazos });
            datos.Add(new SqlParameter() { ParameterName = "piernas", Value = piernas }); ;
            datos.Add(new SqlParameter() { ParameterName = "zapato", Value = zapato });
            datos.Add(new SqlParameter() { ParameterName = "cabeza", Value = cabeza });
            datos.Add(new SqlParameter() { ParameterName = "id", Value = id });

            int? x = conexion.querySimple("update " + tabla + " set torso=@torso,cintura=@cintura,brazos=@brazos,piernas=@piernas,zapato=@zapato,cabeza=@cabeza " +
               "where id=@id", datos);
            conexion.close();
            return x > 0 || x == null ? true : false;
        }
        public int Registro(int i, DBModelo conexion)
        {
            SqlCommand comand = new SqlCommand("SELECT COUNT(*) FROM " + tabla + " WHERE id_fraterno=" + i +";", conexion.conectar);
            conexion.open();
            int contar = (int)comand.ExecuteScalar();
            conexion.close();
            return contar;
        }
        public List<Medida> med (int id_f,DBModelo conexion)
        {
            conexion.open();
            DataTable t = conexion.query("select * from " + tabla + " WHERE id_fraterno=" + id_f + ";", null);
            conexion.close();
            List<Medida> lista = new List<Medida>();
            if (t != null) 
            for (int i = 0; i < t.Rows.Count; i++)
            {
                lista.Add(new Medida()
                {
                    id = (int)t.Rows[i]["id"],
                    id_fraterno = (int)t.Rows[i]["id_fraterno"],
                    torso = (decimal)t.Rows[i]["torso"],
                    cintura = (decimal)t.Rows[i]["cintura"],
                    brazos = (decimal)t.Rows[i]["brazos"],
                    piernas = (decimal)t.Rows[i]["piernas"],
                    cabeza = (decimal)t.Rows[i]["cabeza"],
                    zapato = (decimal)t.Rows[i]["zapato"]
                });
            }
            return lista;
        }
    }
}
