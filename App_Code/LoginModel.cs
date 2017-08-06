using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data;
/// <summary>
/// Descripción breve de LoginModel
/// </summary>
public class LoginModel
{
    public int id { get; set; }
    public string usuario { get; set; }
    public string password { get; set; }
    public string nombre { get; set; }
	public LoginModel()
	{
		//
		// TODO: Agregar aquí la lógica del constructor
		//
	}
    public LoginModel(string usuario, string pwd, string nombre)
    {
            this.usuario = usuario;
            this.password = pwd;
            this.nombre = nombre;
    }

    public static DataTable login(MySqlConnection conexion, string usuario,string password)
    {

        MySqlCommand comando = new MySqlCommand(String.Format("SELECT * FROM users WHERE login='{0}' AND password='{1}'", usuario,password), conexion);
        comando.ExecuteNonQuery();
        DataTable dt = new DataTable();
        MySqlDataAdapter da = new MySqlDataAdapter(comando);
        da.Fill(dt);

        return dt;
    }
}