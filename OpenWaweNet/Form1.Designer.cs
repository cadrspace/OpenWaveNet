namespace OpenWaweNet
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
            this.components = new System.ComponentModel.Container();
            this.pb = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.setka = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.obzor = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mest = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.act_time = new System.Windows.Forms.TrackBar();
            this.deact_time = new System.Windows.Forms.TrackBar();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label_iter = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.maxactivitis = new System.Windows.Forms.TrackBar();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setka)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obzor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.act_time)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deact_time)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxactivitis)).BeginInit();
            this.SuspendLayout();
            // 
            // pb
            // 
            this.pb.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pb.Location = new System.Drawing.Point(12, 12);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(504, 379);
            this.pb.TabIndex = 0;
            this.pb.TabStop = false;
            this.pb.Click += new System.EventHandler(this.pb_Click);
            this.pb.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pb_MouseClick);
            this.pb.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pb_MouseMove);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(771, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "Шаг";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // setka
            // 
            this.setka.Location = new System.Drawing.Point(522, 25);
            this.setka.Maximum = 100;
            this.setka.Minimum = 5;
            this.setka.Name = "setka";
            this.setka.Size = new System.Drawing.Size(155, 45);
            this.setka.TabIndex = 2;
            this.setka.Value = 10;
            this.setka.Scroll += new System.EventHandler(this.setka_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(683, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(528, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "количество клеток на поле";
            // 
            // obzor
            // 
            this.obzor.Location = new System.Drawing.Point(525, 91);
            this.obzor.Minimum = 1;
            this.obzor.Name = "obzor";
            this.obzor.Size = new System.Drawing.Size(155, 45);
            this.obzor.TabIndex = 5;
            this.obzor.Value = 1;
            this.obzor.Scroll += new System.EventHandler(this.obzor_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(528, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "зона обзора 1 клетки";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(683, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(528, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "мест в списке";
            // 
            // mest
            // 
            this.mest.Location = new System.Drawing.Point(531, 142);
            this.mest.Minimum = 1;
            this.mest.Name = "mest";
            this.mest.Size = new System.Drawing.Size(155, 45);
            this.mest.TabIndex = 9;
            this.mest.Value = 1;
            this.mest.Scroll += new System.EventHandler(this.mest_Scroll);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(683, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "label6";
            // 
            // act_time
            // 
            this.act_time.Location = new System.Drawing.Point(531, 268);
            this.act_time.Maximum = 100;
            this.act_time.Minimum = 1;
            this.act_time.Name = "act_time";
            this.act_time.Size = new System.Drawing.Size(155, 45);
            this.act_time.TabIndex = 11;
            this.act_time.Value = 2;
            this.act_time.Scroll += new System.EventHandler(this.act_time_Scroll);
            // 
            // deact_time
            // 
            this.deact_time.Location = new System.Drawing.Point(531, 319);
            this.deact_time.Maximum = 100;
            this.deact_time.Minimum = 1;
            this.deact_time.Name = "deact_time";
            this.deact_time.Size = new System.Drawing.Size(155, 45);
            this.deact_time.TabIndex = 12;
            this.deact_time.Value = 5;
            this.deact_time.Scroll += new System.EventHandler(this.deact_time_Scroll);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(537, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "время активности (шагов)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(537, 303);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "время неактивности (шагов)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(692, 268);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "2";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(689, 328);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "5";
            // 
            // label_iter
            // 
            this.label_iter.AutoSize = true;
            this.label_iter.Location = new System.Drawing.Point(929, 244);
            this.label_iter.Name = "label_iter";
            this.label_iter.Size = new System.Drawing.Size(13, 13);
            this.label_iter.TabIndex = 17;
            this.label_iter.Text = "5";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(815, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "активна";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(815, 91);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "в списке";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(815, 123);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "в чужом списке";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Location = new System.Drawing.Point(784, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(25, 21);
            this.panel1.TabIndex = 23;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Green;
            this.panel2.Location = new System.Drawing.Point(784, 86);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(25, 21);
            this.panel2.TabIndex = 24;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Blue;
            this.panel3.Location = new System.Drawing.Point(784, 115);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(25, 21);
            this.panel3.TabIndex = 24;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(813, 57);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(223, 13);
            this.label14.TabIndex = 25;
            this.label14.Text = "нажмите клетку на поле для ее активации";
            // 
            // maxactivitis
            // 
            this.maxactivitis.Location = new System.Drawing.Point(531, 193);
            this.maxactivitis.Maximum = 50;
            this.maxactivitis.Minimum = 1;
            this.maxactivitis.Name = "maxactivitis";
            this.maxactivitis.Size = new System.Drawing.Size(155, 45);
            this.maxactivitis.TabIndex = 26;
            this.maxactivitis.Value = 1;
            this.maxactivitis.Scroll += new System.EventHandler(this.maxactivitis_Scroll);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(537, 174);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(176, 13);
            this.label15.TabIndex = 27;
            this.label15.Text = "оганичение плотности активации";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(683, 193);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(13, 13);
            this.label16.TabIndex = 28;
            this.label16.Text = "4";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(784, 285);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(68, 17);
            this.checkBox1.TabIndex = 29;
            this.checkBox1.Text = "автошаг";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 413);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.maxactivitis);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label_iter);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.deact_time);
            this.Controls.Add(this.act_time);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mest);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.obzor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.setka);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pb);
            this.Name = "Form1";
            this.Text = "OpenWaweNeuroNet DL";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setka)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obzor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.act_time)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deact_time)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxactivitis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TrackBar setka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar obzor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar mest;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar act_time;
        private System.Windows.Forms.TrackBar deact_time;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label_iter;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TrackBar maxactivitis;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Timer timer1;
    }
}

