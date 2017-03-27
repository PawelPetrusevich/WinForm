using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace DZ_2_ListBox
{
    public partial class Form1 : Form
    {
        BindingList<Person> person = new BindingList<Person>();


        public Form1()
        {
            InitializeComponent();

            //List<Person> person = new List<Person>();

            Person a = new Person("Pawel", "Petrusiwitch", "Victorovich", "29999");
            person.Add(a);
            //listBox1.Items.Add(a);
            //listBox1.DisplayMember = "name";
            listBox1.DataSource = person;
            listBox1.ValueMember = "name";
            





        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listBox1.SelectedItem!=null)
            {
                Person temp = (Person)listBox1.SelectedItem;
                tb_name.Text = temp.Name;
                tb_lastname.Text = temp.LastName;
                tb_fathername.Text = temp.FatherName;
                tb_telefon.Text = temp.Number;
            }
        }

        private void b_add_Click(object sender, EventArgs e)
        {
            

            if ((tb_name.Text !="") && (tb_lastname.Text !="") &&  (tb_fathername.Text != "") && (tb_telefon.Text !=""))
            {
                //listBox1.Items.Add(new Person(tb_name.Text, tb_lastname.Text, tb_fathername.Text, tb_telefon.Text));
                person.Add(new Person(tb_name.Text, tb_lastname.Text, tb_fathername.Text, tb_telefon.Text));
                //listBox1.DataSource = null;
                //listBox1.DataSource = person;
                //listBox1.ValueMember = "name";
                //listBox1.Refresh();




            }
            else
            {
                MessageBox.Show("Не все поля заполнены");
            }
        }

        private void b_remove_Click(object sender, EventArgs e)
        {
            person.Remove((Person)listBox1.SelectedItem);
        }

        private void b_fiks_Click(object sender, EventArgs e)
        {
            //не реализована
            //if (listBox1.SelectedItem!=null)
            //{
            //    Person temp = (Person)listBox1.SelectedItem;
            //    temp.Name = tb_name.Text;
            //    temp.LastName = tb_lastname.Text;
            //    temp.FatherName = tb_fathername.Text;
            //    temp.Number = tb_telefon.Text;

            //}
            MessageBox.Show("Не реализована","Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void bt_xml_Click(object sender, EventArgs e)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(BindingList<Person>));
            using (FileStream fs = new FileStream("data.xml",FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, person);
            }
        }

        private void bt_uotXML_Click(object sender, EventArgs e)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(BindingList<Person>));
            using (FileStream fs = new FileStream("data.xml",FileMode.Open))
            {
                BindingList<Person> temp = (BindingList<Person>)formatter.Deserialize(fs);
                foreach (var item in temp)
                {
                    person.Add(item);
                }
            }
        }
    }
}
