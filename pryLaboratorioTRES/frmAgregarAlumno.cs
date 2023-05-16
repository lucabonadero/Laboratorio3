using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryLaboratorioTRES
{
    public partial class frmAgregarAlumno : Form
    {
        public frmAgregarAlumno()
        {
            InitializeComponent();
        }
        clsAlumnos clsAlumnos = new clsAlumnos();
        clsBarrio clsBarrio = new clsBarrio();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsAlumnos.Dni = Convert.ToInt32(txtDNI.Text);
            clsAlumnos.Nombre = txtNombre.Text;
            clsAlumnos.Barrio = Convert.ToInt32(cmbBarrio.SelectedValue);
            if (rdbM.Checked == true)
            {
                clsAlumnos.Sexo = "M";
            }
            else
            {
                clsAlumnos.Sexo = "F";
            }


            clsAlumnos.Agregar();


            txtDNI.Text = "";
            txtNombre.Text = "";
            rdbM.Checked = false;
            rdbF.Checked = false;
            cmbBarrio.Text = "";




        }

        private void frmAgregarAlumno_Load(object sender, EventArgs e)
        {
            clsBarrio.CargarComboBox(cmbBarrio);
        }
    }
}
