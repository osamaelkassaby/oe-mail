using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace mail
{
    public partial class Form1 : Form
    {
        MySqlConnection conn = new MySqlConnection("server=localhost;database=oe_mail;UID=root;password=;SslMode=none");
        public string user;
        public string email;
        public string token;
        public string firstname;
        public string lastname;
        public int id;
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void username_TextChanged(object sender, EventArgs e)
        {
            if (username.Text.Trim().Equals("Username"))
            {
                username.Text = "";
            }
        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            if (password.Text.Trim().Equals("Password"))
            {
                password.Text = "";
            }
        }

        private void signin_Click(object sender, EventArgs e)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM `users` WHERE email =@email AND password= @password" , conn);
            cmd.Parameters.AddWithValue("@email" , username.Text);
            cmd.Parameters.AddWithValue ("@password" , password.Text);
            MySqlDataReader dr = cmd.ExecuteReader();
            if(dr.HasRows)
            {
                while (dr.Read())
                {
                    user = dr["username"].ToString();
                    email = dr["email"].ToString();
                    token = dr["token"].ToString();
                    firstname = dr["firstname"].ToString();
                    lastname = dr["lastname"].ToString();
                    id = int.Parse(dr["id"].ToString());
                    Form2 form = new Form2();
                    form.id = id;
                    form.user = user;
                    form.token = token;
                    form.ShowDialog();
                    conn.Close();
                    this.Close();
                }

            }
            
        }
    }
}
