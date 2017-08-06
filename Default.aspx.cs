using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data;

public partial class _Default : System.Web.UI.Page
{
    ConexionController conexion = new ConexionController();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnlogin_Click(object sender, EventArgs e)
    {
        try
        {
            if (conexion.abrirConexion() == true)
            {
                DataTable dt = LoginModel.login(conexion.conexion, t1.Text, t2.Text);

                foreach (DataRow dr in dt.Rows)
                {
                    Session["username"] = dr["nombre"];
                    Response.Redirect("Inicio.aspx");
                }
                
                lblerror.Text = "Usuario o contraseña incorrecta.";
                conexion.cerrarConexion();
            }
            else
            {
                lblerror.Text = "No se pudo conectar a la BD";
            }

        }
        catch (MySqlException ex)
        {
            lblerror.Text = ex.Message;
        }
    }
}