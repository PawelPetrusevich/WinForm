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

namespace DZ_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader("File.txt",System.Text.Encoding.Default))
            {
                string temp = sr.ReadToEnd();
                int progbarLength = temp.Length;
                progressBar1.Maximum = progbarLength;
                int count = 0;
                char[] array = new char[progbarLength];
                sr.Read(array,0,20);
                for (int i = 0; i < progbarLength; i++)
                {
                    
                    sr.Read(array, i, 1);
                    count++;
                    textBox1.Text += array[i];
                    progressBar1.Value = count;
                }


            }
        }
    }
}
