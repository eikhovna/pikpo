namespace pikpo
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.информацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label_entry = new System.Windows.Forms.Label();
            this.labelid = new System.Windows.Forms.Label();
            this.labeltype = new System.Windows.Forms.Label();
            this.labelcount = new System.Windows.Forms.Label();
            this.labelprovider = new System.Windows.Forms.Label();
            this.labelprice = new System.Windows.Forms.Label();
            this.textBoxid = new System.Windows.Forms.TextBox();
            this.textBoxtype = new System.Windows.Forms.TextBox();
            this.textBoxcount = new System.Windows.Forms.TextBox();
            this.textBoxprovider = new System.Windows.Forms.TextBox();
            this.textBoxprice = new System.Windows.Forms.TextBox();
            this.buttonnew = new System.Windows.Forms.Button();
            this.buttondel = new System.Windows.Forms.Button();
            this.buttonedit = new System.Windows.Forms.Button();
            this.buttonsave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxRefresh = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.управлениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.информацияToolStripMenuItem,
            this.управлениеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1145, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // информацияToolStripMenuItem
            // 
            this.информацияToolStripMenuItem.Name = "информацияToolStripMenuItem";
            this.информацияToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.информацияToolStripMenuItem.Text = "Информация";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Location = new System.Drawing.Point(12, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1099, 64);
            this.panel1.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(864, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(210, 38);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBoxRefresh);
            this.panel3.Controls.Add(this.textBoxprice);
            this.panel3.Controls.Add(this.textBoxprovider);
            this.panel3.Controls.Add(this.textBoxcount);
            this.panel3.Controls.Add(this.textBoxtype);
            this.panel3.Controls.Add(this.textBoxid);
            this.panel3.Controls.Add(this.labelprice);
            this.panel3.Controls.Add(this.labelprovider);
            this.panel3.Controls.Add(this.labelcount);
            this.panel3.Controls.Add(this.labeltype);
            this.panel3.Controls.Add(this.labelid);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.label_entry);
            this.panel3.Location = new System.Drawing.Point(689, 112);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(444, 223);
            this.panel3.TabIndex = 3;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.buttonsave);
            this.panel4.Controls.Add(this.buttonedit);
            this.panel4.Controls.Add(this.buttondel);
            this.panel4.Controls.Add(this.buttonnew);
            this.panel4.Location = new System.Drawing.Point(689, 341);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(426, 171);
            this.panel4.TabIndex = 4;
            // 
            // label_entry
            // 
            this.label_entry.AutoSize = true;
            this.label_entry.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_entry.Location = new System.Drawing.Point(182, 26);
            this.label_entry.Name = "label_entry";
            this.label_entry.Size = new System.Drawing.Size(80, 27);
            this.label_entry.TabIndex = 0;
            this.label_entry.Text = "Запись";
            // 
            // labelid
            // 
            this.labelid.AutoSize = true;
            this.labelid.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelid.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelid.Location = new System.Drawing.Point(87, 73);
            this.labelid.Name = "labelid";
            this.labelid.Size = new System.Drawing.Size(23, 22);
            this.labelid.TabIndex = 2;
            this.labelid.Text = "id";
            // 
            // labeltype
            // 
            this.labeltype.AutoSize = true;
            this.labeltype.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labeltype.Location = new System.Drawing.Point(53, 107);
            this.labeltype.Name = "labeltype";
            this.labeltype.Size = new System.Drawing.Size(57, 19);
            this.labeltype.TabIndex = 3;
            this.labeltype.Text = "Товар";
            // 
            // labelcount
            // 
            this.labelcount.AutoSize = true;
            this.labelcount.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelcount.Location = new System.Drawing.Point(4, 136);
            this.labelcount.Name = "labelcount";
            this.labelcount.Size = new System.Drawing.Size(106, 19);
            this.labelcount.TabIndex = 4;
            this.labelcount.Text = "Количество";
            // 
            // labelprovider
            // 
            this.labelprovider.AutoSize = true;
            this.labelprovider.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelprovider.Location = new System.Drawing.Point(21, 161);
            this.labelprovider.Name = "labelprovider";
            this.labelprovider.Size = new System.Drawing.Size(89, 22);
            this.labelprovider.TabIndex = 5;
            this.labelprovider.Text = "Поставщик";
            // 
            // labelprice
            // 
            this.labelprice.AutoSize = true;
            this.labelprice.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelprice.Location = new System.Drawing.Point(66, 191);
            this.labelprice.Name = "labelprice";
            this.labelprice.Size = new System.Drawing.Size(44, 22);
            this.labelprice.TabIndex = 6;
            this.labelprice.Text = "Цена";
            // 
            // textBoxid
            // 
            this.textBoxid.Location = new System.Drawing.Point(140, 74);
            this.textBoxid.Name = "textBoxid";
            this.textBoxid.Size = new System.Drawing.Size(231, 22);
            this.textBoxid.TabIndex = 7;
            // 
            // textBoxtype
            // 
            this.textBoxtype.Location = new System.Drawing.Point(140, 104);
            this.textBoxtype.Name = "textBoxtype";
            this.textBoxtype.Size = new System.Drawing.Size(231, 22);
            this.textBoxtype.TabIndex = 8;
            // 
            // textBoxcount
            // 
            this.textBoxcount.Location = new System.Drawing.Point(140, 135);
            this.textBoxcount.Name = "textBoxcount";
            this.textBoxcount.Size = new System.Drawing.Size(231, 22);
            this.textBoxcount.TabIndex = 9;
            // 
            // textBoxprovider
            // 
            this.textBoxprovider.Location = new System.Drawing.Point(140, 163);
            this.textBoxprovider.Name = "textBoxprovider";
            this.textBoxprovider.Size = new System.Drawing.Size(231, 22);
            this.textBoxprovider.TabIndex = 10;
            // 
            // textBoxprice
            // 
            this.textBoxprice.Location = new System.Drawing.Point(140, 191);
            this.textBoxprice.Name = "textBoxprice";
            this.textBoxprice.Size = new System.Drawing.Size(231, 22);
            this.textBoxprice.TabIndex = 11;
            // 
            // buttonnew
            // 
            this.buttonnew.Location = new System.Drawing.Point(16, 44);
            this.buttonnew.Name = "buttonnew";
            this.buttonnew.Size = new System.Drawing.Size(184, 43);
            this.buttonnew.TabIndex = 0;
            this.buttonnew.Text = "Новая запись";
            this.buttonnew.UseVisualStyleBackColor = true;
            this.buttonnew.Click += new System.EventHandler(this.buttonnew_Click);
            // 
            // buttondel
            // 
            this.buttondel.Location = new System.Drawing.Point(226, 44);
            this.buttondel.Name = "buttondel";
            this.buttondel.Size = new System.Drawing.Size(184, 48);
            this.buttondel.TabIndex = 1;
            this.buttondel.Text = "Удалить";
            this.buttondel.UseVisualStyleBackColor = true;
            this.buttondel.Click += new System.EventHandler(this.buttondel_Click);
            // 
            // buttonedit
            // 
            this.buttonedit.Location = new System.Drawing.Point(16, 98);
            this.buttonedit.Name = "buttonedit";
            this.buttonedit.Size = new System.Drawing.Size(184, 43);
            this.buttonedit.TabIndex = 2;
            this.buttonedit.Text = "Изменить";
            this.buttonedit.UseVisualStyleBackColor = true;
            this.buttonedit.Click += new System.EventHandler(this.buttonedit_Click);
            // 
            // buttonsave
            // 
            this.buttonsave.Location = new System.Drawing.Point(226, 98);
            this.buttonsave.Name = "buttonsave";
            this.buttonsave.Size = new System.Drawing.Size(184, 43);
            this.buttonsave.TabIndex = 3;
            this.buttonsave.Text = "Сохранить";
            this.buttonsave.UseVisualStyleBackColor = true;
            this.buttonsave.Click += new System.EventHandler(this.buttonsave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(109, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 27);
            this.label1.TabIndex = 4;
            this.label1.Text = "Управление записями";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 119);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(671, 393);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::pikpo.Properties.Resources._1663660785_35_mykaleidoscope_ru___1_;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 67);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBoxRefresh
            // 
            this.pictureBoxRefresh.Image = global::pikpo.Properties.Resources.refresh__1_;
            this.pictureBoxRefresh.Location = new System.Drawing.Point(339, 7);
            this.pictureBoxRefresh.Name = "pictureBoxRefresh";
            this.pictureBoxRefresh.Size = new System.Drawing.Size(71, 61);
            this.pictureBoxRefresh.TabIndex = 5;
            this.pictureBoxRefresh.TabStop = false;
            this.pictureBoxRefresh.Click += new System.EventHandler(this.pictureBoxRefresh_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::pikpo.Properties.Resources.free_icon_mop_8033451__1_;
            this.pictureBox4.Location = new System.Drawing.Point(747, 6);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(53, 55);
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::pikpo.Properties.Resources.free_icon_magnifying_glass_20715;
            this.pictureBox3.Location = new System.Drawing.Point(805, 6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(53, 44);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::pikpo.Properties.Resources._1663660785_35_mykaleidoscope_ru___1_;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(73, 64);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // управлениеToolStripMenuItem
            // 
            this.управлениеToolStripMenuItem.Name = "управлениеToolStripMenuItem";
            this.управлениеToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.управлениеToolStripMenuItem.Text = "Управление";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1145, 524);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem информацияToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBoxprice;
        private System.Windows.Forms.TextBox textBoxprovider;
        private System.Windows.Forms.TextBox textBoxcount;
        private System.Windows.Forms.TextBox textBoxtype;
        private System.Windows.Forms.TextBox textBoxid;
        private System.Windows.Forms.Label labelprice;
        private System.Windows.Forms.Label labelprovider;
        private System.Windows.Forms.Label labelcount;
        private System.Windows.Forms.Label labeltype;
        private System.Windows.Forms.Label labelid;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_entry;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonsave;
        private System.Windows.Forms.Button buttonedit;
        private System.Windows.Forms.Button buttondel;
        private System.Windows.Forms.Button buttonnew;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBoxRefresh;
        private System.Windows.Forms.ToolStripMenuItem управлениеToolStripMenuItem;
    }
}