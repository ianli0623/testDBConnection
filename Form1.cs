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

namespace testDBConnection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txt_con.Text = "Data Source=localhost;Initial Catalog=; Persist Security Info=True;User ID=sa;Password=";
        }

        private void OK_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(txt_con.Text);
                conn.Open();
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    MessageBox.Show("success");
                }
                else
                {
                    MessageBox.Show("fail!");
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
