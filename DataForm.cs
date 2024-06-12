
namespace PasswordHandler
{

    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.DirectoryServices;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using MySql.Data.MySqlClient;

    public partial class DataForm : Form
    {
        public DataForm()
        {
            InitializeComponent();
        }
        static string connection = ("host=localhost;port=3306;database=db_passhandler;uid=root;password=admin");
        MySqlConnection conn = new MySqlConnection(connection);

        void FillTable()
        {
            string v_query = "SELECT * FROM tbl_passhandler";
            try
            {
                conn.Open();
                using (MySqlDataAdapter v_adapter = new MySqlDataAdapter(v_query, conn))
                {
                    DataTable v_dt = new DataTable();
                    v_adapter.Fill(v_dt);

                    dataGridView1.DataSource = v_dt;
                }
                MessageBox.Show("Data Fetched");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data can not be Fetched");
                conn.Close();
            }
        }
        private void DataForm_Load(object sender, EventArgs e)
        {
            FillTable();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Fetching data from table or query data from table
            string id = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();

            try
            {
                UsernameUpdateTxt.Text = "";
                EmailUpdateTxt.Text = "";
                PasswordUpdateTxt.Text = "";
                DateUpdateTxt.Text = "";
                VerifiedYRb.Checked = false;
                VerifiedNRb.Checked = false;
                AccountUpdateTxt.Text = "";
                string v_query = "SELECT * FROM tbl_passhandler WHERE UID = " + id;
                conn.Open();
                using (MySqlDataAdapter v_adapter = new MySqlDataAdapter(v_query, conn))
                {

                    DataTable v_dt = new DataTable();
                    v_adapter.Fill(v_dt);

                    string username = v_dt.Rows[0].ItemArray[1].ToString();
                    UsernameUpdateTxt.Text = username;
                    UsernameUpdateTxt.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value.ToString();


                    string email = v_dt.Rows[0].ItemArray[2].ToString();
                    EmailUpdateTxt.Text = email;
                    EmailUpdateTxt.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[2].Value.ToString();

                    string password = v_dt.Rows[0].ItemArray[3].ToString();
                    PasswordUpdateTxt.Text = password;
                    PasswordUpdateTxt.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[3].Value.ToString();

                    DateTime date;
                    try
                    {
                        if (DateTime.TryParse(v_dt.Rows[0].ItemArray[4].ToString(), out date))
                        {

                            DateUpdateTxt.Text = date.Date.ToString();


                        }
                        else
                        {
                            MessageBox.Show("Date Invalid");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Date unable to Fetch");
                    }


                    Byte verified;

                    try
                    {
                        if (Byte.TryParse(v_dt.Rows[0].ItemArray[5].ToString(), out verified))
                        {

                            if (verified == 1)
                            {
                                VerifiedYRb.Checked = true;
                                VerifiedYRb.Checked = Convert.ToBoolean(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[5].Value);
                            }
                            else
                            {
                                VerifiedNRb.Checked = true;
                                VerifiedNRb.Checked = Convert.ToBoolean(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[5].Value);
                            }
                        }
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Verified Invalid");
                    }

                    string account = v_dt.Rows[0].ItemArray[6].ToString();
                    AccountUpdateTxt.Text = account;
                    AccountUpdateTxt.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[6].Value.ToString();



                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Fetching data");
                conn.Close();
            }

        }



        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void SaveUpdateBtn_Click(object sender, EventArgs e)
        {

            string ID = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();

            try
            {
                conn.Open();
                string name = UsernameUpdateTxt.Text;
                string email = EmailUpdateTxt.Text;
                string password = PasswordUpdateTxt.Text;
                DateTime date = DateTime.Now;
                Byte verified = 0;
                if (VerifiedYRb.Checked == true)
                {
                    verified = 1;
                }
                else
                {
                    verified = 0;
                }

                string account = AccountUpdateTxt.Text;
                string v_query = "UPDATE tbl_passhandler SET U_name = @u_name, U_email = @u_email, U_pass = @u_pass,U_date = @u_date, U_verified = @u_verified, U_accnt = @u_accnt  WHERE UID = @uid";


                using (MySqlCommand cmd = new MySqlCommand(v_query, conn))
                {

                    cmd.Parameters.AddWithValue("@u_name", name);
                    cmd.Parameters.AddWithValue("@u_email", email);
                    cmd.Parameters.AddWithValue("@u_pass", password);
                    cmd.Parameters.AddWithValue("@u_date", date);
                    cmd.Parameters.AddWithValue("@u_verified", Convert.ToByte(verified));
                    cmd.Parameters.AddWithValue("@u_accnt", account);
                    cmd.Parameters.AddWithValue("@uid", Convert.ToInt32(ID));


                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Updated");
                    conn.Close();

                }
                FillTable();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Data NULLS");
                conn.Close();
            }
        }

        private void VerifiedYRb_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
           

            string ID = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
            try{
                conn.Open();
                string v_query = "DELETE FROM tbl_passhandler WHERE UID = @ID";
                using (MySqlCommand cmd = new MySqlCommand(v_query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(ID));
                    cmd.ExecuteNonQuery();
                    conn.Close();

                }
                MessageBox.Show("Delete Successfully");
                FillTable();
            }
            catch (Exception ex) {
                MessageBox.Show("Delete UnSuccessfully");
                conn.Close();
            }
            
        }
    }

}
