namespace Billing_Software
{
    partial class Additem
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
            ComponentResourceManager resources = new ComponentResourceManager(typeof(Additem));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel1 = new Panel();
            button1 = new Button();
            discountt = new TextBox();
            pricet = new TextBox();
            namet = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            ((ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 50);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(236, 283);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(266, 18);
            label1.Name = "label1";
            label1.Size = new Size(123, 29);
            label1.TabIndex = 1;
            label1.Text = "Add Item";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(discountt);
            panel1.Controls.Add(pricet);
            panel1.Controls.Add(namet);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(266, 50);
            panel1.Name = "panel1";
            panel1.Size = new Size(350, 283);
            panel1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(132, 230);
            button1.Name = "button1";
            button1.Size = new Size(143, 34);
            button1.TabIndex = 3;
            button1.Text = "ADD";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // discountt
            // 
            discountt.Location = new Point(132, 185);
            discountt.Name = "discountt";
            discountt.Size = new Size(143, 23);
            discountt.TabIndex = 2;
            discountt.TextChanged += discountt_TextChanged;
            discountt.KeyPress += discountt_KeyPress;
            // 
            // pricet
            // 
            pricet.Location = new Point(132, 121);
            pricet.Name = "pricet";
            pricet.Size = new Size(143, 23);
            pricet.TabIndex = 1;
            pricet.KeyPress += pricet_KeyPress;
            // 
            // namet
            // 
            namet.BorderStyle = BorderStyle.FixedSingle;
            namet.Location = new Point(132, 48);
            namet.Name = "namet";
            namet.Size = new Size(143, 23);
            namet.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(16, 185);
            label4.Name = "label4";
            label4.Size = new Size(92, 21);
            label4.TabIndex = 5;
            label4.Text = "DISCOUNT";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(16, 121);
            label3.Name = "label3";
            label3.Size = new Size(54, 21);
            label3.TabIndex = 4;
            label3.Text = "PRICE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(16, 48);
            label2.Name = "label2";
            label2.Size = new Size(58, 21);
            label2.TabIndex = 3;
            label2.Text = "NAME";
            // 
            // Additem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(638, 356);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            MaximizeBox = false;
            Name = "Additem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Additem";
            ((ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel1;
        private Button button1;
        private TextBox discountt;
        private TextBox pricet;
        private TextBox namet;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}