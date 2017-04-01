namespace DZ_3_exstension_files
{
    partial class ResultForm
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
            this.lb_resultForm = new System.Windows.Forms.ListBox();
            this.bt_searchForm1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_resultForm
            // 
            this.lb_resultForm.FormattingEnabled = true;
            this.lb_resultForm.Location = new System.Drawing.Point(13, 62);
            this.lb_resultForm.Name = "lb_resultForm";
            this.lb_resultForm.Size = new System.Drawing.Size(120, 186);
            this.lb_resultForm.TabIndex = 0;
            // 
            // bt_searchForm1
            // 
            this.bt_searchForm1.Location = new System.Drawing.Point(13, 13);
            this.bt_searchForm1.Name = "bt_searchForm1";
            this.bt_searchForm1.Size = new System.Drawing.Size(120, 23);
            this.bt_searchForm1.TabIndex = 1;
            this.bt_searchForm1.Text = "Поиск";
            this.bt_searchForm1.UseVisualStyleBackColor = true;
            this.bt_searchForm1.Click += new System.EventHandler(this.bt_searchForm1_Click);
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(197, 261);
            this.Controls.Add(this.bt_searchForm1);
            this.Controls.Add(this.lb_resultForm);
            this.Name = "ResultForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lb_resultForm;
        private System.Windows.Forms.Button bt_searchForm1;
    }
}

