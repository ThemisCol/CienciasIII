using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ciencias3
{
    public partial class login : Form
    {
        MySqlConnection con = new MySqlConnection("Server='localhost'; Database='smite'; Uid='root'; Pwd='';"); 
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                MessageBox.Show("Conectados");
                con.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Error");
            }  
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void loginB_Click(object sender, EventArgs e)
        {
            String sql = sqldato.Text;
            MySqlCommand com = new MySqlCommand(sql, con);
            MySqlDataAdapter adp = new MySqlDataAdapter();
            adp.SelectCommand = com;
            DataTable tab = new DataTable();
            adp.Fill(tab);
            usuariosT.DataSource = tab;
        }

        private void sqldato_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
