namespace DZ_2_ListBox
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_telefon = new System.Windows.Forms.TextBox();
            this.tb_fathername = new System.Windows.Forms.TextBox();
            this.tb_lastname = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.b_remove = new System.Windows.Forms.Button();
            this.b_fiks = new System.Windows.Forms.Button();
            this.b_add = new System.Windows.Forms.Button();
            this.bt_xml = new System.Windows.Forms.Button();
            this.bt_uotXML = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 283);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Список анкет";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(7, 20);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(269, 251);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tb_telefon);
            this.groupBox2.Controls.Add(this.tb_fathername);
            this.groupBox2.Controls.Add(this.tb_lastname);
            this.groupBox2.Controls.Add(this.tb_name);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(301, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(357, 283);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Анкета";
            // 
            // tb_telefon
            // 
            this.tb_telefon.Location = new System.Drawing.Point(117, 207);
            this.tb_telefon.Name = "tb_telefon";
            this.tb_telefon.Size = new System.Drawing.Size(234, 20);
            this.tb_telefon.TabIndex = 7;
            // 
            // tb_fathername
            // 
            this.tb_fathername.Location = new System.Drawing.Point(117, 128);
            this.tb_fathername.Name = "tb_fathername";
            this.tb_fathername.Size = new System.Drawing.Size(234, 20);
            this.tb_fathername.TabIndex = 6;
            // 
            // tb_lastname
            // 
            this.tb_lastname.Location = new System.Drawing.Point(117, 66);
            this.tb_lastname.Name = "tb_lastname";
            this.tb_lastname.Size = new System.Drawing.Size(234, 20);
            this.tb_lastname.TabIndex = 5;
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(117, 12);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(234, 20);
            this.tb_name.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Телефон";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Отчество";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Фамилия";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bt_uotXML);
            this.groupBox3.Controls.Add(this.bt_xml);
            this.groupBox3.Controls.Add(this.b_remove);
            this.groupBox3.Controls.Add(this.b_fiks);
            this.groupBox3.Controls.Add(this.b_add);
            this.groupBox3.Location = new System.Drawing.Point(13, 303);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(645, 100);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Операции";
            // 
            // b_remove
            // 
            this.b_remove.Location = new System.Drawing.Point(352, 42);
            this.b_remove.Name = "b_remove";
            this.b_remove.Size = new System.Drawing.Size(82, 23);
            this.b_remove.TabIndex = 2;
            this.b_remove.Text = "Удалить";
            this.b_remove.UseVisualStyleBackColor = true;
            this.b_remove.Click += new System.EventHandler(this.b_remove_Click);
            // 
            // b_fiks
            // 
            this.b_fiks.Location = new System.Drawing.Point(264, 42);
            this.b_fiks.Name = "b_fiks";
            this.b_fiks.Size = new System.Drawing.Size(82, 23);
            this.b_fiks.TabIndex = 1;
            this.b_fiks.Text = "Редактировать";
            this.b_fiks.UseVisualStyleBackColor = true;
            this.b_fiks.Click += new System.EventHandler(this.b_fiks_Click);
            // 
            // b_add
            // 
            this.b_add.Location = new System.Drawing.Point(176, 42);
            this.b_add.Name = "b_add";
            this.b_add.Size = new System.Drawing.Size(82, 23);
            this.b_add.TabIndex = 0;
            this.b_add.Text = "Добавить";
            this.b_add.UseVisualStyleBackColor = true;
            this.b_add.Click += new System.EventHandler(this.b_add_Click);
            // 
            // bt_xml
            // 
            this.bt_xml.Location = new System.Drawing.Point(441, 42);
            this.bt_xml.Name = "bt_xml";
            this.bt_xml.Size = new System.Drawing.Size(75, 23);
            this.bt_xml.TabIndex = 3;
            this.bt_xml.Text = "XML";
            this.bt_xml.UseVisualStyleBackColor = true;
            this.bt_xml.Click += new System.EventHandler(this.bt_xml_Click);
            // 
            // bt_uotXML
            // 
            this.bt_uotXML.Location = new System.Drawing.Point(523, 41);
            this.bt_uotXML.Name = "bt_uotXML";
            this.bt_uotXML.Size = new System.Drawing.Size(116, 23);
            this.bt_uotXML.TabIndex = 4;
            this.bt_uotXML.Text = "Извлеч XML";
            this.bt_uotXML.UseVisualStyleBackColor = true;
            this.bt_uotXML.Click += new System.EventHandler(this.bt_uotXML_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 427);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tb_telefon;
        private System.Windows.Forms.TextBox tb_fathername;
        private System.Windows.Forms.TextBox tb_lastname;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button b_remove;
        private System.Windows.Forms.Button b_fiks;
        private System.Windows.Forms.Button b_add;
        private System.Windows.Forms.Button bt_xml;
        private System.Windows.Forms.Button bt_uotXML;
    }
}

