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
            this.rbtnMañana = new System.Windows.Forms.RadioButton();
            this.rbtnTarde = new System.Windows.Forms.RadioButton();
            this.btnGuardarGrupos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridGrupos)).BeginInit();
            this.SuspendLayout();
            // 
            // gridGrupos
            // 
            this.gridGrupos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridGrupos.Location = new System.Drawing.Point(44, 246);
            this.gridGrupos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridGrupos.Name = "gridGrupos";
            this.gridGrupos.RowHeadersWidth = 51;
            this.gridGrupos.Size = new System.Drawing.Size(973, 226);
            this.gridGrupos.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 106);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Grado";
            // 
            // txtGrado
            // 
            this.txtGrado.Location = new System.Drawing.Point(69, 137);
            this.txtGrado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGrado.Name = "txtGrado";
            this.txtGrado.Size = new System.Drawing.Size(132, 22);
            this.txtGrado.TabIndex = 2;
            // 
            // txtSeccion
            // 
            this.txtSeccion.Location = new System.Drawing.Point(316, 137);
            this.txtSeccion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSeccion.Name = "txtSeccion";
            this.txtSeccion.Size = new System.Drawing.Size(132, 22);
            this.txtSeccion.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(312, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Seccion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(623, 106);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Turno";
            // 
            // rbtnMañana
            // 
            this.rbtnMañana.AutoSize = true;
            this.rbtnMañana.Location = new System.Drawing.Point(527, 137);
            this.rbtnMañana.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtnMañana.Name = "rbtnMañana";
            this.rbtnMañana.Size = new System.Drawing.Size(77, 20);
            this.rbtnMañana.TabIndex = 6;
            this.rbtnMañana.TabStop = true;
            this.rbtnMañana.Text = "Mañana";
            this.rbtnMañana.UseVisualStyleBackColor = true;
            // 
            // rbtnTarde
            // 
            this.rbtnTarde.AutoSize = true;
            this.rbtnTarde.Location = new System.Drawing.Point(673, 137);
            this.rbtnTarde.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtnTarde.Name = "rbtnTarde";
            this.rbtnTarde.Size = new System.Drawing.Size(65, 20);
            this.rbtnTarde.TabIndex = 7;
            this.rbtnTarde.TabStop = true;
            this.rbtnTarde.Text = "Tarde";
            this.rbtnTarde.UseVisualStyleBackColor = true;
            // 
            // btnGuardarGrupos
            // 
            this.btnGuardarGrupos.Location = new System.Drawing.Point(815, 121);
            this.btnGuardarGrupos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuardarGrupos.Name = "btnGuardarGrupos";
            this.btnGuardarGrupos.Size = new System.Drawing.Size(131, 41);
            this.btnGuardarGrupos.TabIndex = 8;
            this.btnGuardarGrupos.Text = "Guardar";
            this.btnGuardarGrupos.UseVisualStyleBackColor = true;
            this.btnGuardarGrupos.Click += new System.EventHandler(this.btnGuardarGrupos_Click);
            // 
            // frmGrupos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnGuardarGrupos);
            this.Controls.Add(this.rbtnTarde);
            this.Controls.Add(this.rbtnMañana);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSeccion);
            this.Controls.Add(this.txtGrado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridGrupos);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmGrupos";
            this.Text = "frmGrupos";
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
        private System.Windows.Forms.RadioButton rbtnMañana;
        private System.Windows.Forms.RadioButton rbtnTarde;
        private System.Windows.Forms.Button btnGuardarGrupos;
    }
}