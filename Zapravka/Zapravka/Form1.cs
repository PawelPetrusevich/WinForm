using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zapravka.CS;

namespace Zapravka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            List<Fuel> fuelList = new List<Fuel> 
            {
                new Fuel{Name="DT",Price=1.1M},
                new Fuel{Name="AI-80",Price=2.2M},
                new Fuel{Name="AI-92",Price= 3.3M},
                new Fuel{Name="AI-95",Price= 4.4M}
            };

            fuel_comboBox.DataSource = fuelList;
            fuel_comboBox.DisplayMember = "Name";
            fuel_comboBox.ValueMember = "Price";
            priceFuel_textBox.DataBindings.Add(new Binding("Text",fuelList,"Price"));

            //if (count_radioButton.Checked)
            //{
            //    fuelPrice_groupBox.Text = "К оплате";
            //}
            //else
            //{
            //    fuelPrice_groupBox.Text = "К выдаче";
            //}
            
            

        }

        private void fuel_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void count_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            fuelPrice_groupBox.Text = "К оплате";
            summa_textBox.Enabled = false;
            count_textBox.Enabled = true;
            
            
        }

        private void summa_radiobutton_CheckedChanged(object sender, EventArgs e)
        {
            fuelPrice_groupBox.Text = "Количество топлива";
            summa_textBox.Enabled = true;
            count_textBox.Enabled = false;
        }

        private void count_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((TextBox)sender).Text.Contains('-'))
            {
                if (!((Char.IsDigit(e.KeyChar) && ((TextBox)sender).SelectionStart > 0) || e.KeyChar == (char)Keys.Back))
                    e.Handled = true;

            }

            else if (!(Char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || (e.KeyChar == '-' && ((TextBox)sender).SelectionStart == 0)))
                e.Handled = true;
        }

        
    }
}
