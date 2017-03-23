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

namespace DZ_2_ProgressBar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader("text.txt",System.Text.Encoding.Default))
            {
                char [] temp = sr.ReadToEnd().ToCharArray();
                progressBar1.Maximum = temp.Length;
                string str =  null;
                for (int i = 0; i < temp.Length; i++)
                {
                    progressBar1.Value++;


                    textBox1.Text += temp[i];
                    System.Threading.Thread.Sleep(50);
                }

            }
        }
    }
}
