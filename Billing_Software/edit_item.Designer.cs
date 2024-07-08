namespace Billing_Software
{
    partial class edit_item
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
            ComponentResourceManager resources = new ComponentResourceManager(typeof(edit_item));
            selectitem = new Panel();
            delete = new Button();
            id = new TextBox();
            label6 = new Label();
            label5 = new Label();
            itemname = new ComboBox();
            button1 = new Button();
            discountt = new TextBox();
            pricet = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            selectitem.SuspendLayout();
            ((ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // selectitem
            // 
            selectitem.BackColor = SystemColors.ActiveBorder;
            selectitem.Controls.Add(delete);
            selectitem.Controls.Add(id);
            selectitem.Controls.Add(label6);
            selectitem.Controls.Add(label5);
            selectitem.Controls.Add(itemname);
            selectitem.Controls.Add(button1);
            selectitem.Controls.Add(discountt);
            selectitem.Controls.Add(pricet);
            selectitem.Controls.Add(label4);
            selectitem.Controls.Add(label3);
            selectitem.Controls.Add(label2);
            selectitem.Location = new Point(275, 63);
            selectitem.Name = "selectitem";
            selectitem.Size = new Size(350, 299);
            selectitem.TabIndex = 5;
            // 
            // delete
            // 
            delete.BackColor = Color.Red;
            delete.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            delete.Location = new Point(224, 233);
            delete.Name = "delete";
            delete.Size = new Size(86, 34);
            delete.TabIndex = 10;
            delete.Text = "Delete";
            delete.UseVisualStyleBackColor = false;
            delete.Click += delete_Click;
            // 
            // id
            // 
            id.Enabled = false;
            id.Location = new Point(132, 22);
            id.Name = "id";
            id.Size = new Size(178, 23);
            id.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(16, 24);
            label6.Name = "label6";
            label6.Size = new Size(27, 21);
            label6.TabIndex = 8;
            label6.Text = "ID";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(132, 57);
            label5.Name = "label5";
            label5.Size = new Size(64, 15);
            label5.TabIndex = 7;
            label5.Text = "select item";
            // 
            // itemname
            // 
            itemname.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            itemname.AutoCompleteSource = AutoCompleteSource.ListItems;
            itemname.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            itemname.FormattingEnabled = true;
            itemname.Location = new Point(132, 75);
            itemname.Name = "itemname";
            itemname.Size = new Size(178, 29);
            itemname.TabIndex = 0;
            itemname.SelectedIndexChanged += itemname_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Yellow;
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(132, 233);
            button1.Name = "button1";
            button1.Size = new Size(86, 34);
            button1.TabIndex = 3;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // discountt
            // 
            discountt.Location = new Point(132, 185);
            discountt.Name = "discountt";
            discountt.Size = new Size(178, 23);
            discountt.TabIndex = 2;
            discountt.KeyPress += discountt_KeyPress;
            // 
            // pricet
            // 
            pricet.Location = new Point(132, 132);
            pricet.Name = "pricet";
            pricet.Size = new Size(178, 23);
            pricet.TabIndex = 1;
            pricet.KeyPress += pricet_KeyPress;
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
            label3.Location = new Point(16, 132);
            label3.Name = "label3";
            label3.Size = new Size(54, 21);
            label3.TabIndex = 4;
            label3.Text = "PRICE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(16, 75);
            label2.Name = "label2";
            label2.Size = new Size(58, 21);
            label2.TabIndex = 3;
            label2.Text = "NAME";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(275, 31);
            label1.Name = "label1";
            label1.Size = new Size(130, 29);
            label1.TabIndex = 4;
            label1.Text = "Edit Item";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 63);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(236, 283);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // edit_item
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(647, 374);
            Controls.Add(selectitem);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            MaximizeBox = false;
            Name = "edit_item";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "edit_item";
            selectitem.ResumeLayout(false);
            selectitem.PerformLayout();
            ((ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel selectitem;
        private Button button1;
        private TextBox discountt;
        private TextBox pricet;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private ComboBox itemname;
        private Label label5;
        private TextBox id;
        private Label label6;
        private Button delete;
    }
}