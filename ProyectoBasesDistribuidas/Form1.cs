using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProyectoBasesDistribuidas
{
    public partial class Form1 : Form
    {

        string connectionString = @"Data Source=WIN-ADIPDJQAIL6;Initial Catalog=localQ;Persist Security Info=True;User ID=sa;Password=Pass1234";


        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            using( SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                //Iniciar conexión
                sqlCon.Open();

                //Cliente
                string queryCli = "SELECT * FROM Cliente ORDER BY codCli";
                SqlDataAdapter sqlDa = new SqlDataAdapter(queryCli, sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                dataGridView1.DataSource = dtbl;
                dataGridView1.AutoResizeColumns();

                //Empleados
                string queryEmp = "SELECT codEmp, cedulaEmp, nombreEmp, codLocal FROM empleado_dato AS pv JOIN v_empleado_info AS v ON(pv.codEmpleado = v.codEmp) ORDER BY codEmp;";
                SqlDataAdapter sqlDa2 = new SqlDataAdapter(queryEmp, sqlCon);
                DataTable dtbl2 = new DataTable();
                sqlDa2.Fill(dtbl2);
                dataGridView2.DataSource = dtbl2;
                dataGridView2.AutoResizeColumns();

                //Locales
                string queryLocales = "SELECT * FROM v_locales ORDER BY codLocal";
                SqlDataAdapter sqlDa3 = new SqlDataAdapter(queryLocales, sqlCon);
                DataTable dtbl3 = new DataTable();
                sqlDa3.Fill(dtbl3);
                dataGridView3.DataSource = dtbl3;
                dataGridView3.AutoResizeColumns();

                //Pedidos
                string queryPed = "select * from v_pedido order by codPed;";
                SqlDataAdapter sqlDa4 = new SqlDataAdapter(queryPed, sqlCon);
                DataTable dtbl4 = new DataTable();
                sqlDa4.Fill(dtbl4);
                dataGridView4.DataSource = dtbl4;
                dataGridView4.AutoResizeColumns();

                //Producto
                string queryProd = "select * from v_producto order by codProd;";
                SqlDataAdapter sqlDa5 = new SqlDataAdapter(queryProd, sqlCon);
                DataTable dtbl5 = new DataTable();
                sqlDa5.Fill(dtbl5);
                dataGridView5.DataSource = dtbl5;
                dataGridView5.AutoResizeColumns();

                //Detalle_Pedidos
                string queryDet = "SELECT pv.codPed, fechaPed, pv.codCli, cli.nombreCli, pv.codLocal, cantidadProd, v.codProd, nombreProd FROM v_pedido AS pv JOIN v_detalle AS v ON(pv.codPed = v.codPed) JOIN v_producto as pd ON(v.codProd = pd.codProd) JOIN Cliente as cli ON(pv.codCli = cli.codCli) ORDER BY pv.codPed; ";
                SqlDataAdapter sqlDa6 = new SqlDataAdapter(queryDet, sqlCon);
                DataTable dtbl6 = new DataTable();
                sqlDa6.Fill(dtbl6);
                dataGridView6.DataSource = dtbl6;
                dataGridView6.AutoResizeColumns();

                //Terminar conexión
                sqlCon.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAgregarEmp_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void btnEditarEmp_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private void btnBorrarEmp_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.ShowDialog();
        }

        private void btnNvoPed_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
        }
    }
}