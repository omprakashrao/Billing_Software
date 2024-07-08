namespace Billing_Software
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            invoice = new TextBox();
            label3 = new Label();
            user = new TextBox();
            label4 = new Label();
            selectitem = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            price = new TextBox();
            discount = new TextBox();
            label7 = new Label();
            subtotal = new TextBox();
            label8 = new Label();
            label9 = new Label();
            totalcost = new TextBox();
            finalcost = new TextBox();
            label10 = new Label();
            tax = new TextBox();
            amountpaid = new TextBox();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            change = new TextBox();
            add = new Button();
            reset = new Button();
            dataGridView1 = new DataGridView();
            qunt = new TextBox();
            insert = new Button();
            printpreview = new Button();
            print = new Button();
            printPreviewDialog1 = new PrintPreviewDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            addItemToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            editItemToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            viewDataToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            detailsSearchToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            ((ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Myanmar Text", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(230, 60);
            label1.Name = "label1";
            label1.Size = new Size(226, 48);
            label1.TabIndex = 0;
            label1.Text = "A-One Furniture";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Mongolian Baiti", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(15, 145);
            label2.Name = "label2";
            label2.Size = new Size(88, 16);
            label2.TabIndex = 1;
            label2.Text = "Invoce No.";
            // 
            // invoice
            // 
            invoice.Location = new Point(12, 178);
            invoice.Name = "invoice";
            invoice.ReadOnly = true;
            invoice.Size = new Size(134, 21);
            invoice.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Mongolian Baiti", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 226);
            label3.Name = "label3";
            label3.Size = new Size(41, 16);
            label3.TabIndex = 3;
            label3.Text = "User";
            // 
            // user
            // 
            user.Font = new Font("Microsoft PhagsPa", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            user.Location = new Point(12, 245);
            user.Name = "user";
            user.ReadOnly = true;
            user.Size = new Size(134, 27);
            user.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Mongolian Baiti", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(12, 290);
            label4.Name = "label4";
            label4.Size = new Size(88, 16);
            label4.TabIndex = 5;
            label4.Text = "Select Item";
            // 
            // selectitem
            // 
            selectitem.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            selectitem.AutoCompleteSource = AutoCompleteSource.ListItems;
            selectitem.Font = new Font("Mongolian Baiti", 12F, FontStyle.Bold, GraphicsUnit.Point);
            selectitem.FormattingEnabled = true;
            selectitem.Location = new Point(12, 309);
            selectitem.Name = "selectitem";
            selectitem.Size = new Size(134, 24);
            selectitem.TabIndex = 0;
            selectitem.SelectedIndexChanged += selectitem_SelectedIndexChanged_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Mongolian Baiti", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(12, 348);
            label5.Name = "label5";
            label5.Size = new Size(81, 16);
            label5.TabIndex = 7;
            label5.Text = "Unit Price";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Mongolian Baiti", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(12, 404);
            label6.Name = "label6";
            label6.Size = new Size(138, 16);
            label6.TabIndex = 8;
            label6.Text = "Discount Per Item";
            // 
            // price
            // 
            price.Font = new Font("Mongolian Baiti", 12F, FontStyle.Bold, GraphicsUnit.Point);
            price.Location = new Point(12, 367);
            price.Name = "price";
            price.ReadOnly = true;
            price.Size = new Size(134, 26);
            price.TabIndex = 1;
            price.TextChanged += price_TextChanged;
            // 
            // discount
            // 
            discount.Font = new Font("Mongolian Baiti", 12F, FontStyle.Bold, GraphicsUnit.Point);
            discount.Location = new Point(12, 423);
            discount.Name = "discount";
            discount.ReadOnly = true;
            discount.Size = new Size(134, 26);
            discount.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Mongolian Baiti", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(226, 145);
            label7.Name = "label7";
            label7.Size = new Size(70, 16);
            label7.TabIndex = 1;
            label7.Text = "Quantity";
            // 
            // subtotal
            // 
            subtotal.Font = new Font("Mongolian Baiti", 12F, FontStyle.Bold, GraphicsUnit.Point);
            subtotal.Location = new Point(223, 245);
            subtotal.Name = "subtotal";
            subtotal.ReadOnly = true;
            subtotal.Size = new Size(134, 26);
            subtotal.TabIndex = 4;
            subtotal.TextChanged += subtotal_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Mongolian Baiti", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(223, 290);
            label8.Name = "label8";
            label8.Size = new Size(78, 16);
            label8.TabIndex = 5;
            label8.Text = "GST 18%";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Mongolian Baiti", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(223, 404);
            label9.Name = "label9";
            label9.Size = new Size(82, 16);
            label9.TabIndex = 8;
            label9.Text = "Final Cost";
            // 
            // totalcost
            // 
            totalcost.Font = new Font("Mongolian Baiti", 12F, FontStyle.Bold, GraphicsUnit.Point);
            totalcost.Location = new Point(223, 367);
            totalcost.Name = "totalcost";
            totalcost.ReadOnly = true;
            totalcost.Size = new Size(134, 26);
            totalcost.TabIndex = 6;
            // 
            // finalcost
            // 
            finalcost.Font = new Font("Mongolian Baiti", 12F, FontStyle.Bold, GraphicsUnit.Point);
            finalcost.Location = new Point(223, 423);
            finalcost.Name = "finalcost";
            finalcost.ReadOnly = true;
            finalcost.Size = new Size(134, 26);
            finalcost.TabIndex = 7;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Mongolian Baiti", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(223, 226);
            label10.Name = "label10";
            label10.Size = new Size(78, 16);
            label10.TabIndex = 3;
            label10.Text = "Sub Total";
            // 
            // tax
            // 
            tax.Font = new Font("Mongolian Baiti", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tax.Location = new Point(223, 309);
            tax.Name = "tax";
            tax.ReadOnly = true;
            tax.Size = new Size(134, 26);
            tax.TabIndex = 5;
            tax.TextChanged += tax_TextChanged;
            // 
            // amountpaid
            // 
            amountpaid.Font = new Font("Mongolian Baiti", 12F, FontStyle.Bold, GraphicsUnit.Point);
            amountpaid.Location = new Point(439, 178);
            amountpaid.Name = "amountpaid";
            amountpaid.Size = new Size(134, 26);
            amountpaid.TabIndex = 8;
            amountpaid.TextChanged += amountpaid_TextChanged;
            amountpaid.KeyPress += amountpaid_KeyPress;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Mongolian Baiti", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(223, 348);
            label11.Name = "label11";
            label11.Size = new Size(83, 16);
            label11.TabIndex = 5;
            label11.Text = "Total Cost";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Mongolian Baiti", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(442, 145);
            label12.Name = "label12";
            label12.Size = new Size(102, 16);
            label12.TabIndex = 1;
            label12.Text = "Amount Paid";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Mongolian Baiti", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(439, 226);
            label13.Name = "label13";
            label13.Size = new Size(62, 16);
            label13.TabIndex = 1;
            label13.Text = "Change";
            // 
            // change
            // 
            change.Font = new Font("Mongolian Baiti", 12F, FontStyle.Bold, GraphicsUnit.Point);
            change.Location = new Point(439, 245);
            change.Name = "change";
            change.ReadOnly = true;
            change.Size = new Size(134, 26);
            change.TabIndex = 9;
            // 
            // add
            // 
            add.Font = new Font("Mongolian Baiti", 12F, FontStyle.Bold, GraphicsUnit.Point);
            add.Location = new Point(12, 466);
            add.Name = "add";
            add.Size = new Size(75, 23);
            add.TabIndex = 11;
            add.Text = "ADD";
            add.UseVisualStyleBackColor = true;
            add.Click += add_Click;
            // 
            // reset
            // 
            reset.Font = new Font("Mongolian Baiti", 12F, FontStyle.Bold, GraphicsUnit.Point);
            reset.Location = new Point(119, 466);
            reset.Name = "reset";
            reset.Size = new Size(75, 23);
            reset.TabIndex = 12;
            reset.Text = "Reset";
            reset.UseVisualStyleBackColor = true;
            reset.Click += reset_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(4, 505);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(802, 190);
            dataGridView1.TabIndex = 13;
            // 
            // qunt
            // 
            qunt.Font = new Font("Mongolian Baiti", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            qunt.Location = new Point(223, 178);
            qunt.Name = "qunt";
            qunt.PlaceholderText = "0";
            qunt.Size = new Size(134, 25);
            qunt.TabIndex = 2;
            qunt.TextChanged += qunt_TextChanged;
            qunt.KeyPress += qunt_KeyPress;
            // 
            // insert
            // 
            insert.Anchor = AnchorStyles.Left;
            insert.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            insert.Location = new Point(230, 465);
            insert.Name = "insert";
            insert.Size = new Size(75, 24);
            insert.TabIndex = 14;
            insert.Text = "Insert";
            insert.UseVisualStyleBackColor = true;
            insert.Click += button1_Click;
            // 
            // printpreview
            // 
            printpreview.Font = new Font("Mongolian Baiti", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            printpreview.Location = new Point(439, 299);
            printpreview.Name = "printpreview";
            printpreview.Size = new Size(134, 34);
            printpreview.TabIndex = 15;
            printpreview.Text = "Print Preview";
            printpreview.UseVisualStyleBackColor = true;
            printpreview.Click += button1_Click_1;
            // 
            // print
            // 
            print.Font = new Font("Mongolian Baiti", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            print.Location = new Point(439, 367);
            print.Name = "print";
            print.Size = new Size(134, 53);
            print.TabIndex = 16;
            print.Text = "Print";
            print.UseVisualStyleBackColor = true;
            print.Click += print_Click;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, viewToolStripMenuItem, toolStripMenuItem1, aboutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(818, 24);
            menuStrip1.TabIndex = 17;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addItemToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // addItemToolStripMenuItem
            // 
            addItemToolStripMenuItem.Name = "addItemToolStripMenuItem";
            addItemToolStripMenuItem.Size = new Size(180, 22);
            addItemToolStripMenuItem.Text = "Add Item";
            addItemToolStripMenuItem.Click += addItemToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(180, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { editItemToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(39, 20);
            editToolStripMenuItem.Text = "Edit";
            // 
            // editItemToolStripMenuItem
            // 
            editItemToolStripMenuItem.Name = "editItemToolStripMenuItem";
            editItemToolStripMenuItem.Size = new Size(121, 22);
            editItemToolStripMenuItem.Text = "Edit Item";
            editItemToolStripMenuItem.Click += editItemToolStripMenuItem_Click;
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { viewDataToolStripMenuItem });
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(44, 20);
            viewToolStripMenuItem.Text = "View";
            // 
            // viewDataToolStripMenuItem
            // 
            viewDataToolStripMenuItem.Name = "viewDataToolStripMenuItem";
            viewDataToolStripMenuItem.Size = new Size(180, 22);
            viewDataToolStripMenuItem.Text = "View Data";
            viewDataToolStripMenuItem.Click += viewDataToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { detailsSearchToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(54, 20);
            toolStripMenuItem1.Text = "Details";
            // 
            // detailsSearchToolStripMenuItem
            // 
            detailsSearchToolStripMenuItem.Name = "detailsSearchToolStripMenuItem";
            detailsSearchToolStripMenuItem.Size = new Size(150, 22);
            detailsSearchToolStripMenuItem.Text = "Details & Search";
            detailsSearchToolStripMenuItem.Click += detailsSearchToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { helpToolStripMenuItem });
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(52, 20);
            aboutToolStripMenuItem.Text = "About";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(99, 22);
            helpToolStripMenuItem.Text = "Help";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(818, 716);
            Controls.Add(print);
            Controls.Add(printpreview);
            Controls.Add(insert);
            Controls.Add(dataGridView1);
            Controls.Add(reset);
            Controls.Add(add);
            Controls.Add(change);
            Controls.Add(amountpaid);
            Controls.Add(finalcost);
            Controls.Add(discount);
            Controls.Add(totalcost);
            Controls.Add(price);
            Controls.Add(label9);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(selectitem);
            Controls.Add(label11);
            Controls.Add(label8);
            Controls.Add(tax);
            Controls.Add(label4);
            Controls.Add(subtotal);
            Controls.Add(user);
            Controls.Add(label10);
            Controls.Add(label3);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(qunt);
            Controls.Add(label7);
            Controls.Add(invoice);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Font = new Font("Mongolian Baiti", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.Desktop;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Total Cost";
            Activated += Form1_Activated;
            Load += Form1_Load;
            ((ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox invoice;
        private Label label3;
        private TextBox user;
        private Label label4;
        private ComboBox selectitem;
        private Label label5;
        private Label label6;
        private TextBox price;
        private TextBox discount;
        private Label label7;
        private TextBox subtotal;
        private Label label8;
        private Label label9;
        private TextBox totalcost;
        private TextBox finalcost;
        private Label label10;
        private TextBox tax;
        private TextBox amountpaid;
        private Label label11;
        private Label label12;
        private Label label13;
        private TextBox change;
        private Button add;
        private Button reset;
        private DataGridView dataGridView1;
        private TextBox qunt;
        private Button insert;
        private Button printpreview;
        private Button print;
        private PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem addItemToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem editItemToolStripMenuItem;
        private ToolStripMenuItem viewDataToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem detailsSearchToolStripMenuItem;
    }
}
