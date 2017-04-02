using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DZ_3_1
{
    public partial class Form1 : Form
    {
        string path = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            SearchForm form = new SearchForm();
            
            if (form.ShowDialog() == DialogResult.OK)
            {
                path = form.searchText;
            }

            if (form.searchText != null)
            {
                string[] file = Directory.GetFiles(path, "*.doc");
                foreach (var item in file)
                {
                    listView1.Items.Add(item);
                }
            }
            else
            {
                MessageBox.Show("Строка поиска пуста");
            }
            
        }
    }
}
