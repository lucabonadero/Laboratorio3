using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;

namespace pryLaboratorioTRES
{
    public class clsAlumnos
    {
        #region Cadena de Conexion
        //Comandos OleDb para la conexión a la base de datos
        private OleDbConnection cnx = new OleDbConnection();
        private OleDbCommand cmd = new OleDbCommand();
        private OleDbDataAdapter adapter = new OleDbDataAdapter();


        //Conectarse a la base de datos mediante la cadena de conexion y declarar la variable
        private string vCadenaConexion = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=COLEGIO.mdb";
        private string vTabla = "Alumnos";
        //Declarar las variables que se utilizaran en la clase
        private Int32 dni;
        private string nombre;
        private string sexo;
        private Int32 barrio;
        #endregion

        #region Propiedades
        //Asignar valores y variables globales para usar en todo el proyecto
        public Int32 Dni
        {
            get { return dni; }
            set { dni = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }
        public Int32 Barrio
        {
            get { return barrio; }
            set { barrio = value; }
        }
        #endregion




        public void Agregar()
        {
            //Agregar un alumno a la base de datos
            try
            {
                cnx.ConnectionString = vCadenaConexion;
                cmd.Connection = cnx;
                cmd.CommandText = "INSERT INTO " + vTabla + " (dni, nombre, sexo, barrio) VALUES (@dni, @nombre, @sexo, @barrio)";
                cmd.Parameters.AddWithValue("@dni", dni);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@sexo", sexo);
                cmd.Parameters.AddWithValue("@barrio", barrio);
                cnx.Open();
                cmd.ExecuteNonQuery();
                cnx.Close();
                MessageBox.Show("Alumno agregado correctamente", "Agregar alumno", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)    
            {
                MessageBox.Show("Error al agregar el alumno: " + ex.Message, "Agregar alumno", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }
        public void BuscarAlumnoPorDNI()
        {
            //Buscar un alumno por DNI y luego mostrar sus datos en los textbox
            try
            {
                cnx.ConnectionString = vCadenaConexion;
                cmd.Connection = cnx;
                cmd.CommandText = "SELECT * FROM " + vTabla + " WHERE dni = @dni";
                cmd.Parameters.AddWithValue("@dni", dni);
                adapter.SelectCommand = cmd;
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    nombre = dt.Rows[0]["nombre"].ToString();
                    sexo = dt.Rows[0]["sexo"].ToString();
                    barrio = Convert.ToInt32(dt.Rows[0]["barrio"].ToString());
                }
                else
                {
                    MessageBox.Show("No se encontró el alumno", "Buscar alumno", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar el alumno: " + ex.Message, "Buscar alumno", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
