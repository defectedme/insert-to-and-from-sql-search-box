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

namespace insert_to_and_from_sql
{
    public partial class Form3 : Form
    {

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-6795RSE;Initial Catalog=Northwind;Integrated Security=True");



        public Form3()
        {
            InitializeComponent();
        }

        private void ordersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ordersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.northwindDataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {

            NorthwindDataSet.OrdersDataTable order = new NorthwindDataSet.OrdersDataTable();
            // TODO: This line of code loads data into the 'northwindDataSet.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.northwindDataSet.Orders);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int userVal = int.Parse(orderIDTextBox.Text);
            //SqlCommand cmd = new SqlCommand("Select * from Orders where CustomerID LIKE  " + userVal + "", con);
            SqlCommand cmd = new SqlCommand("Select * from Orders where OrderID = " + userVal + "", con);
            //cmd.Parameters.Add(new SqlParameter(@"inputTB", inputTB.Text));
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();



        }
    }
}
