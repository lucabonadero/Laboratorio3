namespace pryLaboratorioTRES
{
    partial class frmConsultar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbDNI = new System.Windows.Forms.GroupBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.lblDNI = new System.Windows.Forms.Label();
            this.txtNombreRO = new System.Windows.Forms.TextBox();
            this.lblBarrio = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtBarrioRO = new System.Windows.Forms.TextBox();
            this.txtSexoRO = new System.Windows.Forms.TextBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.gbDNI.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDNI
            // 
            this.gbDNI.Controls.Add(this.txtSexoRO);
            this.gbDNI.Controls.Add(this.txtBarrioRO);
            this.gbDNI.Controls.Add(this.lblSexo);
            this.gbDNI.Controls.Add(this.txtDNI);
            this.gbDNI.Controls.Add(this.lblBarrio);
            this.gbDNI.Controls.Add(this.txtNombreRO);
            this.gbDNI.Controls.Add(this.lblDNI);
            this.gbDNI.Controls.Add(this.lblNombre);
            this.gbDNI.Location = new System.Drawing.Point(13, 13);
            this.gbDNI.Name = "gbDNI";
            this.gbDNI.Size = new System.Drawing.Size(199, 208);
            this.gbDNI.TabIndex = 0;
            this.gbDNI.TabStop = false;
            this.gbDNI.Text = "Consultar alumno por DNI";
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(55, 27);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(91, 20);
            this.txtDNI.TabIndex = 7;
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNI.Location = new System.Drawing.Point(6, 27);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(45, 20);
            this.lblDNI.TabIndex = 6;
            this.lblDNI.Text = "D.N.I";
            // 
            // txtNombreRO
            // 
            this.txtNombreRO.Location = new System.Drawing.Point(6, 74);
            this.txtNombreRO.Name = "txtNombreRO";
            this.txtNombreRO.ReadOnly = true;
            this.txtNombreRO.Size = new System.Drawing.Size(140, 20);
            this.txtNombreRO.TabIndex = 11;
            // 
            // lblBarrio
            // 
            this.lblBarrio.AutoSize = true;
            this.lblBarrio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarrio.Location = new System.Drawing.Point(6, 97);
            this.lblBarrio.Name = "lblBarrio";
            this.lblBarrio.Size = new System.Drawing.Size(55, 20);
            this.lblBarrio.TabIndex = 10;
            this.lblBarrio.Text = "Barrio:";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.Location = new System.Drawing.Point(6, 144);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(49, 20);
            this.lblSexo.TabIndex = 9;
            this.lblSexo.Text = "Sexo:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(6, 51);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(140, 20);
            this.lblNombre.TabIndex = 8;
            this.lblNombre.Text = "Apellido y Nombre:";
            // 
            // txtBarrioRO
            // 
            this.txtBarrioRO.Location = new System.Drawing.Point(6, 120);
            this.txtBarrioRO.Name = "txtBarrioRO";
            this.txtBarrioRO.ReadOnly = true;
            this.txtBarrioRO.Size = new System.Drawing.Size(140, 20);
            this.txtBarrioRO.TabIndex = 12;
            // 
            // txtSexoRO
            // 
            this.txtSexoRO.Location = new System.Drawing.Point(6, 167);
            this.txtSexoRO.Name = "txtSexoRO";
            this.txtSexoRO.ReadOnly = true;
            this.txtSexoRO.Size = new System.Drawing.Size(140, 20);
            this.txtSexoRO.TabIndex = 13;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Location = new System.Drawing.Point(13, 227);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(199, 23);
            this.btnConsultar.TabIndex = 14;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // frmConsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 261);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.gbDNI);
            this.Name = "frmConsultar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmConsultar";
            this.gbDNI.ResumeLayout(false);
            this.gbDNI.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDNI;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.TextBox txtSexoRO;
        private System.Windows.Forms.TextBox txtBarrioRO;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblBarrio;
        private System.Windows.Forms.TextBox txtNombreRO;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnConsultar;
    }
}