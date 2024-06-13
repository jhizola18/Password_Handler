
namespace PasswordHandler
{

    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.DirectoryServices;
    using System.Drawing;
    using System.Linq;
    using System.Runtime.ConstrainedExecution;
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

        static string connection = "host=localhost;port=3306;database=db_passhandler;uid=root;password=admin";
        MySqlConnection conn = new MySqlConnection(connection);

        void FillTable()
        {
            
            try {
                conn.Open();
                string queries = "SELECT * FROM tbl_passhandler";
                using (MySqlDataAdapter v_adapter = new MySqlDataAdapter(queries, conn)) {

                    DataTable dt = new DataTable();
                    v_adapter.Fill(dt);

                    dataGridView1.DataSource = dt;

                    MessageBox.Show("Data Connected");
                    conn.Close();
                }

            }
            catch (Exception ex) {
                MessageBox.Show("Data can't connect");
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
            string ID = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
            conn.Open();
            try {
               
                UsernameUpdateTxt.Text = "";
                EmailUpdateTxt.Text = "";
                PasswordUpdateTxt.Text = "";
                DateUpdateTxt.Text = "";
                VerifiedNRb.Checked = false;
                VerifiedYRb.Checked = false;
                AccountUpdateTxt.Text = "";

                string queries = "SELECT * FROM tbl_passhandler WHERE UID = " + ID;
                using (MySqlDataAdapter v_adapter = new MySqlDataAdapter(queries, conn)) {

                    DataTable dt = new DataTable();
                    v_adapter.Fill(dt);

                    
                    UsernameUpdateTxt.Text = dt.Rows[0].ItemArray[1].ToString();
                    string name = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value.ToString();


                   
                    EmailUpdateTxt.Text = dt.Rows[0].ItemArray[2].ToString();
                    string email = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[2].Value.ToString();


                   
                    PasswordUpdateTxt.Text = dt.Rows[0].ItemArray[3].ToString();
                    string pass = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[3].Value.ToString();


                    DateTime date;
                    try
                    {
                       
                        if (DateTime.TryParse(dt.Rows[0].ItemArray[4].ToString(), out date))
                        {

                            DateUpdateTxt.Text = date.ToString();
                            MessageBox.Show("Date Fetched");
                        }

                    }
                    catch (Exception ex) {
                        MessageBox.Show("Date can't Fetched");
                    }
                  
                   

                    Byte verified;
                    try
                    {
                        if (Byte.TryParse(dt.Rows[0].ItemArray[5].ToString(), out verified))
                        {

                            if (verified == 1)
                            {

                                VerifiedYRb.Checked = true;

                            }
                            else
                            {
                                VerifiedNRb.Checked = true;
                            }

                            MessageBox.Show("Verifying Account Success");
                        }


                    }
                    catch (Exception ex) {
                        MessageBox.Show("Verifying Account Unsuccess");
                    }
                   
                    string accnt = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[6].Value.ToString();
                    AccountUpdateTxt.Text = dt.Rows[0].ItemArray[6].ToString();

                    MessageBox.Show("Successful fetching data");
                    conn.Close();
                }

            }
            catch (Exception ex) {
                MessageBox.Show("Unsuccessful fetching data");
                conn.Close();
            }
            FillTable();

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

        Byte getverified() {

            Byte ver = 0;
            if (VerifiedYRb.Checked == true)
            {
                ver = 1;
            }
            else {
                ver = 0;
            }


            return ver;
        
        }

        private void SaveUpdateBtn_Click(object sender, EventArgs e)
        {
            
            string ID = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();

            string name = UsernameUpdateTxt.Text;
            string email = EmailUpdateTxt.Text;
            string password = PasswordUpdateTxt.Text;
            DateTime date = DateTime.Now;
            Byte verified;
            if (VerifiedYRb.Checked == true)
            {
                verified = 1;
            }
            else
            {
                verified = 0;
            }
            string account = AccountUpdateTxt.Text; 
            try
            {
                conn.Open();
                string queries = "UPDATE tbl_passhandler SET U_name = @u_name, U_email = @u_email, U_pass = @u_pass, U_date = @u_date, U_verified = @u_verified, U_accnt = @u_accnt WHERE UID = @uid";
                using (MySqlCommand cmd = new MySqlCommand(queries, conn)) {


                    cmd.Parameters.AddWithValue("@u_name", name);
                    cmd.Parameters.AddWithValue("@u_email", email);
                    cmd.Parameters.AddWithValue("@u_pass", password);
                    cmd.Parameters.AddWithValue("@u_date", date);
                    cmd.Parameters.AddWithValue("@u_verified", verified);
                    cmd.Parameters.AddWithValue("@u_accnt",account);
                    cmd.Parameters.AddWithValue("@uid", Convert.ToInt32(ID));

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Update Successfully");
                    conn.Close();
                }

            }
            catch (Exception ex) {
                MessageBox.Show("Update Unsuccessfully");
                conn.Close();
            }
            FillTable();

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
            try
            {
                conn.Open();
                string queries = "DELETE FROM tbl_passhandler WHERE UID = @uid";
                using (MySqlCommand cmd = new MySqlCommand(queries,conn)){

                    cmd.Parameters.AddWithValue("@uid", ID);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Deleted");
                    conn.Close();
                }
            }
            catch (Exception ex) {

                MessageBox.Show("Data can't Delete");
                conn.Close();
            }
            FillTable();
        }
    }

}
