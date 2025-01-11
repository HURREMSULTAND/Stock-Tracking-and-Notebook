namespace winformfs2
{
    partial class UserLoginForm
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
            btngiriş = new Button();
            btnkapat = new Button();
            label1 = new Label();
            label2 = new Label();
            txtAd = new TextBox();
            txtPas = new TextBox();
            button1 = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // btngiriş
            // 
            btngiriş.BackColor = Color.DarkSeaGreen;
            btngiriş.Location = new Point(13, 195);
            btngiriş.Margin = new Padding(4);
            btngiriş.Name = "btngiriş";
            btngiriş.Size = new Size(493, 52);
            btngiriş.TabIndex = 3;
            btngiriş.Text = "GİRİŞ YAP";
            btngiriş.UseVisualStyleBackColor = false;
            btngiriş.Click += btngiriş_Click_1;
            // 
            // btnkapat
            // 
            btnkapat.BackColor = Color.RosyBrown;
            btnkapat.Location = new Point(13, 274);
            btnkapat.Margin = new Padding(4);
            btnkapat.Name = "btnkapat";
            btnkapat.Size = new Size(493, 52);
            btnkapat.TabIndex = 4;
            btnkapat.Text = "KAPAT";
            btnkapat.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(13, 75);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(178, 24);
            label1.TabIndex = 1;
            label1.Text = "KULLANICI ADI:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(73, 141);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(118, 24);
            label2.TabIndex = 1;
            label2.Text = "PASSWORD:";
            // 
            // txtAd
            // 
            txtAd.BackColor = Color.Honeydew;
            txtAd.Location = new Point(223, 75);
            txtAd.Margin = new Padding(4);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(141, 30);
            txtAd.TabIndex = 1;
            // 
            // txtPas
            // 
            txtPas.BackColor = Color.Honeydew;
            txtPas.Location = new Point(224, 135);
            txtPas.Margin = new Padding(4);
            txtPas.Name = "txtPas";
            txtPas.Size = new Size(141, 30);
            txtPas.TabIndex = 2;
            txtPas.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 192, 192);
            button1.Location = new Point(424, 398);
            button1.Name = "button1";
            button1.Size = new Size(83, 33);
            button1.TabIndex = 7;
            button1.Text = "TIKLA";
            button1.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(250, 408);
            label4.Name = "label4";
            label4.Size = new Size(168, 15);
            label4.TabIndex = 8;
            label4.Text = "ŞİFRENİZİ Mİ UNUTTUNUZ?";
            // 
            // UserLoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(519, 449);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(txtPas);
            Controls.Add(txtAd);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnkapat);
            Controls.Add(btngiriş);
            Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "UserLoginForm";
            Text = "UserLogin";
            Load += UserLoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btngiriş;
        private Button btnkapat;
        private Label label1;
        private Label label2;
        private TextBox txtAd;
        private TextBox txtPas;
        private Button button1;
        private Label label4;
    }
}