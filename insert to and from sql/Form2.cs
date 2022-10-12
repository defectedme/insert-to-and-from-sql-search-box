using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace insert_to_and_from_sql
{
    public partial class Form2 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-6795RSE;Initial Catalog=Northwind;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;


        public Form2()
        {
            InitializeComponent();

        }



        private void Form2_Load(object sender, EventArgs e)
        {
            con.Open();
            Order orders = new Order();
            orderBindingSource.Filter = null;

            SqlCommand cmd = new SqlCommand("Select * from Orders", con);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();


            da.Fill(dt);


            notifyIcon1.Icon = SystemIcons.Application;
            con.Close();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            NorthwindEntities db = new NorthwindEntities();
            db.Orders.Add(orderBindingSource.Current as Order); 
            
            int result = await db.SaveChangesAsync();
            if (result > 0)
                notifyIcon1.ShowBalloonTip(3000, "Message", "Saved", ToolTipIcon.Info);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 from3 = new Form3();
            from3.Show();
        }
    }
}
