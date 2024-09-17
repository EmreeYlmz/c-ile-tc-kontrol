using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace tckontrol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            string tc = textBox1.Text;
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;

            }

            else if (textBox1.Text.Length == 0)
            {
                if (e.KeyChar == '0')
                {
                    e.Handled = true;
                    errorProvider1.SetError(textBox1, "T.C 0 ile başlamaz");
                }
                else
                    errorProvider1.Clear();
            }
            else if (textBox1.Text.Length == 9)
            {

                int[] dizi = new int[textBox1.Text.Length];
                for (int i = 0; i < textBox1.Text.Length; i++)
                {
                    dizi[i] = (int)char.GetNumericValue(textBox1.Text[i]);
                }

                int ilk = 0;
                for (int i = 0; i <= 8; i += 2)
                {
                    ilk += dizi[i];
                }
                ilk *= 7;

                int son = 0;
                for (int i = 1; i <= 7; i += 2)
                {
                    son += dizi[i];
                }

                int hane_10 = (ilk - son) % 10;
                if (e.KeyChar.ToString() != hane_10.ToString())
                {
                    e.Handled = true;
                    errorProvider1.SetError(textBox1, "10.hane yanlış");
                }
                else
                {
                    e.Handled = false;
                    errorProvider1.Clear();
                }

            }
            else if (textBox1.Text.Length == 10)
            {

                int[] dizi = new int[textBox1.Text.Length];
                for (int i = 0; i < textBox1.Text.Length; i++)
                {
                    dizi[i] = (int)char.GetNumericValue(textBox1.Text[i]);
                }
                int toplam = 0;
                for (int i = 0; i <= 9; i++)
                {
                    toplam += dizi[i];
                }

                int hane_11 = toplam % 10;
                if (e.KeyChar.ToString() != hane_11.ToString())
                {
                    e.Handled = true;
                    errorProvider1.SetError(textBox1, "11.hane yanlış");
                }
                else
                    errorProvider1.Clear();
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Left += 5;
            if (label1.Left > 300)
                label1.Left = -70;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (errorProvider1.GetError(textBox1) == string.Empty && textBox1.Text.Length == 11)
            {
                MessageBox.Show("T.C. Kimlik Numarası Doğru", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("T.C. Kimlik Numarasında Hata Var", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }
    }



    }

