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
    public partial class Form5 : Form
    {

        string connectionString = @"Data Source=WIN-HQN61DK9QE7;Initial Catalog=localG;Persist Security Info=True;User ID=sa;Password=Pass1234";

        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'localQDataSet.v_producto' table. You can move, or remove it, as needed.
            this.v_productoTableAdapter.Fill(this.localQDataSet.v_producto);
            // TODO: This line of code loads data into the 'localQDataSet.v_locales' table. You can move, or remove it, as needed.
            this.v_localesTableAdapter.Fill(this.localQDataSet.v_locales);
            // TODO: This line of code loads data into the 'localQDataSet.Locales' table. You can move, or remove it, as needed.
            this.localesTableAdapter.Fill(this.localQDataSet.Locales);
            // TODO: This line of code loads data into the 'localQDataSet.Cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.localQDataSet.Cliente);
            textBoxFecha.Text = DateTime.Now.ToString("dd-MM-yyyy");
            comboBoxCodCli.SelectedIndex = 0;
            comboBoxCodLocal.SelectedIndex = 0;
            comboBoxProd.SelectedIndex = 0;
        }

        private void textBoxCodPed_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxCantProd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxCodPed_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(this.textBoxCodPed.Text) && !string.IsNullOrWhiteSpace(this.textBoxCantProd.Text))
            {
                this.btnIngPed.Enabled = true;
            }
            else
            {
                this.btnIngPed.Enabled = false;
            }
        }

        private void textBoxFecha_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxCantProd_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(this.textBoxCodPed.Text) && !string.IsNullOrWhiteSpace(this.textBoxCantProd.Text))
            {
                this.btnIngPed.Enabled = true;
            }
            else
            {
                this.btnIngPed.Enabled = false;
            }
        }

        private void btnIngPed_Click(object sender, EventArgs e)
        {
            string loc = "l01";
            if (comboBoxCodLocal.SelectedIndex == 0)
            {
                loc = "l01";
            }
            else if (comboBoxCodLocal.SelectedIndex == 1)
            {
                loc = "l02";
            }

            string codigo = textBoxCodPed.Text;
            string fecha = textBoxFecha.Text;
            string codCli = comboBoxCodCli.Text;
            string cantidad = textBoxCantProd.Text;
            string producto = comboBoxProd.Text;

            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                //Iniciar conexión
                sqlCon.Open();

                //Queries para nuevo Pedido

                string queryEmp1 = "SET XACT_ABORT ON begin distributed tran INSERT INTO v_pedido VALUES ('" + codigo+"','"+fecha+"', '"+codCli+"', '"+loc+"') COMMIT;";
                string queryEmp2 = "SET XACT_ABORT ON begin distributed tran insert into v_detalle values('"+codigo+"', '"+cantidad+"', '"+producto+"', '"+loc+"') commit;";

                SqlCommand sqlDa1 = new SqlCommand(queryEmp1, sqlCon);
                SqlCommand sqlDa2 = new SqlCommand(queryEmp2, sqlCon);

                sqlDa1.ExecuteNonQuery();
                sqlDa2.ExecuteNonQuery();

                //Terminar conexión
                sqlCon.Close();

                MessageBox.Show("Pedido nuevo creado exitosamente");
                this.Close();
            }
        }
    }
}
