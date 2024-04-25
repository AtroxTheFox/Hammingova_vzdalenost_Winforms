using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Hammingova_vzdalenost
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input1 = textBox1.Text;
            string input2 = textBox2.Text;

            if (string.IsNullOrEmpty(input1) || string.IsNullOrEmpty(input2))
            {
                MessageBox.Show("Zadejte celé číslo do obou textových polí.");
                return;
            }

            if (!IsInteger(input1) || !IsInteger(input2))
            {
                MessageBox.Show("Zadejte pouze celá čísla.");
                return;
            }

            string binary1 = Convert.ToString(int.Parse(input1), 2);
            string binary2 = Convert.ToString(int.Parse(input2), 2);


            int hammingDistance = 0;

            for (int i = 0; i < binary1.Length; i++)
            {
                if (binary1[i] != binary2[i])
                {
                    hammingDistance++;
                }
            }

            MessageBox.Show($"První číslo v binární formě: {binary1}\nDruhé číslo v binární formě: {binary2}\nHammingova vzdálenost je: {hammingDistance}");
        }

        private bool IsInteger(string input)
        {
            return Regex.IsMatch(input, @"^\d+$");
        }
    }

}
