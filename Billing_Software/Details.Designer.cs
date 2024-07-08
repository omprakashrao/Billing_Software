namespace Billing_Software
{
    partial class Details
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
            DateTimePicker dateTimePicker1;
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            sbox = new TextBox();
            button1 = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            dateTimePicker2 = new DateTimePicker();
            label6 = new Label();
            Seachbydate = new Button();
            dateTimePicker3 = new DateTimePicker();
            reset = new Button();
            dateTimePicker1 = new DateTimePicker();
            ((ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "MM/dd/yyyy hh:hh tt";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(508, 113);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 7;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 244);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(739, 177);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(170, 24);
            label1.Name = "label1";
            label1.Size = new Size(416, 86);
            label1.TabIndex = 1;
            label1.Text = "ALL DETAILS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 95);
            label2.Name = "label2";
            label2.Size = new Size(99, 15);
            label2.TabIndex = 2;
            label2.Text = "Search By Invoice";
            // 
            // sbox
            // 
            sbox.Location = new Point(24, 113);
            sbox.Name = "sbox";
            sbox.Size = new Size(100, 23);
            sbox.TabIndex = 3;
            sbox.TextChanged += sbox_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(24, 142);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.TabStop = false;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 185);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 5;
            label3.Text = "Final cost";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(102, 185);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 6;
            label4.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(458, 116);
            label5.Name = "label5";
            label5.Size = new Size(35, 15);
            label5.TabIndex = 8;
            label5.Text = "From";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CustomFormat = "MM/dd/yyyy hh:hh tt";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(508, 151);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(200, 23);
            dateTimePicker2.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(458, 157);
            label6.Name = "label6";
            label6.Size = new Size(19, 15);
            label6.TabIndex = 10;
            label6.Text = "To";
            // 
            // Seachbydate
            // 
            Seachbydate.Location = new Point(508, 185);
            Seachbydate.Name = "Seachbydate";
            Seachbydate.Size = new Size(75, 25);
            Seachbydate.TabIndex = 4;
            Seachbydate.TabStop = false;
            Seachbydate.Text = "Search  By Date";
            Seachbydate.UseVisualStyleBackColor = true;
            Seachbydate.Click += Seachbydate_Click;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Location = new Point(996, 200);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(200, 23);
            dateTimePicker3.TabIndex = 9;
            // 
            // reset
            // 
            reset.Location = new Point(612, 185);
            reset.Name = "reset";
            reset.Size = new Size(75, 25);
            reset.TabIndex = 4;
            reset.TabStop = false;
            reset.Text = "reset";
            reset.UseVisualStyleBackColor = true;
            reset.Click += reset_Click;
            // 
            // Details
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(761, 470);
            Controls.Add(label6);
            Controls.Add(dateTimePicker3);
            Controls.Add(dateTimePicker2);
            Controls.Add(label5);
            Controls.Add(dateTimePicker1);
            Controls.Add(label4);
            Controls.Add(reset);
            Controls.Add(Seachbydate);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(sbox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Details";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Details";
            Load += Details_Load;
            ((ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        public DataGridView dataGridView1;
        private Label label2;
        private TextBox sbox;
        private Label label3;
        private Label label4;
        public Button button1;
        private DateTimePicker dateTimePicker1;
        private Label label5;
        private DateTimePicker dateTimePicker2;
        private Label label6;
        public Button Seachbydate;
        private DateTimePicker dateTimePicker3;
        public Button reset;
    }
}