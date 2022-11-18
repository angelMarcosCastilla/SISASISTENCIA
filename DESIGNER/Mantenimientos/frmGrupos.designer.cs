namespace DESIGNER.Mantenimientos
{
    partial class frmGrupos
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
            this.gridGrupos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGrado = new System.Windows.Forms.TextBox();
            this.txtSeccion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rbtnM = new System.Windows.Forms.RadioButton();
            this.rbtnT = new System.Windows.Forms.RadioButton();
            this.btnGuardarGrupos = new System.Windows.Forms.Button();
            this.btnEliminarGrupos = new System.Windows.Forms.Button();
            this.btnEditarGrupos = new System.Windows.Forms.Button();
            this.ckbuscar = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBuscarGrupos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridGrupos)).BeginInit();
            this.SuspendLayout();
            // 
            // gridGrupos
            // 
            this.gridGrupos.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.gridGrupos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridGrupos.Location = new System.Drawing.Point(103, 213);
            this.gridGrupos.Name = "gridGrupos";
            this.gridGrupos.RowHeadersWidth = 51;
            this.gridGrupos.Size = new System.Drawing.Size(569, 104);
            this.gridGrupos.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(235, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Grado";
            // 
            // txtGrado
            // 
            this.txtGrado.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrado.Location = new System.Drawing.Point(238, 90);
            this.txtGrado.Name = "txtGrado";
            this.txtGrado.Size = new System.Drawing.Size(100, 20);
            this.txtGrado.TabIndex = 2;
            // 
            // txtSeccion
            // 
            this.txtSeccion.Location = new System.Drawing.Point(402, 92);
            this.txtSeccion.Name = "txtSeccion";
            this.txtSeccion.Size = new System.Drawing.Size(100, 20);
            this.txtSeccion.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(399, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Seccion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(610, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Turno";
            // 
            // rbtnM
            // 
            this.rbtnM.AutoSize = true;
            this.rbtnM.Checked = true;
            this.rbtnM.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnM.Location = new System.Drawing.Point(547, 93);
            this.rbtnM.Name = "rbtnM";
            this.rbtnM.Size = new System.Drawing.Size(67, 19);
            this.rbtnM.TabIndex = 6;
            this.rbtnM.TabStop = true;
            this.rbtnM.Text = "Mañana";
            this.rbtnM.UseVisualStyleBackColor = true;
            this.rbtnM.CheckedChanged += new System.EventHandler(this.rbtnM_CheckedChanged);
            // 
            // rbtnT
            // 
            this.rbtnT.AutoSize = true;
            this.rbtnT.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnT.Location = new System.Drawing.Point(657, 93);
            this.rbtnT.Name = "rbtnT";
            this.rbtnT.Size = new System.Drawing.Size(60, 19);
            this.rbtnT.TabIndex = 7;
            this.rbtnT.Text = "Tarde";
            this.rbtnT.UseVisualStyleBackColor = true;
            this.rbtnT.CheckedChanged += new System.EventHandler(this.rbtnT_CheckedChanged);
            // 
            // btnGuardarGrupos
            // 
            this.btnGuardarGrupos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGuardarGrupos.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarGrupos.Location = new System.Drawing.Point(440, 143);
            this.btnGuardarGrupos.Name = "btnGuardarGrupos";
            this.btnGuardarGrupos.Size = new System.Drawing.Size(125, 44);
            this.btnGuardarGrupos.TabIndex = 8;
            this.btnGuardarGrupos.Text = "📁 Guardar";
            this.btnGuardarGrupos.UseVisualStyleBackColor = false;
            this.btnGuardarGrupos.Click += new System.EventHandler(this.btnGuardarGrupos_Click);
            // 
            // btnEliminarGrupos
            // 
            this.btnEliminarGrupos.BackColor = System.Drawing.Color.IndianRed;
            this.btnEliminarGrupos.Enabled = false;
            this.btnEliminarGrupos.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarGrupos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEliminarGrupos.Location = new System.Drawing.Point(178, 143);
            this.btnEliminarGrupos.Name = "btnEliminarGrupos";
            this.btnEliminarGrupos.Size = new System.Drawing.Size(125, 44);
            this.btnEliminarGrupos.TabIndex = 9;
            this.btnEliminarGrupos.Text = "🗑️ Eliminar";
            this.btnEliminarGrupos.UseVisualStyleBackColor = false;
            this.btnEliminarGrupos.Click += new System.EventHandler(this.btnEliminarGrupos_Click);
            // 
            // btnEditarGrupos
            // 
            this.btnEditarGrupos.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnEditarGrupos.Enabled = false;
            this.btnEditarGrupos.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarGrupos.Location = new System.Drawing.Point(309, 145);
            this.btnEditarGrupos.Name = "btnEditarGrupos";
            this.btnEditarGrupos.Size = new System.Drawing.Size(125, 44);
            this.btnEditarGrupos.TabIndex = 10;
            this.btnEditarGrupos.Text = "✏️ Editar";
            this.btnEditarGrupos.UseVisualStyleBackColor = false;
            this.btnEditarGrupos.Click += new System.EventHandler(this.btnEditarGrupos_Click);
            // 
            // ckbuscar
            // 
            this.ckbuscar.AutoSize = true;
            this.ckbuscar.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbuscar.Location = new System.Drawing.Point(27, 71);
            this.ckbuscar.Margin = new System.Windows.Forms.Padding(2);
            this.ckbuscar.Name = "ckbuscar";
            this.ckbuscar.Size = new System.Drawing.Size(110, 19);
            this.ckbuscar.TabIndex = 27;
            this.ckbuscar.Text = "Buscar Grupo";
            this.ckbuscar.UseVisualStyleBackColor = true;
            this.ckbuscar.CheckedChanged += new System.EventHandler(this.ckbuscar_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(100, 111);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "(presionar enter)";
            // 
            // txtBuscarGrupos
            // 
            this.txtBuscarGrupos.Enabled = false;
            this.txtBuscarGrupos.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarGrupos.Location = new System.Drawing.Point(42, 90);
            this.txtBuscarGrupos.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscarGrupos.Name = "txtBuscarGrupos";
            this.txtBuscarGrupos.Size = new System.Drawing.Size(138, 20);
            this.txtBuscarGrupos.TabIndex = 25;
            this.txtBuscarGrupos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscarGrupos_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(323, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 29);
            this.label4.TabIndex = 28;
            this.label4.Text = "GRUPOS";
            // 
            // frmGrupos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(737, 329);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ckbuscar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtBuscarGrupos);
            this.Controls.Add(this.btnEditarGrupos);
            this.Controls.Add(this.btnEliminarGrupos);
            this.Controls.Add(this.btnGuardarGrupos);
            this.Controls.Add(this.rbtnT);
            this.Controls.Add(this.rbtnM);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSeccion);
            this.Controls.Add(this.txtGrado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridGrupos);
            this.Name = "frmGrupos";
            this.Text = "frmGrupos";
            this.Load += new System.EventHandler(this.frmGrupos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridGrupos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridGrupos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGrado;
        private System.Windows.Forms.TextBox txtSeccion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbtnM;
        private System.Windows.Forms.RadioButton rbtnT;
        private System.Windows.Forms.Button btnGuardarGrupos;
        private System.Windows.Forms.Button btnEliminarGrupos;
        private System.Windows.Forms.Button btnEditarGrupos;
        private System.Windows.Forms.CheckBox ckbuscar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBuscarGrupos;
        private System.Windows.Forms.Label label4;
    }
}