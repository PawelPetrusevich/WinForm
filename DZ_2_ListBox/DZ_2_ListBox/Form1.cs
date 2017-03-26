using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DZ_2_ListBox
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();

            List<Person> person = new List<Person>();

            Person a = new Person("Pawel", "Petrusiwitch", "Victorovich", "29999");
            person.Add(a);
            listBox1.DataSource = person;
            listBox1.ValueMember = "name";

            

            
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Person temp = (Person)listBox1.SelectedItem;
            tb_name.Text = temp.Name;
            tb_lastname.Text = temp.LastName;
            tb_fathername.Text = temp.FatherName;
            tb_telefon.Text = temp.Number;
        }

        private void b_add_Click(object sender, EventArgs e)
        {

            if (tb_name.Text !=null && tb_lastname.Text !=null &&  tb_fathername.Text != null && tb_telefon.Text !=null)
            {
                
                
                

            }
            else
            {
                MessageBox.Show("Не все поля заполнены");
            }
        }
    }
}
