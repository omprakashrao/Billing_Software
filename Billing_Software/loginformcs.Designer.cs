namespace Billing_Software
{
    partial class loginformcs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginformcs));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            un = new TextBox();
            pw = new TextBox();
            checkBox1 = new CheckBox();
            button1 = new Button();
            pictureBox2 = new PictureBox();
            linkLabel1 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(23, 83);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(229, 229);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(130, 28);
            label1.Name = "label1";
            label1.Size = new Size(229, 39);
            label1.TabIndex = 1;
            label1.Text = "LOGIN FORM";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(254, 83);
            label2.Name = "label2";
            label2.Size = new Size(51, 18);
            label2.TabIndex = 2;
            label2.Text = "LogIn";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(254, 142);
            label3.Name = "label3";
            label3.Size = new Size(86, 21);
            label3.TabIndex = 3;
            label3.Text = "UserName";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(254, 195);
            label4.Name = "label4";
            label4.Size = new Size(79, 21);
            label4.TabIndex = 4;
            label4.Text = "Password";
            // 
            // un
            // 
            un.Location = new Point(355, 142);
            un.Name = "un";
            un.Size = new Size(100, 23);
            un.TabIndex = 5;
            un.TextChanged += textBox1_TextChanged;
            // 
            // pw
            // 
            pw.Location = new Point(355, 193);
            pw.Name = "pw";
            pw.Size = new Size(100, 23);
            pw.TabIndex = 6;
            pw.UseSystemPasswordChar = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(355, 222);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(105, 19);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "ShowPassword";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(258, 267);
            button1.Name = "button1";
            button1.Size = new Size(202, 41);
            button1.TabIndex = 8;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(270, 277);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(25, 22);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            linkLabel1.Location = new Point(254, 315);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(212, 20);
            linkLabel1.TabIndex = 10;
            linkLabel1.TabStop = true;
            linkLabel1.Text = " Not Ragistred Yet? Click Here";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // loginformcs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(511, 360);
            Controls.Add(linkLabel1);
            Controls.Add(pictureBox2);
            Controls.Add(button1);
            Controls.Add(checkBox1);
            Controls.Add(pw);
            Controls.Add(un);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "loginformcs";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "loginformcs";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox un;
        private TextBox pw;
        private CheckBox checkBox1;
        private Button button1;
        private PictureBox pictureBox2;
        private LinkLabel linkLabel1;
    }
}