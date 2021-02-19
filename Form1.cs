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

namespace project1
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
            richTextBox11.Text = File.ReadAllText(@"EnRuDict.dat", Encoding.Default);
            richTextBox12.Text = File.ReadAllText(@"RuEnDict.dat", Encoding.Default);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void new_size(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e) // RusEn
        {
            bool ok = true;
            foreach (char ch in textBox3.Text)
                if (ch > 'я' || ch < 'а') ok = false;
            foreach (char ch in textBox4.Text)
                if (ch > 'z' || ch < 'a') ok = false;
            if (!ok)
            {
                MessageBox.Show("Некорректный ввод данных");
            }
            else File.AppendAllText(@"RuEnDict.dat", textBox3.Text + " -  " + textBox4.Text + '\n', Encoding.Default);

            richTextBox12.Text = File.ReadAllText(@"RuEnDict.dat", Encoding.Default);
            textBox4.Text = ""; textBox3.Text = "";


        }

        private void button1_Click(object sender, EventArgs e)// EnRus
        {
            bool ok = true;
            foreach (char ch in textBox2.Text)
                if (ch > 'я' || ch < 'а') 
                    ok = false;
            foreach (char ch in textBox1.Text)
                if (ch > 'z' || ch < 'a') 
                    ok = false;
            if (!ok)
            {
                MessageBox.Show("Некорректный ввод данных");
            }
            else File.AppendAllText(@"EnRuDict.dat", textBox1.Text + " - " + textBox2.Text + '\n', Encoding.Default);


            richTextBox11.Text = File.ReadAllText(@"EnRuDict.dat", Encoding.Default);
            textBox1.Text = ""; textBox2.Text = "";
        }

        

        private void richTextBox11_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void richTextBox12_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void deleteTxtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            File.WriteAllText(@"RuEnDict.dat", "", Encoding.Default);
            File.WriteAllText(@"EnRuDict.dat", "", Encoding.Default);
            richTextBox11.Text = "";
            richTextBox12.Text = "";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("  Группа : 382008-1 \n  Выполнил: Даниил Булгаков\n  Небольшой русско-английский и английско-русский\n  самозаполняемый словарь ");

        }
    }
}
