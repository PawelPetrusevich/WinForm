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
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                // цифра
                return;
            }


            if (e.KeyChar == '-')
            {
                if (count_textBox.Text.IndexOf('-') != -1)
                {

                    e.Handled = true;
                }
                return;
            }
            if (e.KeyChar == '-')
            {
                return;
            }



            if (e.KeyChar == '.')
            {
                // точку заменим запятой
                e.KeyChar = ',';
            }

            if (e.KeyChar == ',')
            {
                if (count_textBox.Text.IndexOf(',') != -1)
                {
                    // запятая уже есть в поле редактирования
                    e.Handled = true;
                }
                return;
            }

            
            // остальные символы запрещены
            e.Handled = true;
        }

        private void count_textBox_TextChanged(object sender, EventArgs e)
        {
            int countFuel = int.Parse( count_textBox.Text);
            decimal temp = ((decimal)countFuel) * decimal.Parse(priceFuel_textBox.Text);
            oplata_textBox.Text = temp.ToString();
        }

        private void summa_textBox_TextChanged(object sender, EventArgs e)
        {

            if (summa_textBox.Text != null)
            {
                decimal summFuel = decimal.Parse(summa_textBox.Text);
                decimal temp = decimal.Parse(summa_textBox.Text) / decimal.Parse(priceFuel_textBox.Text);
                oplata_textBox.Text = temp.ToString(); 
            }
        }

        private void gamburger_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (gamburger_checkBox.Checked)
            {
                Gamburger_count_textBox.Enabled = true;
            }
            else
            {
                Gamburger_count_textBox.Enabled = false;
                Gamburger_count_textBox.Text = "0";
            }
        }

        private void cola_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (cola_checkBox.Checked)
            {
                Cola_count_textBox.Enabled = true;

            }
            else
            {
                Cola_count_textBox.Enabled = false;
                Cola_count_textBox.Text = "0";
            }
        }

        private void hotDog_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (hotDog_checkBox.Checked)
            {
                hot_count_textBox.Enabled = true;
            }
            else
            {
                hot_count_textBox.Enabled = false;
                hot_count_textBox.Text = "0";
            }
        }

        private void Cola_count_textBox_TextChanged(object sender, EventArgs e)
        {
            decimal temp_gamburger = ((decimal.Parse( Gamburger_count_textBox.Text))*(decimal.Parse(gamburger_price_textBox.Text)));
            decimal temp_hot = (decimal.Parse(hot_count_textBox.Text)) * (decimal.Parse(hot_price_textBox.Text));
            decimal temp_cola = (decimal.Parse(Cola_count_textBox.Text)) * (decimal.Parse(cola_price_textBox.Text));
            decimal temp = temp_cola + temp_gamburger + temp_hot;
            kafe_oplata_textBox.Text = temp.ToString();
        }

        private void all_button_Click(object sender, EventArgs e)
        {
            decimal temp = (decimal.Parse(kafe_oplata_textBox.Text)) + (decimal.Parse(oplata_textBox.Text));
            all_textBox.Text = temp.ToString();
        }

        
    }
}
