namespace ProyectoBasesDistribuidas
{
    partial class Form4
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
            this.comboBoxCodEmp = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.localQDataSet = new ProyectoBasesDistribuidas.localQDataSet();
            this.vempleadoinfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_empleado_infoTableAdapter = new ProyectoBasesDistribuidas.localQDataSetTableAdapters.v_empleado_infoTableAdapter();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.localQDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vempleadoinfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxCodEmp
            // 
            this.comboBoxCodEmp.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.vempleadoinfoBindingSource, "codEmp", true));
            this.comboBoxCodEmp.DataSource = this.vempleadoinfoBindingSource;
            this.comboBoxCodEmp.DisplayMember = "codEmp";
            this.comboBoxCodEmp.FormattingEnabled = true;
            this.comboBoxCodEmp.Location = new System.Drawing.Point(108, 6);
            this.comboBoxCodEmp.Name = "comboBoxCodEmp";
            this.comboBoxCodEmp.Size = new System.Drawing.Size(77, 21);
            this.comboBoxCodEmp.TabIndex = 21;
            this.comboBoxCodEmp.ValueMember = "codEmp";
            this.comboBoxCodEmp.SelectedIndexChanged += new System.EventHandler(this.comboBoxCodEmp_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Código Empleado";
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
            // btnCancelar
            // 
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Location = new System.Drawing.Point(110, 45);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 23;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.Location = new System.Drawing.Point(12, 45);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 22;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(197, 85);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.comboBoxCodEmp);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eliminar Empleado";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.localQDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vempleadoinfoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCodEmp;
        private System.Windows.Forms.Label label4;
        private localQDataSet localQDataSet;
        private System.Windows.Forms.BindingSource vempleadoinfoBindingSource;
        private localQDataSetTableAdapters.v_empleado_infoTableAdapter v_empleado_infoTableAdapter;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEliminar;
    }
}