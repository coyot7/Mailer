using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mailer
{
    public partial class Form2 : Form
    {
        private Form1 formaa1;

        public Form2(Form1 forma1)
        {
            InitializeComponent();
            formaa1 = forma1; 
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                   textBox1.Text = dialog.FileName;
                   formaa1.zal1 = dialog.FileName;
                   this.textBox1.ReadOnly = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBox2.Text = dialog.FileName;
                formaa1.zal2 = dialog.FileName;
                this.textBox2.ReadOnly = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBox3.Text = dialog.FileName;
                formaa1.zal3 = dialog.FileName;
                this.textBox3.ReadOnly = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBox4.Text = dialog.FileName;
                formaa1.zal4 = dialog.FileName;
                this.textBox4.ReadOnly = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBox5.Text = dialog.FileName;
                formaa1.zal5 = dialog.FileName;
                this.textBox5.ReadOnly = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBox6.Text = dialog.FileName;
                formaa1.zal6 = dialog.FileName;
                this.textBox6.ReadOnly = true;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBox7.Text = dialog.FileName;
                formaa1.zal7 = dialog.FileName;
                this.textBox7.ReadOnly = true;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBox8.Text = dialog.FileName;
                formaa1.zal8 = dialog.FileName;
                this.textBox8.ReadOnly = true;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBox9.Text = dialog.FileName;
                formaa1.zal9 = dialog.FileName;
                this.textBox9.ReadOnly = true;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBox10.Text = dialog.FileName;
                formaa1.zal10 = dialog.FileName;
                this.textBox10.ReadOnly = true;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBox11.Text = dialog.FileName;
                formaa1.zal11 = dialog.FileName;
                this.textBox11.ReadOnly = true;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBox12.Text = dialog.FileName;
                formaa1.zal12 = dialog.FileName;
                this.textBox12.ReadOnly = true;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBox13.Text = dialog.FileName;
                formaa1.zal13 = dialog.FileName;
                this.textBox13.ReadOnly = true;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBox14.Text = dialog.FileName;
                formaa1.zal14 = dialog.FileName;
                this.textBox14.ReadOnly = true;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBox15.Text = dialog.FileName;
                formaa1.zal15 = dialog.FileName;
                this.textBox15.ReadOnly = true;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBox16.Text = dialog.FileName;
                formaa1.zal16 = dialog.FileName;
                this.textBox16.ReadOnly = true;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBox17.Text = dialog.FileName;
                formaa1.zal17 = dialog.FileName;
                this.textBox17.ReadOnly = true;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBox18.Text = dialog.FileName;
                formaa1.zal18 = dialog.FileName;
                this.textBox18.ReadOnly = true;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBox19.Text = dialog.FileName;
                formaa1.zal19 = dialog.FileName;
                this.textBox19.ReadOnly = true;
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBox20.Text = dialog.FileName;
                formaa1.zal20 = dialog.FileName;
                this.textBox20.ReadOnly = true;
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            this.Close();

            if (formaa1.zal1 != null) formaa1.zalIlosc++;
            if (formaa1.zal2 != null) formaa1.zalIlosc++;
            if (formaa1.zal3 != null) formaa1.zalIlosc++;
            if (formaa1.zal4 != null) formaa1.zalIlosc++;
            if (formaa1.zal5 != null) formaa1.zalIlosc++;
            if (formaa1.zal6 != null) formaa1.zalIlosc++;
            if (formaa1.zal7 != null) formaa1.zalIlosc++;
            if (formaa1.zal8 != null) formaa1.zalIlosc++;
            if (formaa1.zal9 != null) formaa1.zalIlosc++;
            if (formaa1.zal10 != null) formaa1.zalIlosc++;
            if (formaa1.zal11 != null) formaa1.zalIlosc++;
            if (formaa1.zal12 != null) formaa1.zalIlosc++;
            if (formaa1.zal13 != null) formaa1.zalIlosc++;
            if (formaa1.zal14 != null) formaa1.zalIlosc++;
            if (formaa1.zal15 != null) formaa1.zalIlosc++;
            if (formaa1.zal16 != null) formaa1.zalIlosc++;
            if (formaa1.zal17 != null) formaa1.zalIlosc++;
            if (formaa1.zal18 != null) formaa1.zalIlosc++;
            if (formaa1.zal19 != null) formaa1.zalIlosc++;
            if (formaa1.zal20 != null) formaa1.zalIlosc++;
            formaa1.Odswiez();
        }
    }
}
