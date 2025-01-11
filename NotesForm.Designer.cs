namespace winformfs2
{
    partial class NotesForm
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
            lblUser = new Label();
            label1 = new Label();
            btnclear = new Button();
            btnEdit = new Button();
            rtxtnotes = new RichTextBox();
            listnot = new ListBox();
            btnAdd = new Button();
            button1 = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new Point(450, 480);
            lblUser.Margin = new Padding(4, 0, 4, 0);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(0, 22);
            lblUser.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(150, 480);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(230, 22);
            label1.TabIndex = 15;
            label1.Text = "Giriş Yapan Kullanıcı:";
            // 
            // btnclear
            // 
            btnclear.BackColor = Color.FromArgb(192, 192, 255);
            btnclear.Font = new Font("Consolas", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnclear.Location = new Point(55, 378);
            btnclear.Margin = new Padding(4);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(107, 64);
            btnclear.TabIndex = 13;
            btnclear.Text = "TEMİZLE";
            btnclear.UseVisualStyleBackColor = false;
            btnclear.Click += btnclear_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(192, 192, 255);
            btnEdit.Font = new Font("Consolas", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnEdit.Location = new Point(55, 272);
            btnEdit.Margin = new Padding(4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(107, 69);
            btnEdit.TabIndex = 12;
            btnEdit.Text = "DÜZENLE";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // rtxtnotes
            // 
            rtxtnotes.BackColor = SystemColors.Info;
            rtxtnotes.Location = new Point(294, 204);
            rtxtnotes.Margin = new Padding(4);
            rtxtnotes.Name = "rtxtnotes";
            rtxtnotes.Size = new Size(522, 212);
            rtxtnotes.TabIndex = 11;
            rtxtnotes.Text = "";
            // 
            // listnot
            // 
            listnot.BackColor = SystemColors.Info;
            listnot.FormattingEnabled = true;
            listnot.ItemHeight = 22;
            listnot.Location = new Point(311, 62);
            listnot.Margin = new Padding(4);
            listnot.Name = "listnot";
            listnot.Size = new Size(492, 114);
            listnot.TabIndex = 10;
            listnot.Tag = "";
            listnot.SelectedIndexChanged += listnot_SelectedIndexChanged;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(192, 192, 255);
            btnAdd.Font = new Font("Consolas", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.Location = new Point(55, 162);
            btnAdd.Margin = new Padding(4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(107, 69);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "EKLE";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Yellow;
            button1.Location = new Point(23, 12);
            button1.Name = "button1";
            button1.Size = new Size(81, 32);
            button1.TabIndex = 19;
            button1.Text = "GERİ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.RosyBrown;
            label2.Location = new Point(493, 22);
            label2.Name = "label2";
            label2.Size = new Size(110, 22);
            label2.TabIndex = 20;
            label2.Text = "NOTLARINIZ";
            label2.Click += label2_Click;
            // 
            // NotesForm
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(954, 526);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(lblUser);
            Controls.Add(label1);
            Controls.Add(btnclear);
            Controls.Add(btnEdit);
            Controls.Add(rtxtnotes);
            Controls.Add(listnot);
            Controls.Add(btnAdd);
            Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "NotesForm";
            Text = "NotesForm";
            FormClosed += NotesForm_FormClosed;
            Load += NotesForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblUser;
        private Label label1;
        private Button btnclear;
        private Button btnEdit;
        private RichTextBox rtxtnotes;
        private ListBox llstnote;
        private Button btnAdd;
        private ListBox listnot;
        private Button button1;
        private Label label2;
    }
}