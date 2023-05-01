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
    public partial class Form2 : Form
    {
        MySqlConnection conn = new MySqlConnection("server=localhost;database=oe_mail;UID=root;password=;SslMode=none");
        public Form2()
        {
            InitializeComponent();
        }
        public string user;
        public int id;
        public string token;

        private void username_Click(object sender, EventArgs e)
        {
            if (username.Text.Trim().Equals("Username"))
            {
                username.Text = "";
            }
                  }

        private void subject_Click(object sender, EventArgs e)
        {

            if (subject.Text.Trim().Equals("Subject"))
            {
                subject.Text = "";
            }
        }

        private void message_Click(object sender, EventArgs e)
        {

            if (message.Text.Trim().Equals("Message"))
            {
                message.Text = "";
            }
        }

        private void send_Click(object sender, EventArgs e)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO `inbox`(`username`, `subject` , `message` ,`userID` ,`token`) VALUES(@username,@subject,@msg,@userID , @token)" , conn);
            cmd.Parameters.AddWithValue("@username", username.Text);
            cmd.Parameters.AddWithValue("@subject", subject.Text);
            cmd.Parameters.AddWithValue("@msg", message.Text);
            cmd.Parameters.AddWithValue("@userID", id);
            cmd.Parameters.AddWithValue("@token", token);
            try
            {
                cmd.ExecuteNonQuery();
                Alert alert = new Alert();
                alert.Show();
            }
            catch (Exception ex) { 
                MessageBox.Show(ex.Message);
            }

        }
    }
}
