using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lr5vesna
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                MessageBox.Show("Напишите в поле ввода строку, которую хотите добавить.");
            }
            else
            {
                listBox1.Items.Add(textBox1.Text);
                textBox1.Clear();
                label1.Text = "Строка: ";
            }
            
  
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                int index = listBox1.SelectedIndex;
                listBox1.Items.RemoveAt(index);
                label1.Text = "Строка: ";
            }
            catch (Exception)
            {

                MessageBox.Show("Выберите строку, чтобы удалить.");
            }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            label1.Text = "Строка: ";
            string str = (string)listBox1.SelectedItem;
            string[] mas = str.Split(' ');
            string remstr;
            for (int i = 0; i < mas.Length; i++)
            {
                remstr = mas[i];
                for (int j = 0; j < remstr.Length; j++)
                {

                    if (char.IsDigit(remstr[j]) == false && char.IsPunctuation(remstr[j]) == false)
                    {
                        StringBuilder someString = new StringBuilder(remstr);
                        someString.Remove(j, 1);
                        mas[i] = someString.ToString();
                        break;
                    }

                }
            }
            label1.Text += String.Join(" ", mas);
        }
    }
}
