namespace DESIGNER.Mantenimientos
{
    partial class frmMotivossalida
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
            this.gridMotivossalida = new System.Windows.Forms.DataGridView();
            this.txtMotivoSalida = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuardarMotivo = new System.Windows.Forms.Button();
            this.btnEditarMotivo = new System.Windows.Forms.Button();
            this.ckbuscar = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBuscarMotivo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridMotivossalida)).BeginInit();
            this.SuspendLayout();
            // 
            // gridMotivossalida
            // 
            this.gridMotivossalida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMotivossalida.Location = new System.Drawing.Point(69, 201);
            this.gridMotivossalida.Name = "gridMotivossalida";
            this.gridMotivossalida.Size = new System.Drawing.Size(648, 175);
            this.gridMotivossalida.TabIndex = 0;
            // 
            // txtMotivoSalida
            // 
            this.txtMotivoSalida.Location = new System.Drawing.Point(119, 129);
            this.txtMotivoSalida.Name = "txtMotivoSalida";
            this.txtMotivoSalida.Size = new System.Drawing.Size(244, 20);
            this.txtMotivoSalida.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Motivo de salida:";
            // 
            // btnGuardarMotivo
            // 
            this.btnGuardarMotivo.Location = new System.Drawing.Point(435, 146);
            this.btnGuardarMotivo.Name = "btnGuardarMotivo";
            this.btnGuardarMotivo.Size = new System.Drawing.Size(98, 30);
            this.btnGuardarMotivo.TabIndex = 3;
            this.btnGuardarMotivo.Text = "Guardar";
            this.btnGuardarMotivo.UseVisualStyleBackColor = true;
            this.btnGuardarMotivo.Click += new System.EventHandler(this.btnGuardarMotivo_Click);
            // 
            // btnEditarMotivo
            // 
            this.btnEditarMotivo.Enabled = false;
            this.btnEditarMotivo.Location = new System.Drawing.Point(435, 82);
            this.btnEditarMotivo.Name = "btnEditarMotivo";
            this.btnEditarMotivo.Size = new System.Drawing.Size(98, 35);
            this.btnEditarMotivo.TabIndex = 12;
            this.btnEditarMotivo.Text = "Editar";
            this.btnEditarMotivo.UseVisualStyleBackColor = true;
            this.btnEditarMotivo.Click += new System.EventHandler(this.btnEditarMotivo_Click);
            // 
            // ckbuscar
            // 
            this.ckbuscar.AutoSize = true;
            this.ckbuscar.Location = new System.Drawing.Point(26, 15);
            this.ckbuscar.Margin = new System.Windows.Forms.Padding(2);
            this.ckbuscar.Name = "ckbuscar";
            this.ckbuscar.Size = new System.Drawing.Size(91, 17);
            this.ckbuscar.TabIndex = 30;
            this.ckbuscar.Text = "Buscar Grupo";
            this.ckbuscar.UseVisualStyleBackColor = true;
            this.ckbuscar.CheckedChanged += new System.EventHandler(this.ckbuscar_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(99, 55);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "(presionar enter)";
            // 
            // txtBuscarMotivo
            // 
            this.txtBuscarMotivo.Enabled = false;
            this.txtBuscarMotivo.Location = new System.Drawing.Point(41, 34);
            this.txtBuscarMotivo.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscarMotivo.Name = "txtBuscarMotivo";
            this.txtBuscarMotivo.Size = new System.Drawing.Size(138, 20);
            this.txtBuscarMotivo.TabIndex = 28;
            this.txtBuscarMotivo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscarMotivo_KeyPress);
            // 
            // frmMotivossalida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ckbuscar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtBuscarMotivo);
            this.Controls.Add(this.btnEditarMotivo);
            this.Controls.Add(this.btnGuardarMotivo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMotivoSalida);
            this.Controls.Add(this.gridMotivossalida);
            this.Name = "frmMotivossalida";
            this.Text = "frmMotivossalida";
            this.Load += new System.EventHandler(this.frmMotivossalida_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridMotivossalida)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridMotivossalida;
        private System.Windows.Forms.TextBox txtMotivoSalida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuardarMotivo;
        private System.Windows.Forms.Button btnEditarMotivo;
        private System.Windows.Forms.CheckBox ckbuscar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBuscarMotivo;
    }
}