namespace winformfs2
{
    partial class Products

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
            btnAdd = new Button();
            listBox1 = new ListBox();
            rtxtname = new RichTextBox();
            btnEdit = new Button();
            btnDel = new Button();
            lblUser = new Label();
            txtStock = new TextBox();
            lblstok = new Label();
            btnclear = new Button();
            label2 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Thistle;
            btnAdd.Location = new Point(533, 217);
            btnAdd.Margin = new Padding(4, 5, 4, 5);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(174, 64);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "EKLE";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.LavenderBlush;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 22;
            listBox1.Location = new Point(25, 100);
            listBox1.Margin = new Padding(4, 5, 4, 5);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(389, 444);
            listBox1.TabIndex = 1;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // rtxtname
            // 
            rtxtname.BackColor = Color.LavenderBlush;
            rtxtname.Location = new Point(514, 78);
            rtxtname.Margin = new Padding(4, 5, 4, 5);
            rtxtname.Name = "rtxtname";
            rtxtname.Size = new Size(220, 50);
            rtxtname.TabIndex = 2;
            rtxtname.Text = "";
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.Plum;
            btnEdit.Location = new Point(591, 304);
            btnEdit.Margin = new Padding(4, 5, 4, 5);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(172, 64);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "DÜZENLE";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDel
            // 
            btnDel.BackColor = Color.PaleVioletRed;
            btnDel.Location = new Point(535, 378);
            btnDel.Margin = new Padding(4, 5, 4, 5);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(172, 66);
            btnDel.TabIndex = 4;
            btnDel.Text = "SİL";
            btnDel.UseVisualStyleBackColor = false;
            btnDel.Click += btnDel_Click;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new Point(433, 452);
            lblUser.Margin = new Padding(4, 0, 4, 0);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(0, 22);
            lblUser.TabIndex = 6;
            // 
            // txtStock
            // 
            txtStock.BackColor = Color.LavenderBlush;
            txtStock.Location = new Point(514, 138);
            txtStock.Margin = new Padding(4, 5, 4, 5);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(78, 30);
            txtStock.TabIndex = 7;
            // 
            // lblstok
            // 
            lblstok.AutoSize = true;
            lblstok.Location = new Point(762, 49);
            lblstok.Margin = new Padding(4, 0, 4, 0);
            lblstok.Name = "lblstok";
            lblstok.Size = new Size(50, 22);
            lblstok.TabIndex = 8;
            lblstok.Text = "STOK";
            // 
            // btnclear
            // 
            btnclear.BackColor = Color.Thistle;
            btnclear.Location = new Point(570, 471);
            btnclear.Margin = new Padding(4, 5, 4, 5);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(172, 67);
            btnclear.TabIndex = 4;
            btnclear.Text = "TEMİZLE";
            btnclear.UseVisualStyleBackColor = false;
            btnclear.Click += btnclear_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(616, 49);
            label2.Name = "label2";
            label2.Size = new Size(126, 19);
            label2.TabIndex = 9;
            label2.Text = "GÜNCEL STOCK:";
            // 
            // button1
            // 
            button1.BackColor = Color.DeepPink;
            button1.Location = new Point(12, 7);
            button1.Name = "button1";
            button1.Size = new Size(77, 34);
            button1.TabIndex = 10;
            button1.Text = "GERİ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Products
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            ClientSize = new Size(846, 589);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(lblstok);
            Controls.Add(txtStock);
            Controls.Add(lblUser);
            Controls.Add(btnclear);
            Controls.Add(btnDel);
            Controls.Add(btnEdit);
            Controls.Add(rtxtname);
            Controls.Add(listBox1);
            Controls.Add(btnAdd);
            Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Products";
            Text = "StocksFormm";
            Load += Product_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private ListBox listBox1;
        private RichTextBox richTextBox1;
        private Button btnEdit;
        private Button btnDel;
        private Label lblUser;
        private TextBox txtStock;
        private Label lbltest;
        private Label lblstok;
        private RichTextBox rtxtname;
        private Button btnclear;
        private Label label2;
        private Button button1;
    }
}