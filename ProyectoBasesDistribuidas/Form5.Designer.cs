namespace ProyectoBasesDistribuidas
{
    partial class Form5
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCodPed = new System.Windows.Forms.TextBox();
            this.textBoxFecha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxCodCli = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.localQDataSet = new ProyectoBasesDistribuidas.localQDataSet();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteTableAdapter = new ProyectoBasesDistribuidas.localQDataSetTableAdapters.ClienteTableAdapter();
            this.comboBoxCodLocal = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.localesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.localesTableAdapter = new ProyectoBasesDistribuidas.localQDataSetTableAdapters.LocalesTableAdapter();
            this.textBoxCantProd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.vlocalesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_localesTableAdapter = new ProyectoBasesDistribuidas.localQDataSetTableAdapters.v_localesTableAdapter();
            this.comboBoxProd = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnIngPed = new System.Windows.Forms.Button();
            this.vproductoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_productoTableAdapter = new ProyectoBasesDistribuidas.localQDataSetTableAdapters.v_productoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.localQDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.localesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vlocalesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vproductoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(119, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Codigo Pedido";
            // 
            // textBoxCodPed
            // 
            this.textBoxCodPed.Location = new System.Drawing.Point(94, 6);
            this.textBoxCodPed.MaxLength = 4;
            this.textBoxCodPed.Name = "textBoxCodPed";
            this.textBoxCodPed.Size = new System.Drawing.Size(100, 20);
            this.textBoxCodPed.TabIndex = 2;
            this.textBoxCodPed.TextChanged += new System.EventHandler(this.textBoxCodPed_TextChanged);
            this.textBoxCodPed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCodPed_KeyPress);
            // 
            // textBoxFecha
            // 
            this.textBoxFecha.Enabled = false;
            this.textBoxFecha.Location = new System.Drawing.Point(94, 33);
            this.textBoxFecha.Name = "textBoxFecha";
            this.textBoxFecha.Size = new System.Drawing.Size(100, 20);
            this.textBoxFecha.TabIndex = 3;
            this.textBoxFecha.TextChanged += new System.EventHandler(this.textBoxFecha_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fecha";
            // 
            // comboBoxCodCli
            // 
            this.comboBoxCodCli.DataSource = this.clienteBindingSource;
            this.comboBoxCodCli.DisplayMember = "codCli";
            this.comboBoxCodCli.FormattingEnabled = true;
            this.comboBoxCodCli.Location = new System.Drawing.Point(94, 60);
            this.comboBoxCodCli.Name = "comboBoxCodCli";
            this.comboBoxCodCli.Size = new System.Drawing.Size(100, 21);
            this.comboBoxCodCli.TabIndex = 5;
            this.comboBoxCodCli.ValueMember = "codCli";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Código Cliente";
            // 
            // localQDataSet
            // 
            this.localQDataSet.DataSetName = "localQDataSet";
            this.localQDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.localQDataSet;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // comboBoxCodLocal
            // 
            this.comboBoxCodLocal.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.vlocalesBindingSource, "codLocal", true));
            this.comboBoxCodLocal.FormattingEnabled = true;
            this.comboBoxCodLocal.Items.AddRange(new object[] {
            "Quito",
            "Cuenca"});
            this.comboBoxCodLocal.Location = new System.Drawing.Point(94, 88);
            this.comboBoxCodLocal.Name = "comboBoxCodLocal";
            this.comboBoxCodLocal.Size = new System.Drawing.Size(99, 21);
            this.comboBoxCodLocal.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Local";
            // 
            // localesBindingSource
            // 
            this.localesBindingSource.DataMember = "Locales";
            this.localesBindingSource.DataSource = this.localQDataSet;
            // 
            // localesTableAdapter
            // 
            this.localesTableAdapter.ClearBeforeFill = true;
            // 
            // textBoxCantProd
            // 
            this.textBoxCantProd.Location = new System.Drawing.Point(94, 116);
            this.textBoxCantProd.MaxLength = 2;
            this.textBoxCantProd.Name = "textBoxCantProd";
            this.textBoxCantProd.Size = new System.Drawing.Size(100, 20);
            this.textBoxCantProd.TabIndex = 9;
            this.textBoxCantProd.Text = "1";
            this.textBoxCantProd.TextChanged += new System.EventHandler(this.textBoxCantProd_TextChanged);
            this.textBoxCantProd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCantProd_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Cantidad";
            // 
            // vlocalesBindingSource
            // 
            this.vlocalesBindingSource.DataMember = "v_locales";
            this.vlocalesBindingSource.DataSource = this.localQDataSet;
            // 
            // v_localesTableAdapter
            // 
            this.v_localesTableAdapter.ClearBeforeFill = true;
            // 
            // comboBoxProd
            // 
            this.comboBoxProd.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.vproductoBindingSource, "codProd", true));
            this.comboBoxProd.DataSource = this.vproductoBindingSource;
            this.comboBoxProd.DisplayMember = "codProd";
            this.comboBoxProd.FormattingEnabled = true;
            this.comboBoxProd.Location = new System.Drawing.Point(94, 143);
            this.comboBoxProd.Name = "comboBoxProd";
            this.comboBoxProd.Size = new System.Drawing.Size(100, 21);
            this.comboBoxProd.TabIndex = 11;
            this.comboBoxProd.ValueMember = "codProd";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Producto";
            // 
            // btnIngPed
            // 
            this.btnIngPed.Enabled = false;
            this.btnIngPed.Location = new System.Drawing.Point(16, 181);
            this.btnIngPed.Name = "btnIngPed";
            this.btnIngPed.Size = new System.Drawing.Size(97, 23);
            this.btnIngPed.TabIndex = 13;
            this.btnIngPed.Text = "Ingresar Pedido";
            this.btnIngPed.UseVisualStyleBackColor = true;
            this.btnIngPed.Click += new System.EventHandler(this.btnIngPed_Click);
            // 
            // vproductoBindingSource
            // 
            this.vproductoBindingSource.DataMember = "v_producto";
            this.vproductoBindingSource.DataSource = this.localQDataSet;
            // 
            // v_productoTableAdapter
            // 
            this.v_productoTableAdapter.ClearBeforeFill = true;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 216);
            this.Controls.Add(this.btnIngPed);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxProd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxCantProd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxCodLocal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxCodCli);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxFecha);
            this.Controls.Add(this.textBoxCodPed);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Pedido";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.localQDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.localesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vlocalesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vproductoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCodPed;
        private System.Windows.Forms.TextBox textBoxFecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxCodCli;
        private System.Windows.Forms.Label label3;
        private localQDataSet localQDataSet;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private localQDataSetTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.ComboBox comboBoxCodLocal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource localesBindingSource;
        private localQDataSetTableAdapters.LocalesTableAdapter localesTableAdapter;
        private System.Windows.Forms.TextBox textBoxCantProd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource vlocalesBindingSource;
        private localQDataSetTableAdapters.v_localesTableAdapter v_localesTableAdapter;
        private System.Windows.Forms.ComboBox comboBoxProd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnIngPed;
        private System.Windows.Forms.BindingSource vproductoBindingSource;
        private localQDataSetTableAdapters.v_productoTableAdapter v_productoTableAdapter;
    }
}