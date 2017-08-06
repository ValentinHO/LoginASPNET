using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

/// <summary>
/// Descripción breve de ConexionController
/// </summary>
public class ConexionController
{
    public MySqlConnection conexion;
	public ConexionController()
	{
        conexion = new MySqlConnection("server=localhost; port=3306; database=csharp; Uid=valentin; pwd=Vho140295_;");
	}

    public bool abrirConexion()
    {
        try
        {
            conexion.Open();
            return true;
        }
        catch (MySqlException e)
        {
            return false;
            throw e;
        }

    }

    public bool cerrarConexion()
    {
        try
        {
            conexion.Close();
            return true;
        }
        catch (MySqlException e)
        {
            return false;
            throw e;
        }
    }
}