using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;


namespace ProjetResto
{
    public partial class Form3 : Form
    {
        SqlConnection cnx;

        public Form3()
        {
            InitializeComponent();
            cnx = new SqlConnection(@"Data Source=DESKTOP-FC6ROF6\SQLEXPRESS;Initial Catalog=projetresto4;Integrated Security=True");

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cnx.Open();
            String sql = "insert into Reservations(Nom, Contact, Nombre_personnes) values(" + textNom.Text + ",'" + textContact.Text + "'," + listPlace.Text + ")";
            SqlCommand cmd = new SqlCommand(sql, cnx);
            //cmd.ExecuteNonQuery();
            cnx.Close();

        }
    }
}
