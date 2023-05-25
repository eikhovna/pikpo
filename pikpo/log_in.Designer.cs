namespace pikpo
{
    partial class log_in
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(log_in));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_auto = new System.Windows.Forms.Label();
            this.label_login1 = new System.Windows.Forms.Label();
            this.label_password2 = new System.Windows.Forms.Label();
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.button_reg = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::pikpo.Properties.Resources._1663660785_35_mykaleidoscope_ru___1_;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 69);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // label_auto
            // 
            this.label_auto.AutoSize = true;
            this.label_auto.Font = new System.Drawing.Font("Showcard Gothic", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_auto.ForeColor = System.Drawing.Color.Orange;
            this.label_auto.Location = new System.Drawing.Point(38, 70);
            this.label_auto.Name = "label_auto";
            this.label_auto.Size = new System.Drawing.Size(419, 59);
            this.label_auto.TabIndex = 15;
            this.label_auto.Text = "Authorization";
            // 
            // label_login1
            // 
            this.label_login1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label_login1.Font = new System.Drawing.Font("Showcard Gothic", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_login1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_login1.Location = new System.Drawing.Point(39, 139);
            this.label_login1.Margin = new System.Windows.Forms.Padding(30, 10, 30, 10);
            this.label_login1.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.label_login1.Name = "label_login1";
            this.label_login1.Size = new System.Drawing.Size(184, 64);
            this.label_login1.TabIndex = 16;
            this.label_login1.Text = "Login";
            // 
            // label_password2
            // 
            this.label_password2.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_password2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_password2.Location = new System.Drawing.Point(3, 213);
            this.label_password2.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.label_password2.Name = "label_password2";
            this.label_password2.Size = new System.Drawing.Size(275, 71);
            this.label_password2.TabIndex = 17;
            this.label_password2.Text = "Password";
            // 
            // textBox_login
            // 
            this.textBox_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_login.Location = new System.Drawing.Point(288, 157);
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.Size = new System.Drawing.Size(169, 34);
            this.textBox_login.TabIndex = 18;
            // 
            // textBox_password
            // 
            this.textBox_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_password.Location = new System.Drawing.Point(288, 229);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(169, 34);
            this.textBox_password.TabIndex = 19;
            // 
            // button_reg
            // 
            this.button_reg.Font = new System.Drawing.Font("Showcard Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_reg.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button_reg.Location = new System.Drawing.Point(132, 287);
            this.button_reg.Name = "button_reg";
            this.button_reg.Size = new System.Drawing.Size(203, 35);
            this.button_reg.TabIndex = 20;
            this.button_reg.Text = "log in";
            this.button_reg.UseVisualStyleBackColor = true;
            this.button_reg.Click += new System.EventHandler(this.button_reg_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.SteelBlue;
            this.linkLabel1.Location = new System.Drawing.Point(175, 342);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(103, 16);
            this.linkLabel1.TabIndex = 21;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "No account yet?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // log_in
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(492, 413);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.button_reg);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_login);
            this.Controls.Add(this.label_password2);
            this.Controls.Add(this.label_login1);
            this.Controls.Add(this.label_auto);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "log_in";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.log_in_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_auto;
        private System.Windows.Forms.Label label_login1;
        public System.Windows.Forms.Label label_password2;
        private System.Windows.Forms.TextBox textBox_login;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Button button_reg;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

