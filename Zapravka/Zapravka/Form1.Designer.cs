namespace Zapravka
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.summa_textBox = new System.Windows.Forms.TextBox();
            this.count_textBox = new System.Windows.Forms.TextBox();
            this.summa_radiobutton = new System.Windows.Forms.RadioButton();
            this.count_radioButton = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.priceFuel_textBox = new System.Windows.Forms.TextBox();
            this.fuel_comboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.fuelPrice_groupBox = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.oplata_textBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.fuelPrice_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.summa_textBox);
            this.groupBox1.Controls.Add(this.count_textBox);
            this.groupBox1.Controls.Add(this.summa_radiobutton);
            this.groupBox1.Controls.Add(this.count_radioButton);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.priceFuel_textBox);
            this.groupBox1.Controls.Add(this.fuel_comboBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(579, 268);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Заправка";
            // 
            // summa_textBox
            // 
            this.summa_textBox.Enabled = false;
            this.summa_textBox.Location = new System.Drawing.Point(188, 166);
            this.summa_textBox.Name = "summa_textBox";
            this.summa_textBox.Size = new System.Drawing.Size(269, 20);
            this.summa_textBox.TabIndex = 8;
            this.summa_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.count_textBox_KeyPress);
            // 
            // count_textBox
            // 
            this.count_textBox.Enabled = false;
            this.count_textBox.Location = new System.Drawing.Point(188, 131);
            this.count_textBox.Name = "count_textBox";
            this.count_textBox.Size = new System.Drawing.Size(269, 20);
            this.count_textBox.TabIndex = 7;
            this.count_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.count_textBox_KeyPress);
            // 
            // summa_radiobutton
            // 
            this.summa_radiobutton.AutoSize = true;
            this.summa_radiobutton.Location = new System.Drawing.Point(91, 166);
            this.summa_radiobutton.Name = "summa_radiobutton";
            this.summa_radiobutton.Size = new System.Drawing.Size(59, 17);
            this.summa_radiobutton.TabIndex = 6;
            this.summa_radiobutton.TabStop = true;
            this.summa_radiobutton.Text = "Сумма";
            this.summa_radiobutton.UseVisualStyleBackColor = true;
            this.summa_radiobutton.CheckedChanged += new System.EventHandler(this.summa_radiobutton_CheckedChanged);
            // 
            // count_radioButton
            // 
            this.count_radioButton.AutoSize = true;
            this.count_radioButton.Location = new System.Drawing.Point(91, 131);
            this.count_radioButton.Name = "count_radioButton";
            this.count_radioButton.Size = new System.Drawing.Size(84, 17);
            this.count_radioButton.TabIndex = 5;
            this.count_radioButton.TabStop = true;
            this.count_radioButton.Text = "Количество";
            this.count_radioButton.UseVisualStyleBackColor = true;
            this.count_radioButton.CheckedChanged += new System.EventHandler(this.count_radioButton_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(478, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "BYN";
            // 
            // priceFuel_textBox
            // 
            this.priceFuel_textBox.Enabled = false;
            this.priceFuel_textBox.Location = new System.Drawing.Point(188, 57);
            this.priceFuel_textBox.Name = "priceFuel_textBox";
            this.priceFuel_textBox.Size = new System.Drawing.Size(269, 20);
            this.priceFuel_textBox.TabIndex = 3;
            // 
            // fuel_comboBox
            // 
            this.fuel_comboBox.FormattingEnabled = true;
            this.fuel_comboBox.Location = new System.Drawing.Point(188, 22);
            this.fuel_comboBox.Name = "fuel_comboBox";
            this.fuel_comboBox.Size = new System.Drawing.Size(269, 21);
            this.fuel_comboBox.TabIndex = 2;
            this.fuel_comboBox.SelectedIndexChanged += new System.EventHandler(this.fuel_comboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Стоимость";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Топливо";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(598, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(574, 268);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Мини-кафе";
            // 
            // fuelPrice_groupBox
            // 
            this.fuelPrice_groupBox.Controls.Add(this.oplata_textBox);
            this.fuelPrice_groupBox.Location = new System.Drawing.Point(13, 287);
            this.fuelPrice_groupBox.Name = "fuelPrice_groupBox";
            this.fuelPrice_groupBox.Size = new System.Drawing.Size(579, 100);
            this.fuelPrice_groupBox.TabIndex = 2;
            this.fuelPrice_groupBox.TabStop = false;
            this.fuelPrice_groupBox.Text = "Стоимость топлива";
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(598, 287);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(574, 100);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Оплата продуктов";
            // 
            // groupBox5
            // 
            this.groupBox5.Location = new System.Drawing.Point(13, 394);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1159, 137);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Полный расчет";
            // 
            // oplata_textBox
            // 
            this.oplata_textBox.Location = new System.Drawing.Point(188, 37);
            this.oplata_textBox.Name = "oplata_textBox";
            this.oplata_textBox.Size = new System.Drawing.Size(269, 20);
            this.oplata_textBox.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 543);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.fuelPrice_groupBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.fuelPrice_groupBox.ResumeLayout(false);
            this.fuelPrice_groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox summa_textBox;
        private System.Windows.Forms.TextBox count_textBox;
        private System.Windows.Forms.RadioButton summa_radiobutton;
        private System.Windows.Forms.RadioButton count_radioButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox priceFuel_textBox;
        private System.Windows.Forms.ComboBox fuel_comboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox fuelPrice_groupBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox oplata_textBox;
    }
}

