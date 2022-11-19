namespace DESIGNER.Mantenimientos
{
    partial class frmAsistencia
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
            this.txtDni = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRegistrarAsistencia = new System.Windows.Forms.Button();
            this.ckbuscar = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBuscarPersona = new System.Windows.Forms.TextBox();
            this.gridAsistencia = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbSalida = new System.Windows.Forms.RadioButton();
            this.rbEntrada = new System.Windows.Forms.RadioButton();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblMotivo = new System.Windows.Forms.Label();
            this.cbMotivo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridAsistencia)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDni
            // 
            this.txtDni.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDni.Location = new System.Drawing.Point(43, 340);
            this.txtDni.Name = "txtDni";
            this.txtDni.ReadOnly = true;
            this.txtDni.Size = new System.Drawing.Size(267, 28);
            this.txtDni.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 21);
            this.label4.TabIndex = 14;
            this.label4.Text = "Dni";
            // 
            // txtApellidos
            // 
            this.txtApellidos.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidos.Location = new System.Drawing.Point(43, 287);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.ReadOnly = true;
            this.txtApellidos.Size = new System.Drawing.Size(267, 28);
            this.txtApellidos.TabIndex = 11;
            // 
            // txtNombres
            // 
            this.txtNombres.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombres.Location = new System.Drawing.Point(43, 233);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.ReadOnly = true;
            this.txtNombres.Size = new System.Drawing.Size(267, 28);
            this.txtNombres.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "Apellidos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nombres";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(85, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(216, 24);
            this.label6.TabIndex = 20;
            this.label6.Text = "CONTROL ASISTENCIA";
            // 
            // btnRegistrarAsistencia
            // 
            this.btnRegistrarAsistencia.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRegistrarAsistencia.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarAsistencia.Location = new System.Drawing.Point(89, 500);
            this.btnRegistrarAsistencia.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistrarAsistencia.Name = "btnRegistrarAsistencia";
            this.btnRegistrarAsistencia.Size = new System.Drawing.Size(167, 54);
            this.btnRegistrarAsistencia.TabIndex = 21;
            this.btnRegistrarAsistencia.Text = "Marcar";
            this.btnRegistrarAsistencia.UseVisualStyleBackColor = false;
            this.btnRegistrarAsistencia.Click += new System.EventHandler(this.btnRegistrarAsistencia_Click);
            // 
            // ckbuscar
            // 
            this.ckbuscar.AutoSize = true;
            this.ckbuscar.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbuscar.Location = new System.Drawing.Point(44, 149);
            this.ckbuscar.Name = "ckbuscar";
            this.ckbuscar.Size = new System.Drawing.Size(138, 25);
            this.ckbuscar.TabIndex = 27;
            this.ckbuscar.Text = "Buscar Persona";
            this.ckbuscar.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Corbel", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(150, 202);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 15);
            this.label9.TabIndex = 26;
            this.label9.Text = "(presionar enter)";
            // 
            // txtBuscarPersona
            // 
            this.txtBuscarPersona.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarPersona.Location = new System.Drawing.Point(64, 173);
            this.txtBuscarPersona.Name = "txtBuscarPersona";
            this.txtBuscarPersona.Size = new System.Drawing.Size(182, 28);
            this.txtBuscarPersona.TabIndex = 25;
            this.txtBuscarPersona.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscarPerssona_KeyPress);
            // 
            // gridAsistencia
            // 
            this.gridAsistencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAsistencia.Location = new System.Drawing.Point(369, 66);
            this.gridAsistencia.Name = "gridAsistencia";
            this.gridAsistencia.ReadOnly = true;
            this.gridAsistencia.RowHeadersWidth = 51;
            this.gridAsistencia.RowTemplate.Height = 24;
            this.gridAsistencia.Size = new System.Drawing.Size(577, 488);
            this.gridAsistencia.TabIndex = 28;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbSalida);
            this.groupBox1.Controls.Add(this.rbEntrada);
            this.groupBox1.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(43, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 100);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Asistencia";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rbSalida
            // 
            this.rbSalida.AutoSize = true;
            this.rbSalida.Location = new System.Drawing.Point(94, 67);
            this.rbSalida.Name = "rbSalida";
            this.rbSalida.Size = new System.Drawing.Size(73, 25);
            this.rbSalida.TabIndex = 1;
            this.rbSalida.TabStop = true;
            this.rbSalida.Text = "Salida";
            this.rbSalida.UseVisualStyleBackColor = true;
            this.rbSalida.CheckedChanged += new System.EventHandler(this.rbSalida_CheckedChanged);
            // 
            // rbEntrada
            // 
            this.rbEntrada.AutoSize = true;
            this.rbEntrada.Checked = true;
            this.rbEntrada.Location = new System.Drawing.Point(94, 27);
            this.rbEntrada.Name = "rbEntrada";
            this.rbEntrada.Size = new System.Drawing.Size(86, 25);
            this.rbEntrada.TabIndex = 0;
            this.rbEntrada.TabStop = true;
            this.rbEntrada.Text = "Entrada";
            this.rbEntrada.UseVisualStyleBackColor = true;
            this.rbEntrada.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(42, 443);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(267, 49);
            this.txtDescripcion.TabIndex = 33;
            this.txtDescripcion.Visible = false;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(39, 422);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(91, 21);
            this.lblDescripcion.TabIndex = 32;
            this.lblDescripcion.Text = "Descripcion";
            this.lblDescripcion.Visible = false;
            // 
            // lblMotivo
            // 
            this.lblMotivo.AutoSize = true;
            this.lblMotivo.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotivo.Location = new System.Drawing.Point(39, 371);
            this.lblMotivo.Name = "lblMotivo";
            this.lblMotivo.Size = new System.Drawing.Size(60, 21);
            this.lblMotivo.TabIndex = 30;
            this.lblMotivo.Text = "Motivo";
            this.lblMotivo.Visible = false;
            // 
            // cbMotivo
            // 
            this.cbMotivo.FormattingEnabled = true;
            this.cbMotivo.Location = new System.Drawing.Point(44, 396);
            this.cbMotivo.Name = "cbMotivo";
            this.cbMotivo.Size = new System.Drawing.Size(266, 24);
            this.cbMotivo.TabIndex = 34;
            this.cbMotivo.Visible = false;
            this.cbMotivo.SelectedIndexChanged += new System.EventHandler(this.cbMotivo_SelectedIndexChanged);
            // 
            // frmAsistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 566);
            this.Controls.Add(this.cbMotivo);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblMotivo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gridAsistencia);
            this.Controls.Add(this.ckbuscar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtBuscarPersona);
            this.Controls.Add(this.btnRegistrarAsistencia);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAsistencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAsistencia";
            this.Load += new System.EventHandler(this.frmAsistencia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridAsistencia)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRegistrarAsistencia;
        private System.Windows.Forms.CheckBox ckbuscar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBuscarPersona;
        private System.Windows.Forms.DataGridView gridAsistencia;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbSalida;
        private System.Windows.Forms.RadioButton rbEntrada;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblMotivo;
        private System.Windows.Forms.ComboBox cbMotivo;
    }
}