using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DZ_3_exstension_files
{
    public partial class ResultForm : Form
    {
        FileCollections filecolection = new FileCollections();
        public ResultForm()
        {
            InitializeComponent();
        }

        private void bt_searchForm1_Click(object sender, EventArgs e)
        {
            SearchForm form = new SearchForm();
            //form.Owner = this;
            form.Show();
            if (form.DialogResult == DialogResult.)
            {

            }
        }
    }
}
