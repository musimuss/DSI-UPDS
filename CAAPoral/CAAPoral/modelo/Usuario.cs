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
    public class Usuario
    {

       
            public int id { get; set; }
            public string login { get; set; }
            public string password { get; set; }
            public int estado { get; set; }
            private string tabla;
            public Persona persona { get; set; }
            public Usuario()
            {

                tabla = "tbusuario";
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
                datos.Add(new SqlParameter() { ParameterName = "login", Value = login });
                datos.Add(new SqlParameter() { ParameterName = "password", Value = password });
                datos.Add(new SqlParameter() { ParameterName = "estado", Value = 1 });

                int? x = conexion.querySimple("insert into " + tabla + "(login,password,estado) " +
                    "values (@login,@password,1)", datos);
                conexion.close();
                return x > 0 || x == null ? true : false;
            }
            public bool Edit(DBModelo conexion)
            {
                conexion.open();
                List<SqlParameter> datos = new List<SqlParameter>();
                datos.Add(new SqlParameter() { ParameterName = "login", Value = login });
                datos.Add(new SqlParameter() { ParameterName = "password", Value = password });
                datos.Add(new SqlParameter() { ParameterName = "id", Value = id });

                int? x = conexion.querySimple("update " + tabla + " set login=@login,password=@password " +
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
            public List<Usuario> Select(DBModelo conexion)
            {
                conexion.open();
                DataTable t = conexion.query("select * from  " + tabla + " where estado=1 "
                        , null);
                conexion.close();
                List<Usuario> lista = new List<Usuario>();
                for (int i = 0; i < t.Rows.Count; i++)
                {
                    lista.Add(new Usuario()
                    {
                        id = (int)t.Rows[i]["id"],
                        estado = (int)t.Rows[i]["estado"],
                        password = t.Rows[i]["password"].ToString(),
                        login = t.Rows[i]["login"].ToString()
                    });
                }

                return lista;
            }
            public List<Usuario> Select(string que, DBModelo conexion)
            {

                List<SqlParameter> datos = new List<SqlParameter>();
                datos.Add(new SqlParameter() { ParameterName = "buscar", Value = que });
                conexion.open();
                DataTable t = conexion.query("select * from  " + tabla + " where estado=1 and login like'%" + que + "%'"
                        , null);
                conexion.close();
                List<Usuario> lista = new List<Usuario>();
                for (int i = 0; i < t.Rows.Count; i++)
                {
                    lista.Add(new Usuario()
                    {
                        id = (int)t.Rows[i]["id"],
                        estado = (int)t.Rows[i]["estado"],
                        password = t.Rows[i]["password"].ToString(),
                        login = t.Rows[i]["login"].ToString()
                    });
                }

                return lista;
            }
        public bool islogin(DBModelo conexion) {
            List<SqlParameter> datos = new List<SqlParameter>();
            password = SHA512(password);
            datos.Add(new SqlParameter() { ParameterName = "login", Value =login });
            datos.Add(new SqlParameter() { ParameterName = "password", Value = password });
            conexion.open();
            DataTable t = conexion.query("select * from  " + tabla + " where estado=1 and login =@login and password=@password"
                    , datos);
            conexion.close();
            if (t.Rows.Count > 0)
            {
                conexion.open();
                DataTable per = conexion.query("select * from tbpersona where id=" +t.Rows[0]["id"].ToString()
                        , null);
                conexion.close();
                General.user = new Usuario()
                {
                    estado = (int)t.Rows[0]["estado"],
                    id = (int)t.Rows[0]["id"],
                    login = t.Rows[0]["login"].ToString(),
                    password = "jkahskjd ajskdhk asjkdhkas djk asjkh",
                    persona = new Persona()
                    {
                        apellidos = per.Rows[0]["apellidos"].ToString(),
                        //estado = (int)per.Rows[0]["estado"],
                        id = (int)per.Rows[0]["id"],
                        nombre = per.Rows[0]["nombre"].ToString()
                    }
                };
                General.user.persona.usuario = General.user;
                return true;
            }else
                return false;
        }
        public static string SHA512(string input)
        {
            var bytes = System.Text.Encoding.UTF8.GetBytes(input);
            using (var hash = System.Security.Cryptography.SHA512.Create())
            {
                var hashedInputBytes = hash.ComputeHash(bytes);

                // Convert to text
                // StringBuilder Capacity is 128, because 512 bits / 8 bits in byte * 2 symbols for byte 
                var hashedInputStringBuilder = new System.Text.StringBuilder(128);
                foreach (var b in hashedInputBytes)
                    hashedInputStringBuilder.Append(b.ToString("X2"));
                return hashedInputStringBuilder.ToString();
            }
        }

    }
}
