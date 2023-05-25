namespace pikpo
{
    partial class sign_up
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_reg = new System.Windows.Forms.Label();
            this.label_login2 = new System.Windows.Forms.Label();
            this.label_password2 = new System.Windows.Forms.Label();
            this.textBox_login2 = new System.Windows.Forms.TextBox();
            this.textBox_password2 = new System.Windows.Forms.TextBox();
            this.button_reg2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::pikpo.Properties.Resources._1663660785_35_mykaleidoscope_ru___1_;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 73);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label_reg
            // 
            this.label_reg.AutoSize = true;
            this.label_reg.Font = new System.Drawing.Font("Showcard Gothic", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_reg.ForeColor = System.Drawing.Color.Orange;
            this.label_reg.Location = new System.Drawing.Point(71, 70);
            this.label_reg.Name = "label_reg";
            this.label_reg.Size = new System.Drawing.Size(370, 59);
            this.label_reg.TabIndex = 8;
            this.label_reg.Text = "Registration";
            // 
            // label_login2
            // 
            this.label_login2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label_login2.Font = new System.Drawing.Font("Showcard Gothic", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_login2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_login2.Location = new System.Drawing.Point(12, 160);
            this.label_login2.Margin = new System.Windows.Forms.Padding(30, 10, 30, 10);
            this.label_login2.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.label_login2.Name = "label_login2";
            this.label_login2.Size = new System.Drawing.Size(184, 64);
            this.label_login2.TabIndex = 9;
            this.label_login2.Text = "Login";
            // 
            // label_password2
            // 
            this.label_password2.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_password2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_password2.Location = new System.Drawing.Point(12, 234);
            this.label_password2.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.label_password2.Name = "label_password2";
            this.label_password2.Size = new System.Drawing.Size(259, 71);
            this.label_password2.TabIndex = 10;
            this.label_password2.Text = "Password";
            // 
            // textBox_login2
            // 
            this.textBox_login2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_login2.Location = new System.Drawing.Point(294, 178);
            this.textBox_login2.Name = "textBox_login2";
            this.textBox_login2.Size = new System.Drawing.Size(169, 34);
            this.textBox_login2.TabIndex = 11;
            // 
            // textBox_password2
            // 
            this.textBox_password2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_password2.Location = new System.Drawing.Point(294, 250);
            this.textBox_password2.Name = "textBox_password2";
            this.textBox_password2.Size = new System.Drawing.Size(169, 34);
            this.textBox_password2.TabIndex = 12;
            this.textBox_password2.TextChanged += new System.EventHandler(this.textBox_password_TextChanged);
            // 
            // button_reg2
            // 
            this.button_reg2.Font = new System.Drawing.Font("Showcard Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_reg2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button_reg2.Location = new System.Drawing.Point(132, 323);
            this.button_reg2.Name = "button_reg2";
            this.button_reg2.Size = new System.Drawing.Size(203, 35);
            this.button_reg2.TabIndex = 13;
            this.button_reg2.Text = "Create account";
            this.button_reg2.UseVisualStyleBackColor = true;
            this.button_reg2.Click += new System.EventHandler(this.button_reg2_Click);
            // 
            // sign_up
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 413);
            this.Controls.Add(this.button_reg2);
            this.Controls.Add(this.textBox_password2);
            this.Controls.Add(this.textBox_login2);
            this.Controls.Add(this.label_password2);
            this.Controls.Add(this.label_login2);
            this.Controls.Add(this.label_reg);
            this.Controls.Add(this.pictureBox1);
            this.Name = "sign_up";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.sign_up_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_reg;
        private System.Windows.Forms.Label label_login2;
        public System.Windows.Forms.Label label_password2;
        private System.Windows.Forms.TextBox textBox_login2;
        private System.Windows.Forms.TextBox textBox_password2;
        private System.Windows.Forms.Button button_reg2;
    }
}