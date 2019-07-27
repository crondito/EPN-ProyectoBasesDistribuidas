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
    public partial class Form4 : Form
    {

        string connectionString = @"Data Source=WIN-ADIPDJQAIL6;Initial Catalog=localQ;Persist Security Info=True;User ID=sa;Password=Pass1234";

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'localQDataSet.v_empleado_info' table. You can move, or remove it, as needed.
            this.v_empleado_infoTableAdapter.Fill(this.localQDataSet.v_empleado_info);
            comboBoxCodEmp.SelectedIndex = 0;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxCodEmp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                //Iniciar conexión
                sqlCon.Open();

                //Empleados

                string codigo = comboBoxCodEmp.Text;

                string queryEmp1 = "DELETE FROM Empleado_dato WHERE codEmpleado = '"+codigo+"';";
                string queryEmp2 = "SET XACT_ABORT ON begin distributed tran delete from v_empleado_info where codEmp = '"+codigo+"' commit;";

                SqlCommand sqlDa1 = new SqlCommand(queryEmp1, sqlCon);
                SqlCommand sqlDa2 = new SqlCommand(queryEmp2, sqlCon);

                sqlDa1.ExecuteNonQuery();
                sqlDa2.ExecuteNonQuery();

                //Terminar conexión
                sqlCon.Close();

                MessageBox.Show("Empleado eliminado exitosamente");
                this.Close();
            }
        }
    }
}
