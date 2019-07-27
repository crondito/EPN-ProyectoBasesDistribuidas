namespace ProyectoBasesDistribuidas
{
    partial class Form3
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
            this.components = new System.ComponentModel.Container();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxLocal = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCedula = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.comboBoxCodEmp = new System.Windows.Forms.ComboBox();
            this.localQDataSet = new ProyectoBasesDistribuidas.localQDataSet();
            this.vempleadoinfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_empleado_infoTableAdapter = new ProyectoBasesDistribuidas.localQDataSetTableAdapters.v_empleado_infoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.localQDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vempleadoinfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Código Empleado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Local";
            // 
            // comboBoxLocal
            // 
            this.comboBoxLocal.FormattingEnabled = true;
            this.comboBoxLocal.Items.AddRange(new object[] {
            "Quito",
            "Cuenca"});
            this.comboBoxLocal.Location = new System.Drawing.Point(66, 84);
            this.comboBoxLocal.Name = "comboBoxLocal";
            this.comboBoxLocal.Size = new System.Drawing.Size(121, 21);
            this.comboBoxLocal.TabIndex = 16;
            this.comboBoxLocal.SelectedIndexChanged += new System.EventHandler(this.comboBoxLocal_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Cédula:";
            // 
            // textBoxCedula
            // 
            this.textBoxCedula.Location = new System.Drawing.Point(65, 58);
            this.textBoxCedula.MaxLength = 10;
            this.textBoxCedula.Name = "textBoxCedula";
            this.textBoxCedula.Size = new System.Drawing.Size(121, 20);
            this.textBoxCedula.TabIndex = 14;
            this.textBoxCedula.TextChanged += new System.EventHandler(this.textBoxCedula_TextChanged);
            this.textBoxCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCedula_KeyPress);
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(66, 32);
            this.textBoxNombre.MaxLength = 40;
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(121, 20);
            this.textBoxNombre.TabIndex = 13;
            this.textBoxNombre.TextChanged += new System.EventHandler(this.textBoxNombre_TextChanged);
            this.textBoxNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNombre_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nombre:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Location = new System.Drawing.Point(112, 111);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.Enabled = false;
            this.btnModificar.Location = new System.Drawing.Point(15, 111);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 10;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // comboBoxCodEmp
            // 
            this.comboBoxCodEmp.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.vempleadoinfoBindingSource, "codEmp", true));
            this.comboBoxCodEmp.DataSource = this.vempleadoinfoBindingSource;
            this.comboBoxCodEmp.DisplayMember = "codEmp";
            this.comboBoxCodEmp.FormattingEnabled = true;
            this.comboBoxCodEmp.Location = new System.Drawing.Point(109, 5);
            this.comboBoxCodEmp.Name = "comboBoxCodEmp";
            this.comboBoxCodEmp.Size = new System.Drawing.Size(77, 21);
            this.comboBoxCodEmp.TabIndex = 19;
            this.comboBoxCodEmp.ValueMember = "codEmp";
            this.comboBoxCodEmp.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // localQDataSet
            // 
            this.localQDataSet.DataSetName = "localQDataSet";
            this.localQDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vempleadoinfoBindingSource
            // 
            this.vempleadoinfoBindingSource.DataMember = "v_empleado_info";
            this.vempleadoinfoBindingSource.DataSource = this.localQDataSet;
            // 
            // v_empleado_infoTableAdapter
            // 
            this.v_empleado_infoTableAdapter.ClearBeforeFill = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(203, 150);
            this.Controls.Add(this.comboBoxCodEmp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxLocal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxCedula);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnModificar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Empleado";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.localQDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vempleadoinfoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxLocal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCedula;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.ComboBox comboBoxCodEmp;
        private localQDataSet localQDataSet;
        private System.Windows.Forms.BindingSource vempleadoinfoBindingSource;
        private localQDataSetTableAdapters.v_empleado_infoTableAdapter v_empleado_infoTableAdapter;
    }
}