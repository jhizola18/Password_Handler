using System.Data.SqlTypes;
using System.Xml.Linq;
using System;
using System.ComponentModel.Design.Serialization;
using Mysqlx.Prepare;
using Google.Protobuf.Reflection;
using MySql.Data.MySqlClient;
using MySql.Data.Types;
using System.IO;

namespace PasswordHandler
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        static string connection = "host=localhost;port=3306;database=db_passhandler;uid=root;password=admin";
        MySqlConnection conn = new MySqlConnection(connection);
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                MessageBox.Show("Connection Aqcuired");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Unsuccessful");
            }

            this.textBox1.PasswordChar = '*';

        }


        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            string username = richTextBox1.Text;
            string email = richTextBox2.Text; 
            string password = textBox1.Text;
            DateTime date = DateTime.Now;
            string account = richTextBox4.Text;

            //this string is going to be an arguement in MySqlCommand
            string queries = "INSERT INTO tbl_passhandler(U_name, U_email, U_pass, U_date, U_verified, U_accnt) VALUES (@u_name, @u_email, @u_pass, @u_date, @u_verified, @u_accnt)";
            try
            {
                //MySqlCommand to do command stuff like adding values to your table
                using (MySqlCommand cmd = new MySqlCommand(queries, conn))
                {

                    cmd.Parameters.Add("@u_name", MySqlDbType.VarChar).Value = username;
                    cmd.Parameters.Add("@u_email", MySqlDbType.VarChar).Value = email;
                    cmd.Parameters.Add("@u_pass", MySqlDbType.VarChar).Value = password;
                    cmd.Parameters.Add("@u_date", MySqlDbType.Date).Value = date;
                    cmd.Parameters.Add("@u_verified", MySqlDbType.Bit).Value = false;
                    cmd.Parameters.Add("@u_accnt", MySqlDbType.VarChar).Value = account;

                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Data Saved");
                        conn.Close();
                    }

                };

            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to save!!");
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {



        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataForm dataform = new DataForm();
            dataform.ShowDialog();
            dataform.Hide();
           

        }
    }
}
