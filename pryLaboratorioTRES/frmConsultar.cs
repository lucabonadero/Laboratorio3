﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryLaboratorioTRES
{
    public partial class frmConsultar : Form
    {
        public frmConsultar()
        {
            InitializeComponent();
        }
        clsAlumnos clsAlumnos = new clsAlumnos();
        clsBarrio clsBarrio = new clsBarrio();

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            //Llamar al metodo buscar alumno por dni
            clsAlumnos.Dni = Convert.ToInt32(txtDNI.Text);
            clsAlumnos.BuscarAlumnoPorDNI();
            txtNombreRO.Text = clsAlumnos.Nombre;
            txtSexoRO.Text = clsAlumnos.Sexo;
            txtBarrioRO.Text = Convert.ToString(clsAlumnos.Barrio);
            



        }
    }
}
