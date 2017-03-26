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
            //worker_DoWork(null, null);
            // создает обьект класа для выполнение асинхроного режима
            var worker = new BackgroundWorker();
            //подписываемся на событие DOWork
            worker.DoWork += worker_DoWork;
            //запускаем асинхроное выполнение
            worker.RunWorkerAsync();
            
        }

        void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            using (StreamReader sr = new StreamReader("text.txt", System.Text.Encoding.Default))
            {
                char[] temp = sr.ReadToEnd().ToCharArray();
                progressBar1.Invoke(new Action(() => { progressBar1.Maximum = temp.Length; }));
                for (int i = 0; i < temp.Length; i++)
                {
                    //обьекты invoke(delegat());
                    //используем анонимные функции и лямбда выражения
                    progressBar1.Invoke(new Action(() => { progressBar1.Value++; }));

                    textBox1.Invoke(new Action(() => { textBox1.Text += temp[i]; }));

                    //this.Refresh();
                    System.Threading.Thread.Sleep(10);
                }

            }
        }
    }
}
