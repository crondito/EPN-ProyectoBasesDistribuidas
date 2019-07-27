using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBasesDistribuidas
{
    public partial class Form2 : Form
    {

        string connectionString = @"Data Source=WIN-ADIPDJQAIL6;Initial Catalog=localQ;Persist Security Info=True;User ID=sa;Password=Pass1234";

        public Form2()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            string loc = "l01";
            if (comboBoxLocal.SelectedIndex == 0)
            {
                loc = "l01";
            }
            else if (comboBoxLocal.SelectedIndex == 1)
            {
                loc = "l02";
            }

            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                //Iniciar conexión
                sqlCon.Open();

                //Empleados

                string codigo = textBoxCodEmp.Text;
                string cedu = textBoxCedula.Text;
                string nomb = textBoxNombre.Text;

                string queryEmp1 = "INSERT INTO Empleado_dato VALUES ('" + codigo + "','" + cedu + "');";
                string queryEmp2 = "SET XACT_ABORT ON begin distributed tran insert into v_empleado_info values('"+codigo+"', '"+nomb+"', '"+loc+"') commit;";

                SqlCommand sqlDa1 = new SqlCommand(queryEmp1, sqlCon);
                SqlCommand sqlDa2 = new SqlCommand(queryEmp2, sqlCon);

                sqlDa1.ExecuteNonQuery();
                sqlDa2.ExecuteNonQuery();

                //Terminar conexión
                sqlCon.Close();

                MessageBox.Show("Empleado agregado exitosamente");
                this.Close();
            }
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            comboBoxLocal.SelectedIndex = 0;
        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(this.textBoxNombre.Text) && !string.IsNullOrWhiteSpace(this.textBoxCedula.Text) && !string.IsNullOrWhiteSpace(this.textBoxCodEmp.Text))
            {
                this.btnAgregar.Enabled = true;
            } else {
                this.btnAgregar.Enabled = false;
            }
            
        }

        private void textBoxCedula_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(this.textBoxNombre.Text) && !string.IsNullOrWhiteSpace(this.textBoxCedula.Text) && !string.IsNullOrWhiteSpace(this.textBoxCodEmp.Text))
            {
                this.btnAgregar.Enabled = true;
            }
            else
            {
                this.btnAgregar.Enabled = false;
            }
        }

        private void textBoxCodEmp_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(this.textBoxNombre.Text) && !string.IsNullOrWhiteSpace(this.textBoxCedula.Text) && !string.IsNullOrWhiteSpace(this.textBoxCodEmp.Text))
            {
                this.btnAgregar.Enabled = true;
            }
            else
            {
                this.btnAgregar.Enabled = false;
            }
        }

        private void textBoxCodEmp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void comboBoxLocal_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
