namespace DZ_3_exstension_files
{
    partial class SearchForm
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
            this.bt_searchform = new System.Windows.Forms.Button();
            this.tb_directoryName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bt_searchform
            // 
            this.bt_searchform.Location = new System.Drawing.Point(387, 12);
            this.bt_searchform.Name = "bt_searchform";
            this.bt_searchform.Size = new System.Drawing.Size(119, 23);
            this.bt_searchform.TabIndex = 1;
            this.bt_searchform.Text = "Начать поиск";
            this.bt_searchform.UseVisualStyleBackColor = true;
            this.bt_searchform.Click += new System.EventHandler(this.bt_searchform_Click);
            // 
            // tb_directoryName
            // 
            this.tb_directoryName.Location = new System.Drawing.Point(13, 13);
            this.tb_directoryName.Name = "tb_directoryName";
            this.tb_directoryName.Size = new System.Drawing.Size(368, 20);
            this.tb_directoryName.TabIndex = 2;
            this.tb_directoryName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 75);
            this.Controls.Add(this.tb_directoryName);
            this.Controls.Add(this.bt_searchform);
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bt_searchform;
        private System.Windows.Forms.TextBox tb_directoryName;
    }
}