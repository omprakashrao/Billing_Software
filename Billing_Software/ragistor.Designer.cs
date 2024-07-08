namespace Billing_Software
{
    partial class ragistor
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
            ComponentResourceManager resources = new ComponentResourceManager(typeof(ragistor));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            linkLabel1 = new LinkLabel();
            tableLayoutPanel1 = new TableLayoutPanel();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            button2 = new Button();
            button1 = new Button();
            name = new TextBox();
            surname = new TextBox();
            address = new TextBox();
            email = new TextBox();
            password = new TextBox();
            con = new TextBox();
            gender = new ComboBox();
            age = new NumericUpDown();
            ((ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            ((ISupportInitialize)age).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Book Antiqua", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(272, 24);
            label1.Name = "label1";
            label1.Size = new Size(210, 28);
            label1.TabIndex = 0;
            label1.Text = "Registration-Form";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(30, 68);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(288, 386);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            linkLabel1.Location = new Point(30, 458);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(171, 20);
            linkLabel1.TabIndex = 2;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "I Have Already Member";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Left;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label5, 0, 3);
            tableLayoutPanel1.Controls.Add(label6, 0, 4);
            tableLayoutPanel1.Controls.Add(label7, 0, 5);
            tableLayoutPanel1.Controls.Add(label8, 0, 6);
            tableLayoutPanel1.Controls.Add(label9, 0, 7);
            tableLayoutPanel1.Controls.Add(label4, 0, 2);
            tableLayoutPanel1.Controls.Add(label3, 0, 1);
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(button2, 0, 8);
            tableLayoutPanel1.Controls.Add(button1, 1, 8);
            tableLayoutPanel1.Controls.Add(name, 1, 0);
            tableLayoutPanel1.Controls.Add(surname, 1, 1);
            tableLayoutPanel1.Controls.Add(address, 1, 4);
            tableLayoutPanel1.Controls.Add(email, 1, 5);
            tableLayoutPanel1.Controls.Add(password, 1, 6);
            tableLayoutPanel1.Controls.Add(con, 1, 7);
            tableLayoutPanel1.Controls.Add(gender, 1, 2);
            tableLayoutPanel1.Controls.Add(age, 1, 3);
            tableLayoutPanel1.Location = new Point(345, 68);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 9;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel1.Size = new Size(345, 448);
            tableLayoutPanel1.TabIndex = 3;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(3, 158);
            label5.Name = "label5";
            label5.Padding = new Padding(10, 5, 0, 0);
            label5.Size = new Size(55, 27);
            label5.TabIndex = 3;
            label5.Text = "AGE";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(3, 207);
            label6.Name = "label6";
            label6.Padding = new Padding(10, 5, 0, 0);
            label6.Size = new Size(99, 27);
            label6.TabIndex = 4;
            label6.Text = "ADDRESS";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(3, 256);
            label7.Name = "label7";
            label7.Padding = new Padding(10, 5, 0, 0);
            label7.Size = new Size(74, 27);
            label7.TabIndex = 5;
            label7.Text = "EMAIL";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Left;
            label8.AutoSize = true;
            label8.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(3, 305);
            label8.Name = "label8";
            label8.Padding = new Padding(10, 5, 0, 0);
            label8.Size = new Size(114, 27);
            label8.TabIndex = 6;
            label8.Text = "PASSWORD";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Left;
            label9.AutoSize = true;
            label9.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(3, 343);
            label9.Name = "label9";
            label9.Padding = new Padding(10, 5, 0, 0);
            label9.Size = new Size(114, 49);
            label9.TabIndex = 7;
            label9.Text = "CONFORM PASSWORD";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            label9.Click += label9_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(3, 109);
            label4.Name = "label4";
            label4.Padding = new Padding(10, 5, 0, 0);
            label4.Size = new Size(90, 27);
            label4.TabIndex = 2;
            label4.Text = "GENDER";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(3, 60);
            label3.Name = "label3";
            label3.Padding = new Padding(10, 5, 0, 0);
            label3.Size = new Size(104, 27);
            label3.TabIndex = 1;
            label3.Text = "SURNAME";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(3, 11);
            label2.Name = "label2";
            label2.Padding = new Padding(10, 5, 0, 0);
            label2.Size = new Size(71, 27);
            label2.TabIndex = 0;
            label2.Text = "NAME";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            label2.UseMnemonic = false;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Right;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(62, 404);
            button2.Name = "button2";
            button2.Size = new Size(107, 31);
            button2.TabIndex = 8;
            button2.Text = "SUNGUP";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Left;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(175, 404);
            button1.Name = "button1";
            button1.Size = new Size(107, 31);
            button1.TabIndex = 9;
            button1.Text = "RESET";
            button1.UseVisualStyleBackColor = true;
            // 
            // name
            // 
            name.Anchor = AnchorStyles.Left;
            name.Location = new Point(175, 13);
            name.Name = "name";
            name.Size = new Size(100, 23);
            name.TabIndex = 0;
            // 
            // surname
            // 
            surname.Anchor = AnchorStyles.Left;
            surname.Location = new Point(175, 62);
            surname.Name = "surname";
            surname.Size = new Size(100, 23);
            surname.TabIndex = 1;
            surname.TextChanged += surname_TextChanged;
            // 
            // address
            // 
            address.Anchor = AnchorStyles.Left;
            address.Location = new Point(175, 199);
            address.Multiline = true;
            address.Name = "address";
            address.Size = new Size(167, 43);
            address.TabIndex = 4;
            // 
            // email
            // 
            email.Anchor = AnchorStyles.Left;
            email.Location = new Point(175, 258);
            email.Name = "email";
            email.Size = new Size(100, 23);
            email.TabIndex = 5;
            // 
            // password
            // 
            password.Anchor = AnchorStyles.Left;
            password.Location = new Point(175, 307);
            password.Name = "password";
            password.Size = new Size(100, 23);
            password.TabIndex = 6;
            password.UseSystemPasswordChar = true;
            // 
            // con
            // 
            con.Anchor = AnchorStyles.Left;
            con.Location = new Point(175, 356);
            con.Name = "con";
            con.Size = new Size(100, 23);
            con.TabIndex = 7;
            // 
            // gender
            // 
            gender.Anchor = AnchorStyles.Left;
            gender.FormattingEnabled = true;
            gender.Items.AddRange(new object[] { "MALE", "FEMALE", "OTHER" });
            gender.Location = new Point(175, 111);
            gender.Name = "gender";
            gender.Size = new Size(121, 23);
            gender.TabIndex = 2;
            // 
            // age
            // 
            age.Anchor = AnchorStyles.Left;
            age.Location = new Point(175, 160);
            age.Name = "age";
            age.Size = new Size(120, 23);
            age.TabIndex = 3;
            // 
            // ragistor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 569);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(linkLabel1);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "ragistor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ragistor";
            ((ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((ISupportInitialize)age).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private LinkLabel linkLabel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label4;
        private Button button1;
        private Button button2;
        private TextBox name;
        private TextBox surname;
        private TextBox address;
        private TextBox email;
        private TextBox password;
        private TextBox con;
        private ComboBox gender;
        private NumericUpDown age;
    }
}