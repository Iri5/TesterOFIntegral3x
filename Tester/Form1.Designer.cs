﻿namespace Tester
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.numTestsN = new System.Windows.Forms.NumericUpDown();
            this.txtbCoeff = new System.Windows.Forms.TextBox();
            this.numEps = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbStep = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtbRes = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtbGener = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnGener = new System.Windows.Forms.Button();
            this.btnCulc = new System.Windows.Forms.Button();
            this.btn_saveInput = new System.Windows.Forms.Button();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            this.btn_load = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtbResN = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numTestsN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbStep)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Количество тест-кейсов:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(107, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Погрешность:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Malgun Gothic Semilight", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(338, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Границы диапазона интегрирование = RAND";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(16, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(121, 25);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Позитивные";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(16, 51);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(118, 25);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.Text = "Негативные";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(317, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Коэффициенты полинома через пробел";
            // 
            // numTestsN
            // 
            this.numTestsN.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numTestsN.Location = new System.Drawing.Point(225, 25);
            this.numTestsN.Name = "numTestsN";
            this.numTestsN.Size = new System.Drawing.Size(120, 29);
            this.numTestsN.TabIndex = 8;
            this.numTestsN.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // txtbCoeff
            // 
            this.txtbCoeff.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbCoeff.Location = new System.Drawing.Point(28, 327);
            this.txtbCoeff.Name = "txtbCoeff";
            this.txtbCoeff.Size = new System.Drawing.Size(317, 29);
            this.txtbCoeff.TabIndex = 9;
            // 
            // numEps
            // 
            this.numEps.DecimalPlaces = 1;
            this.numEps.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numEps.Location = new System.Drawing.Point(225, 59);
            this.numEps.Name = "numEps";
            this.numEps.Size = new System.Drawing.Size(120, 29);
            this.numEps.TabIndex = 10;
            this.numEps.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(53, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 21);
            this.label5.TabIndex = 11;
            this.label5.Text = "Шаг интегрирования:";
            // 
            // txtbStep
            // 
            this.txtbStep.DecimalPlaces = 6;
            this.txtbStep.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbStep.Location = new System.Drawing.Point(224, 94);
            this.txtbStep.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.txtbStep.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            393216});
            this.txtbStep.Name = "txtbStep";
            this.txtbStep.Size = new System.Drawing.Size(120, 29);
            this.txtbStep.TabIndex = 12;
            this.txtbStep.Value = new decimal(new int[] {
            1,
            0,
            0,
            393216});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(192, 21);
            this.label6.TabIndex = 14;
            this.label6.Text = "Метод интегрирования:";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.Items.AddRange(new object[] {
            "Парабол",
            "Трапеции",
            "Монте-Карло"});
            this.comboBox1.Location = new System.Drawing.Point(225, 131);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 29);
            this.comboBox1.TabIndex = 15;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(111, 204);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 78);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Тип тест-кейсов";
            // 
            // txtbRes
            // 
            this.txtbRes.BackColor = System.Drawing.SystemColors.Window;
            this.txtbRes.Location = new System.Drawing.Point(616, 101);
            this.txtbRes.Multiline = true;
            this.txtbRes.Name = "txtbRes";
            this.txtbRes.ReadOnly = true;
            this.txtbRes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtbRes.Size = new System.Drawing.Size(218, 402);
            this.txtbRes.TabIndex = 17;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(28, 418);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(321, 39);
            this.button2.TabIndex = 20;
            this.button2.Text = "Сохранить результаты";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Malgun Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(612, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 21);
            this.label7.TabIndex = 21;
            this.label7.Text = "Пройденные:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Malgun Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(846, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 21);
            this.label8.TabIndex = 22;
            this.label8.Text = "Непройденные:";
            // 
            // txtbGener
            // 
            this.txtbGener.BackColor = System.Drawing.SystemColors.Window;
            this.txtbGener.Location = new System.Drawing.Point(382, 101);
            this.txtbGener.Multiline = true;
            this.txtbGener.Name = "txtbGener";
            this.txtbGener.ReadOnly = true;
            this.txtbGener.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtbGener.Size = new System.Drawing.Size(218, 402);
            this.txtbGener.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Malgun Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(378, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 21);
            this.label9.TabIndex = 24;
            this.label9.Text = "Тест-кейсы:";
            // 
            // btnGener
            // 
            this.btnGener.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnGener.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGener.FlatAppearance.BorderSize = 0;
            this.btnGener.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.btnGener.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGener.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGener.Location = new System.Drawing.Point(29, 373);
            this.btnGener.Name = "btnGener";
            this.btnGener.Size = new System.Drawing.Size(157, 39);
            this.btnGener.TabIndex = 25;
            this.btnGener.Text = "Сгенерировать";
            this.btnGener.UseVisualStyleBackColor = false;
            this.btnGener.Click += new System.EventHandler(this.btnGener_Click);
            // 
            // btnCulc
            // 
            this.btnCulc.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnCulc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCulc.FlatAppearance.BorderSize = 0;
            this.btnCulc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.btnCulc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCulc.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCulc.Location = new System.Drawing.Point(192, 373);
            this.btnCulc.Name = "btnCulc";
            this.btnCulc.Size = new System.Drawing.Size(157, 39);
            this.btnCulc.TabIndex = 26;
            this.btnCulc.Text = "Пройти";
            this.btnCulc.UseVisualStyleBackColor = false;
            this.btnCulc.Click += new System.EventHandler(this.btnCulc_Click);
            // 
            // btn_saveInput
            // 
            this.btn_saveInput.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_saveInput.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_saveInput.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_saveInput.Location = new System.Drawing.Point(28, 463);
            this.btn_saveInput.Name = "btn_saveInput";
            this.btn_saveInput.Size = new System.Drawing.Size(321, 39);
            this.btn_saveInput.TabIndex = 27;
            this.btn_saveInput.Text = "Сохранить тест-кейсы";
            this.btn_saveInput.UseVisualStyleBackColor = false;
            this.btn_saveInput.Click += new System.EventHandler(this.btn_saveInput_Click);
            // 
            // btn_load
            // 
            this.btn_load.BackColor = System.Drawing.Color.PowderBlue;
            this.btn_load.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_load.FlatAppearance.BorderSize = 0;
            this.btn_load.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.btn_load.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_load.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_load.Location = new System.Drawing.Point(382, 25);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(218, 39);
            this.btn_load.TabIndex = 28;
            this.btn_load.Text = "Загрузить из файла";
            this.btn_load.UseVisualStyleBackColor = false;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtbResN
            // 
            this.txtbResN.BackColor = System.Drawing.SystemColors.Window;
            this.txtbResN.Location = new System.Drawing.Point(850, 101);
            this.txtbResN.Multiline = true;
            this.txtbResN.Name = "txtbResN";
            this.txtbResN.ReadOnly = true;
            this.txtbResN.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtbResN.Size = new System.Drawing.Size(218, 402);
            this.txtbResN.TabIndex = 29;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(1088, 524);
            this.Controls.Add(this.txtbResN);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.btn_saveInput);
            this.Controls.Add(this.btnCulc);
            this.Controls.Add(this.btnGener);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtbGener);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtbRes);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtbStep);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numEps);
            this.Controls.Add(this.txtbCoeff);
            this.Controls.Add(this.numTestsN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Тестировщик Integral3x";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numTestsN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbStep)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numTestsN;
        private System.Windows.Forms.TextBox txtbCoeff;
        private System.Windows.Forms.NumericUpDown numEps;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown txtbStep;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtbRes;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtbGener;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnGener;
        private System.Windows.Forms.Button btnCulc;
        private System.Windows.Forms.Button btn_saveInput;
        private System.Windows.Forms.SaveFileDialog saveFileDialog2;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtbResN;
    }
}

