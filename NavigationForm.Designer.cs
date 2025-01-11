namespace winformfs2
{
    partial class NavigationForm
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
            btnpro = new Button();
            btnnote = new Button();
            SuspendLayout();
            // 
            // btnpro
            // 
            btnpro.BackColor = SystemColors.ControlLight;
            btnpro.Location = new Point(17, 111);
            btnpro.Margin = new Padding(4);
            btnpro.Name = "btnpro";
            btnpro.Size = new Size(389, 144);
            btnpro.TabIndex = 0;
            btnpro.Text = "ÜRÜN LİSTESİ";
            btnpro.UseVisualStyleBackColor = false;
            btnpro.Click += btnpro_Click;
            // 
            // btnnote
            // 
            btnnote.BackColor = SystemColors.ControlLight;
            btnnote.Location = new Point(17, 293);
            btnnote.Margin = new Padding(4);
            btnnote.Name = "btnnote";
            btnnote.Size = new Size(389, 155);
            btnnote.TabIndex = 0;
            btnnote.Text = "ÖZLÜ SÖZLER";
            btnnote.UseVisualStyleBackColor = false;
            btnnote.Click += btnnote_Click;
            // 
            // NavigationForm
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(437, 510);
            Controls.Add(btnnote);
            Controls.Add(btnpro);
            Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "NavigationForm";
            Text = "NavigationForm";
            Load += NavigationForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnpro;
        private Button btnnote;
    }
}