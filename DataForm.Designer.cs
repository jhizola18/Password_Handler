namespace PasswordHandler
{
    partial class DataForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            verifiedBox = new GroupBox();
            VerifiedYRb = new RadioButton();
            VerifiedNRb = new RadioButton();
            DateUpdateTxt = new TextBox();
            SaveUpdateBtn = new Button();
            AccountUpdateTxt = new TextBox();
            AccountUpdateLbl = new Label();
            DateUpdateLbl = new Label();
            PasswordUpdateTxt = new TextBox();
            PasswordUpdateLbl = new Label();
            EmailUpdateTxt = new TextBox();
            EmailUpdateLbl = new Label();
            UsernameUpdateTxt = new TextBox();
            UserNameUpdateLbl = new Label();
            tabPage2 = new TabPage();
            deletebtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            verifiedBox.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView1.Location = new Point(21, 12);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(522, 445);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(549, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(229, 445);
            tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(verifiedBox);
            tabPage1.Controls.Add(DateUpdateTxt);
            tabPage1.Controls.Add(SaveUpdateBtn);
            tabPage1.Controls.Add(AccountUpdateTxt);
            tabPage1.Controls.Add(AccountUpdateLbl);
            tabPage1.Controls.Add(DateUpdateLbl);
            tabPage1.Controls.Add(PasswordUpdateTxt);
            tabPage1.Controls.Add(PasswordUpdateLbl);
            tabPage1.Controls.Add(EmailUpdateTxt);
            tabPage1.Controls.Add(EmailUpdateLbl);
            tabPage1.Controls.Add(UsernameUpdateTxt);
            tabPage1.Controls.Add(UserNameUpdateLbl);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(221, 417);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Update";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // verifiedBox
            // 
            verifiedBox.Controls.Add(VerifiedYRb);
            verifiedBox.Controls.Add(VerifiedNRb);
            verifiedBox.Location = new Point(8, 224);
            verifiedBox.Name = "verifiedBox";
            verifiedBox.Size = new Size(137, 66);
            verifiedBox.TabIndex = 15;
            verifiedBox.TabStop = false;
            verifiedBox.Text = "Verified";
            verifiedBox.Enter += groupBox1_Enter;
            // 
            // VerifiedYRb
            // 
            VerifiedYRb.AutoSize = true;
            VerifiedYRb.Location = new Point(11, 22);
            VerifiedYRb.Name = "VerifiedYRb";
            VerifiedYRb.Size = new Size(42, 19);
            VerifiedYRb.TabIndex = 9;
            VerifiedYRb.Text = "Yes";
            VerifiedYRb.UseVisualStyleBackColor = true;
            VerifiedYRb.CheckedChanged += VerifiedYRb_CheckedChanged;
            // 
            // VerifiedNRb
            // 
            VerifiedNRb.AutoSize = true;
            VerifiedNRb.Location = new Point(11, 41);
            VerifiedNRb.Name = "VerifiedNRb";
            VerifiedNRb.Size = new Size(41, 19);
            VerifiedNRb.TabIndex = 10;
            VerifiedNRb.Text = "No";
            VerifiedNRb.UseVisualStyleBackColor = true;
            // 
            // DateUpdateTxt
            // 
            DateUpdateTxt.Location = new Point(7, 195);
            DateUpdateTxt.Name = "DateUpdateTxt";
            DateUpdateTxt.Size = new Size(133, 23);
            DateUpdateTxt.TabIndex = 14;
            DateUpdateTxt.TextChanged += textBox1_TextChanged;
            // 
            // SaveUpdateBtn
            // 
            SaveUpdateBtn.Location = new Point(60, 368);
            SaveUpdateBtn.Name = "SaveUpdateBtn";
            SaveUpdateBtn.Size = new Size(111, 23);
            SaveUpdateBtn.TabIndex = 13;
            SaveUpdateBtn.Text = "Save Changes";
            SaveUpdateBtn.UseVisualStyleBackColor = true;
            SaveUpdateBtn.Click += SaveUpdateBtn_Click;
            // 
            // AccountUpdateTxt
            // 
            AccountUpdateTxt.Location = new Point(8, 317);
            AccountUpdateTxt.Name = "AccountUpdateTxt";
            AccountUpdateTxt.Size = new Size(134, 23);
            AccountUpdateTxt.TabIndex = 12;
            // 
            // AccountUpdateLbl
            // 
            AccountUpdateLbl.AutoSize = true;
            AccountUpdateLbl.Location = new Point(7, 299);
            AccountUpdateLbl.Name = "AccountUpdateLbl";
            AccountUpdateLbl.Size = new Size(58, 15);
            AccountUpdateLbl.TabIndex = 11;
            AccountUpdateLbl.Text = "Account: ";
            // 
            // DateUpdateLbl
            // 
            DateUpdateLbl.AutoSize = true;
            DateUpdateLbl.Location = new Point(6, 177);
            DateUpdateLbl.Name = "DateUpdateLbl";
            DateUpdateLbl.Size = new Size(88, 15);
            DateUpdateLbl.TabIndex = 6;
            DateUpdateLbl.Text = "Date Changed: ";
            // 
            // PasswordUpdateTxt
            // 
            PasswordUpdateTxt.Location = new Point(7, 141);
            PasswordUpdateTxt.Name = "PasswordUpdateTxt";
            PasswordUpdateTxt.Size = new Size(135, 23);
            PasswordUpdateTxt.TabIndex = 5;
            // 
            // PasswordUpdateLbl
            // 
            PasswordUpdateLbl.AutoSize = true;
            PasswordUpdateLbl.Location = new Point(6, 123);
            PasswordUpdateLbl.Name = "PasswordUpdateLbl";
            PasswordUpdateLbl.Size = new Size(63, 15);
            PasswordUpdateLbl.TabIndex = 4;
            PasswordUpdateLbl.Text = "Password: ";
            // 
            // EmailUpdateTxt
            // 
            EmailUpdateTxt.Location = new Point(7, 87);
            EmailUpdateTxt.Name = "EmailUpdateTxt";
            EmailUpdateTxt.Size = new Size(135, 23);
            EmailUpdateTxt.TabIndex = 3;
            // 
            // EmailUpdateLbl
            // 
            EmailUpdateLbl.AutoSize = true;
            EmailUpdateLbl.Location = new Point(7, 69);
            EmailUpdateLbl.Name = "EmailUpdateLbl";
            EmailUpdateLbl.Size = new Size(42, 15);
            EmailUpdateLbl.TabIndex = 2;
            EmailUpdateLbl.Text = "Email: ";
            // 
            // UsernameUpdateTxt
            // 
            UsernameUpdateTxt.BackColor = SystemColors.Window;
            UsernameUpdateTxt.Location = new Point(6, 29);
            UsernameUpdateTxt.Name = "UsernameUpdateTxt";
            UsernameUpdateTxt.Size = new Size(136, 23);
            UsernameUpdateTxt.TabIndex = 1;
            // 
            // UserNameUpdateLbl
            // 
            UserNameUpdateLbl.AutoSize = true;
            UserNameUpdateLbl.Location = new Point(6, 11);
            UserNameUpdateLbl.Name = "UserNameUpdateLbl";
            UserNameUpdateLbl.Size = new Size(63, 15);
            UserNameUpdateLbl.TabIndex = 0;
            UserNameUpdateLbl.Text = "Username:\r\n";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(deletebtn);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(221, 417);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Delete";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // deletebtn
            // 
            deletebtn.Location = new Point(19, 175);
            deletebtn.Name = "deletebtn";
            deletebtn.Size = new Size(182, 77);
            deletebtn.TabIndex = 0;
            deletebtn.Text = "DELETE";
            deletebtn.UseVisualStyleBackColor = true;
            deletebtn.Click += deletebtn_Click;
            // 
            // DataForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 487);
            Controls.Add(tabControl1);
            Controls.Add(dataGridView1);
            Name = "DataForm";
            Text = "Form2";
            Load += DataForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            verifiedBox.ResumeLayout(false);
            verifiedBox.PerformLayout();
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label EmailUpdateLbl;
        private TextBox UsernameUpdateTxt;
        private Label UserNameUpdateLbl;
        private Label PasswordUpdateLbl;
        private TextBox EmailUpdateTxt;
        private Label DateUpdateLbl;
        private TextBox PasswordUpdateTxt;
        private TextBox AccountUpdateTxt;
        private Label AccountUpdateLbl;
        private RadioButton VerifiedNRb;
        private RadioButton VerifiedYRb;
        private Button SaveUpdateBtn;
        private TextBox DateUpdateTxt;
        private GroupBox verifiedBox;
        private Button deletebtn;
    }
}