using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace insert_to_and_from_sql
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            NorthwindEntities db = new NorthwindEntities();
            db.Customers.Add(customerBindingSource.Current as Customer);
            int result = await db.SaveChangesAsync();
            if (result > 0)
                notifyIcon1.ShowBalloonTip(3000 ,"Message", "Saved",ToolTipIcon.Info);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            customerBindingSource.DataSource = new Customer();
            notifyIcon1.Icon = SystemIcons.Application;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 from2 = new Form2();
            from2.Show();
        }
    }
}
