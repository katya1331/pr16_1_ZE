using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace _2zadaniepr16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string[] stroka;
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int y = 0;
            stroka = textBox1.Text.Split('.');
            for (int i = 0; i < stroka.Length; i++)
            {
                if (stroka[i].Contains("/"))
                {
                    y++;
                }
            }
            if (y > 0)
            {
                var digitCount = stroka.Select(s => s.Count(char.IsDigit));
                foreach (var count in digitCount)
                {
                    listBox1.Items.Add(count.ToString());

                }
                string st;
                for (int i = 0; i < stroka.Length; i++)
                {
                    var digits = stroka[i].Where(char.IsDigit);
                    st = "";
                    foreach (var digit in digits)
                    {
                        if (char.IsDigit(digit))
                        {
                            st += digit.ToString();
                        }
                    }
                    listBox1.Items.Add(st.ToString());
                }
            }
            else MessageBox.Show("you need a symvol - (/) !!!!!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var stroka = textBox1.Text
              .TakeWhile(c => c != '/')
             .ToList();
           stroka.ForEach(element => listBox1.Items.Add(element));

        }

        private void button4_Click(object sender, EventArgs e)
        {
            var stroka = textBox1.Text;
            string[] elements = stroka.Split('/');
            if (elements.Length > 1)
            {
                var result = elements[1].Select(c => char.IsUpper(c) ? char.ToLower(c) : char.ToUpper(c)); 
                listBox1.Items.Add(string.Join("", result));
                File.AppendAllText("1.txt", string.Join("", result));
            }
            else
            {
                MessageBox.Show("you need a symvol - (/) !!!!!");
            }
        }
    }
}
