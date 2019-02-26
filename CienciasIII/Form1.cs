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

namespace CienciasIII
{
    public partial class login : Form
    {
        MySqlConnection con = new MySqlConnection(@"Data Sourse=localhost;port=3306; Initial Catalog=smite;User Id=root; password=''");
        public login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM usuario";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            int i = Convert.ToInt32(dt.Rows.Count.ToString());
            if (i==0)
            {
                label1.Text = "Ingreso una contraseña o usuario incorrecto";
            }
            else
            {
                this.Hide();
                login fm = new login();
                fm.Show();
            }
            con.Close();
        }
    }
}
