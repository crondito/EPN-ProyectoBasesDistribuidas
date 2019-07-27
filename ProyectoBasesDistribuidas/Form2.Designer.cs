namespace ProyectoBasesDistribuidas
{
    partial class Form2
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxCedula = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxLocal = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCodEmp = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.Enabled = false;
            this.btnAgregar.Location = new System.Drawing.Point(12, 118);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Location = new System.Drawing.Point(113, 118);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre:";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(67, 39);
            this.textBoxNombre.MaxLength = 40;
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(121, 20);
            this.textBoxNombre.TabIndex = 3;
            this.textBoxNombre.TextChanged += new System.EventHandler(this.textBoxNombre_TextChanged);
            this.textBoxNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNombre_KeyPress);
            // 
            // textBoxCedula
            // 
            this.textBoxCedula.Location = new System.Drawing.Point(67, 65);
            this.textBoxCedula.MaxLength = 10;
            this.textBoxCedula.Name = "textBoxCedula";
            this.textBoxCedula.Size = new System.Drawing.Size(121, 20);
            this.textBoxCedula.TabIndex = 4;
            this.textBoxCedula.TextChanged += new System.EventHandler(this.textBoxCedula_TextChanged);
            this.textBoxCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCedula_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cédula:";
            // 
            // comboBoxLocal
            // 
            this.comboBoxLocal.FormattingEnabled = true;
            this.comboBoxLocal.Items.AddRange(new object[] {
            "Quito",
            "Cuenca"});
            this.comboBoxLocal.Location = new System.Drawing.Point(67, 91);
            this.comboBoxLocal.Name = "comboBoxLocal";
            this.comboBoxLocal.Size = new System.Drawing.Size(121, 21);
            this.comboBoxLocal.TabIndex = 6;
            this.comboBoxLocal.SelectedIndexChanged += new System.EventHandler(this.comboBoxLocal_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Local";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Código Empleado";
            // 
            // textBoxCodEmp
            // 
            this.textBoxCodEmp.Location = new System.Drawing.Point(109, 13);
            this.textBoxCodEmp.MaxLength = 3;
            this.textBoxCodEmp.Name = "textBoxCodEmp";
            this.textBoxCodEmp.Size = new System.Drawing.Size(79, 20);
            this.textBoxCodEmp.TabIndex = 9;
            this.textBoxCodEmp.TextChanged += new System.EventHandler(this.textBoxCodEmp_TextChanged);
            this.textBoxCodEmp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCodEmp_KeyPress);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 153);
            this.Controls.Add(this.textBoxCodEmp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxLocal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxCedula);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Empleado";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxCedula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxLocal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxCodEmp;
    }
}