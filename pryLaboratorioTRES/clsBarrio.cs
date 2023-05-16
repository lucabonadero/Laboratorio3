using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Se agregan los procedimientos necesarios para utilizar en la clase
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using System.IO;
namespace pryLaboratorioTRES
{
    public class clsBarrio
    {
        //Comandos OleDb para la conexión a la base de datos
        private OleDbConnection cnx = new OleDbConnection();
        private OleDbCommand cmd = new OleDbCommand();
        private OleDbDataAdapter adapter = new OleDbDataAdapter();


        //Conectarse a la base de datos mediante la cadena de conexion y declarar la variable
        private string vCadenaConexion = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=COLEGIO.mdb";
        private string vTabla = "Barrios";

        public void CargarComboBox(ComboBox cmbBarrio)
        {
            //Cargar combobox con los nombres de los barrios de la tabla para luego seleccionarlos
            try
            {
                cnx.ConnectionString = vCadenaConexion;
                cmd.Connection = cnx;
                cmd.CommandText = "SELECT * FROM " + vTabla;
                adapter.SelectCommand = cmd;
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                cmbBarrio.DataSource = dt;
                cmbBarrio.DisplayMember = "nombre";
                cmbBarrio.ValueMember = "barrio";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el combobox: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
