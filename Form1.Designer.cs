
namespace Parser_zakupki.gov.ru_
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.ComBox1 = new System.Windows.Forms.ComboBox();
            this.CBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LabelDir = new System.Windows.Forms.Label();
            this.PBox2 = new System.Windows.Forms.PictureBox();
            this.PBox1 = new System.Windows.Forms.PictureBox();
            this.LabelIndex = new System.Windows.Forms.Label();
            this.PBox3 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LabelZip = new System.Windows.Forms.Label();
            this.PBox4 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.DGridView1 = new System.Windows.Forms.DataGridView();
            this.ProgFile1 = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.Save1 = new System.Windows.Forms.LinkLabel();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel3 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SumItog = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBox4)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Доступ в интернет";
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.Gainsboro;
            this.StartButton.Location = new System.Drawing.Point(11, 25);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(258, 36);
            this.StartButton.TabIndex = 1;
            this.StartButton.Text = "Получить данные";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.Button2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.ComBox1);
            this.panel1.Controls.Add(this.CBox1);
            this.panel1.Controls.Add(this.StartButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1409, 66);
            this.panel1.TabIndex = 2;
            // 
            // Button2
            // 
            this.Button2.Enabled = false;
            this.Button2.Location = new System.Drawing.Point(577, 26);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(181, 35);
            this.Button2.TabIndex = 5;
            this.Button2.Text = "Выбрать даты";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(777, 32);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 23);
            this.label6.TabIndex = 4;
            this.label6.Text = "Регион";
            // 
            // ComBox1
            // 
            this.ComBox1.BackColor = System.Drawing.Color.Silver;
            this.ComBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComBox1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ComBox1.FormattingEnabled = true;
            this.ComBox1.Items.AddRange(new object[] {
            "Adygeja_Resp",
            "Altaj_Resp",
            "Altajskij_kraj",
            "Amurskaja_obl",
            "Arkhangelskaja_obl",
            "Astrakhanskaja_obl",
            "Bajkonur_g",
            "Bashkortostan_Resp",
            "Belgorodskaja_obl",
            "Brjanskaja_obl",
            "Burjatija_Resp",
            "Chechenskaja_Resp",
            "Cheljabinskaja_obl",
            "Chukotskij_AO",
            "Chuvashskaja_Resp",
            "Dagestan_Resp",
            "Evrejskaja_Aobl",
            "fcs_undefined",
            "Ingushetija_Resp",
            "Irkutskaja_obl",
            "Ivanovskaja_obl",
            "Jamalo-Neneckij_AO",
            "Jaroslavskaja_obl",
            "Kabardino-Balkarskaja_Resp",
            "Kaliningradskaja_obl",
            "Kalmykija_Resp",
            "Kaluzhskaja_obl",
            "Kamchatskij_kraj",
            "Karachaevo-Cherkesskaja_Resp",
            "Karelija_Resp",
            "Kemerovskaja_obl",
            "Khabarovskij_kraj",
            "Khakasija_Resp",
            "Khanty-Mansijskij_AO-Jugra_AO",
            "Kirovskaja_obl",
            "Komi_Resp",
            "Kostromskaja_obl",
            "Krasnodarskij_kraj",
            "Krasnojarskij_kraj",
            "Krim_Resp",
            "Kurganskaja_obl",
            "Kurskaja_obl",
            "Leningradskaja_obl",
            "Lipeckaja_obl",
            "Magadanskaja_obl",
            "Marij_El_Resp",
            "Mordovija_Resp",
            "Moskovskaja_obl",
            "Moskva",
            "Murmanskaja_obl",
            "Neneckij_AO",
            "Nizhegorodskaja_obl",
            "Novgorodskaja_obl",
            "Novosibirskaja_obl",
            "Omskaja_obl",
            "Orenburgskaja_obl",
            "Orlovskaja_obl",
            "Penzenskaja_obl",
            "Permskij_kraj",
            "Primorskij_kraj",
            "Pskovskaja_obl",
            "Rjazanskaja_obl",
            "Rostovskaja_obl",
            "Sakha_Jakutija_Resp",
            "Sakhalinskaja_obl",
            "Samarskaja_obl",
            "Sankt-Peterburg",
            "Saratovskaja_obl",
            "Sevastopol_g",
            "Severnaja_Osetija-Alanija_Resp",
            "Smolenskaja_obl",
            "Stavropolskij_kraj",
            "Sverdlovskaja_obl",
            "Tambovskaja_obl",
            "Tatarstan_Resp",
            "Tjumenskaja_obl",
            "Tomskaja_obl",
            "Tulskaja_obl",
            "Tverskaja_obl",
            "Tyva_Resp",
            "Udmurtskaja_Resp",
            "Uljanovskaja_obl",
            "Vladimirskaja_obl",
            "Volgogradskaja_obl",
            "Vologodskaja_obl",
            "Voronezhskaja_obl",
            "Zabajkalskij_kraj"});
            this.ComBox1.Location = new System.Drawing.Point(855, 31);
            this.ComBox1.Name = "ComBox1";
            this.ComBox1.Size = new System.Drawing.Size(286, 27);
            this.ComBox1.TabIndex = 3;
            // 
            // CBox1
            // 
            this.CBox1.AutoSize = true;
            this.CBox1.Checked = true;
            this.CBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CBox1.Location = new System.Drawing.Point(301, 31);
            this.CBox1.Name = "CBox1";
            this.CBox1.Size = new System.Drawing.Size(275, 27);
            this.CBox1.TabIndex = 2;
            this.CBox1.Text = "Только последня выгрузка";
            this.CBox1.UseVisualStyleBackColor = true;
            this.CBox1.CheckedChanged += new System.EventHandler(this.CBox1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(339, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Получаю каталог (ftp.zakupki.gov.ru)";
            // 
            // LabelDir
            // 
            this.LabelDir.AutoSize = true;
            this.LabelDir.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelDir.ForeColor = System.Drawing.Color.Maroon;
            this.LabelDir.Location = new System.Drawing.Point(410, 53);
            this.LabelDir.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelDir.Name = "LabelDir";
            this.LabelDir.Size = new System.Drawing.Size(0, 24);
            this.LabelDir.TabIndex = 6;
            // 
            // PBox2
            // 
            this.PBox2.Location = new System.Drawing.Point(12, 44);
            this.PBox2.Name = "PBox2";
            this.PBox2.Size = new System.Drawing.Size(32, 32);
            this.PBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBox2.TabIndex = 5;
            this.PBox2.TabStop = false;
            // 
            // PBox1
            // 
            this.PBox1.Location = new System.Drawing.Point(12, 3);
            this.PBox1.Name = "PBox1";
            this.PBox1.Size = new System.Drawing.Size(32, 32);
            this.PBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBox1.TabIndex = 3;
            this.PBox1.TabStop = false;
            // 
            // LabelIndex
            // 
            this.LabelIndex.AutoSize = true;
            this.LabelIndex.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelIndex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.LabelIndex.Location = new System.Drawing.Point(410, 94);
            this.LabelIndex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelIndex.Name = "LabelIndex";
            this.LabelIndex.Size = new System.Drawing.Size(0, 24);
            this.LabelIndex.TabIndex = 9;
            // 
            // PBox3
            // 
            this.PBox3.Location = new System.Drawing.Point(12, 85);
            this.PBox3.Name = "PBox3";
            this.PBox3.Size = new System.Drawing.Size(32, 32);
            this.PBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBox3.TabIndex = 8;
            this.PBox3.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 94);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Загрузка архивов";
            // 
            // LabelZip
            // 
            this.LabelZip.AutoSize = true;
            this.LabelZip.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelZip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.LabelZip.Location = new System.Drawing.Point(410, 134);
            this.LabelZip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelZip.Name = "LabelZip";
            this.LabelZip.Size = new System.Drawing.Size(0, 24);
            this.LabelZip.TabIndex = 12;
            // 
            // PBox4
            // 
            this.PBox4.Location = new System.Drawing.Point(12, 125);
            this.PBox4.Name = "PBox4";
            this.PBox4.Size = new System.Drawing.Size(32, 32);
            this.PBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBox4.TabIndex = 11;
            this.PBox4.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 134);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "Распаковка";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.DGridView1);
            this.panel2.Controls.Add(this.ProgFile1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 254);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1409, 437);
            this.panel2.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(1159, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(228, 28);
            this.button1.TabIndex = 17;
            this.button1.Text = "Открыть ссылку";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // DGridView1
            // 
            this.DGridView1.AllowUserToAddRows = false;
            this.DGridView1.BackgroundColor = System.Drawing.Color.White;
            this.DGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DGridView1.Location = new System.Drawing.Point(0, 28);
            this.DGridView1.MultiSelect = false;
            this.DGridView1.Name = "DGridView1";
            this.DGridView1.RowHeadersWidth = 51;
            this.DGridView1.RowTemplate.Height = 24;
            this.DGridView1.Size = new System.Drawing.Size(1409, 409);
            this.DGridView1.TabIndex = 16;
            // 
            // ProgFile1
            // 
            this.ProgFile1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ProgFile1.ForeColor = System.Drawing.Color.Blue;
            this.ProgFile1.Location = new System.Drawing.Point(21, 2);
            this.ProgFile1.Name = "ProgFile1";
            this.ProgFile1.Size = new System.Drawing.Size(239, 23);
            this.ProgFile1.Step = 1;
            this.ProgFile1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.ProgFile1.TabIndex = 15;
            this.ProgFile1.Visible = false;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1409, 28);
            this.label3.TabIndex = 14;
            this.label3.Text = "Отчет";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Save1
            // 
            this.Save1.AutoSize = true;
            this.Save1.Location = new System.Drawing.Point(878, 53);
            this.Save1.Name = "Save1";
            this.Save1.Size = new System.Drawing.Size(231, 23);
            this.Save1.TabIndex = 14;
            this.Save1.TabStop = true;
            this.Save1.Text = "Сохранить отчет в Excel";
            this.Save1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Save1_LinkClicked);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Title = "Сохранить отчет в Excel";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.SumItog);
            this.panel3.Controls.Add(this.linkLabel1);
            this.panel3.Controls.Add(this.PBox1);
            this.panel3.Controls.Add(this.Save1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.LabelZip);
            this.panel3.Controls.Add(this.PBox2);
            this.panel3.Controls.Add(this.PBox4);
            this.panel3.Controls.Add(this.LabelDir);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.LabelIndex);
            this.panel3.Controls.Add(this.PBox3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 66);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1409, 188);
            this.panel3.TabIndex = 15;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(878, 4);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(283, 23);
            this.linkLabel1.TabIndex = 15;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Смотреть прошлый результат";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
            // 
            // SumItog
            // 
            this.SumItog.AutoSize = true;
            this.SumItog.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SumItog.Location = new System.Drawing.Point(878, 152);
            this.SumItog.Name = "SumItog";
            this.SumItog.Size = new System.Drawing.Size(96, 23);
            this.SumItog.TabIndex = 16;
            this.SumItog.Text = "Список пуст";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1409, 691);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "ftp.zakupki.gov.ru";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBox4)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox PBox1;
        private System.Windows.Forms.PictureBox PBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LabelDir;
        private System.Windows.Forms.CheckBox CBox1;
        private System.Windows.Forms.Label LabelIndex;
        private System.Windows.Forms.PictureBox PBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LabelZip;
        private System.Windows.Forms.PictureBox PBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar ProgFile1;
        private System.Windows.Forms.DataGridView DGridView1;
        private System.Windows.Forms.LinkLabel Save1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ComBox1;
        private System.Windows.Forms.Button Button2;
        private System.Windows.Forms.Label SumItog;
    }
}

