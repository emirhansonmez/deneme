using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace banka_otomasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void Uyari()
        {
            MessageBox.Show("Boş Geçilemez");
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Nakit");
            comboBox1.Items.Add("HalkKart");
            comboBox1.Items.Add("VakıfKart");
            comboBox1.Items.Add("ZiraatKart");
            comboBox1.Items.Add("Diğer Kartlar");
            comboBox2.Items.Add("Tek Çekim");
            comboBox2.Items.Add("2");
            comboBox2.Items.Add("3");
            comboBox2.Items.Add("4");
            comboBox2.Items.Add("5");
            comboBox2.Items.Add("6");

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)&&!char.IsSeparator(e.KeyChar);
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                Uyari();
                textBox1.Focus();
            }
            textBox1.BackColor = Color.White;

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Yellow;
        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                Uyari();
                comboBox1.Focus();
            }
            comboBox1.BackColor = Color.White;
        }

        private void comboBox1_Enter(object sender, EventArgs e)
        {
            comboBox1.BackColor = Color.Yellow;
        }

        private void comboBox2_Leave(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem == null)
            {
                Uyari();
                comboBox2.Focus();
            }
            comboBox2.BackColor = Color.White;
        }

        private void comboBox2_Enter(object sender, EventArgs e)
        {
            comboBox2.BackColor = Color.Yellow;
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                Uyari();
                textBox2.Focus();
            }
            textBox2.BackColor = Color.White;
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.Yellow;
        }

        private void maskedTextBox1_Leave(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text == "")
            {
                Uyari();
                maskedTextBox1.Focus();
            }
            maskedTextBox1.BackColor = Color.White;
        }

        private void maskedTextBox1_Enter(object sender, EventArgs e)
        {
            maskedTextBox1.BackColor = Color.Yellow;
        }
        public double Hesapla(double tutar)
        {
            if (comboBox1.SelectedItem.ToString() == "HalkKart" && comboBox2.SelectedItem.ToString() == "3")
            {
                return tutar / 3;
            }
            else if (comboBox1.SelectedItem.ToString() == "VakıfKart" && comboBox2.SelectedItem.ToString() == "4")
            {
                return tutar / 4;
            }
            else if (comboBox1.SelectedItem.ToString() == "ZiraatKart" && comboBox2.SelectedItem.ToString() == "5")
            {
                return tutar / 5;
            }
            else if (comboBox2.SelectedItem.ToString() == "Tek Çekim" || comboBox1.SelectedItem.ToString() == "Nakit")
            {
                return tutar;
            }
            else if (comboBox2.SelectedItem.ToString() == "2")
            {
                for (int i = 0; i < 2; i++)
                {
                    tutar += tutar * (double)2 / (double)100;
                }
                return tutar / 2;
            }
            else if (comboBox2.SelectedItem.ToString() == "3")
            {
                for (int i = 0; i < 3; i++)
                {
                    tutar += tutar * (double)2 / (double)100;
                }
                return tutar / 3;
            }
            else if (comboBox2.SelectedItem.ToString() == "4")
            {
                for (int i = 0; i < 4; i++)
                {
                    tutar += tutar * (double)2 / (double)100;
                }
                return tutar / 4;
            }
            else if (comboBox2.SelectedItem.ToString() == "5")
            {
                for (int i = 0; i < 5; i++)
                {
                    tutar += tutar * (double)2 / (double)100;
                }
                return tutar / 5;
            }
            else if (comboBox2.SelectedItem.ToString() == "6")
            {
                for (int i = 0; i < 6; i++)
                {
                    tutar += tutar * (double)2 / (double)100;
                }
                return tutar / 6;
            }
            else
                return 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Seçiminiz:" + comboBox1.SelectedItem.ToString() +
                "\nTaksit Sayısı:" + comboBox2.SelectedItem.ToString() +
                "\nAylık:"+Hesapla(Convert.ToDouble(textBox1.Text)).ToString()+ "olarak ödenecektir." +
                "\nTarih:" + dateTimePicker1.Value.ToLongDateString() +
                "\nSaat:" + DateTime.Now.ToLongTimeString());

        }
    }
}
