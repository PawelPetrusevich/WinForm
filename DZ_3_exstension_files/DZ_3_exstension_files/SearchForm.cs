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

namespace DZ_3_exstension_files
{
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
            
        }

        private void bt_searchform_Click(object sender, EventArgs e)
        {
            string path = tb_directoryName.Text;
            string[] files = Directory.GetFiles(path, "*.avi", SearchOption.AllDirectories);
            
            foreach (var file in files)
            {
                
            }
        }
    }
}
