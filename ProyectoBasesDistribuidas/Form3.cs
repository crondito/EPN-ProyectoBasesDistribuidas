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
    public partial class Form3 : Form
    {

        string connectionString = @"Data Source=WIN-ADIPDJQAIL6;Initial Catalog=localQ;Persist Security Info=True;User ID=sa;Password=Pass1234";

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'localQDataSet.v_empleado_info' table. You can move, or remove it, as needed.
            this.v_empleado_infoTableAdapter.Fill(this.localQDataSet.v_empleado_info);
            comboBoxLocal.SelectedIndex = 0;
            comboBoxCodEmp.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxLocal_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
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

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(this.textBoxNombre.Text) && !string.IsNullOrWhiteSpace(this.textBoxCedula.Text))
            {
                this.btnModificar.Enabled = true;
            }
            else
            {
                this.btnModificar.Enabled = false;
            }
        }

        private void textBoxCedula_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(this.textBoxNombre.Text) && !string.IsNullOrWhiteSpace(this.textBoxCedula.Text))
            {
                this.btnModificar.Enabled = true;
            }
            else
            {
                this.btnModificar.Enabled = false;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
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

                string codigo = comboBoxCodEmp.Text;
                string cedu = textBoxCedula.Text;
                string nomb = textBoxNombre.Text;

                string queryEmp1 = "UPDATE Empleado_dato set cedulaEmp = '"+cedu+"' where codEmpleado = '"+codigo+"';";
                string queryEmp2 = "SET XACT_ABORT ON begin distributed tran update v_empleado_info set nombreEmp = '"+nomb+"', codLocal = '"+loc+"' where codEmp = '"+codigo+"' commit;";

                SqlCommand sqlDa1 = new SqlCommand(queryEmp1, sqlCon);
                SqlCommand sqlDa2 = new SqlCommand(queryEmp2, sqlCon);

                sqlDa1.ExecuteNonQuery();
                sqlDa2.ExecuteNonQuery();

                //Terminar conexión
                sqlCon.Close();

                MessageBox.Show("Empleado modificado exitosamente");
                this.Close();
            }
        }
    }
}
