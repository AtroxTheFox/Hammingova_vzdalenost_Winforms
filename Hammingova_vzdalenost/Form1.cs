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

        // Metoda, která se zavolá po kliknutí na tlačítko
        private void button1_Click(object sender, EventArgs e)
        {
            // Načtení vstupu z textových polí
            string input1 = textBox1.Text;
            string input2 = textBox2.Text;

            // Kontrola, zda jsou vstupy prázdné
            if (string.IsNullOrEmpty(input1) || string.IsNullOrEmpty(input2))
            {
                MessageBox.Show("Zadejte celé číslo do obou textových polí.");
                return;
            }

            // Kontrola, zda jsou vstupy celá čísla
            if (!IsInteger(input1) || !IsInteger(input2))
            {
                MessageBox.Show("Zadejte pouze celá čísla.");
                return;
            }

            // Převod celých čísel na binární
            string binary1 = Convert.ToString(int.Parse(input1), 2);
            string binary2 = Convert.ToString(int.Parse(input2), 2);

            //Doplnění kratšího binárního řetězce nulami na začátek (ošetření pádu programu, když je jedna hodnota kratší než druhá)
            int maxLength = Math.Max(binary1.Length, binary2.Length);
            binary1 = binary1.PadLeft(maxLength, '0');
            binary2 = binary2.PadLeft(maxLength, '0');

            // Proměnná pro výpočet Hammingovy vzdálenosti
            int hammingDistance = 0;

            // Výpočet Hammingovy vzdálenosti
            for (int i = 0; i < binary1.Length; i++)
            {
                if (binary1[i] != binary2[i])
                {
                    hammingDistance++;
                }
            }

            // Zobrazení výsledku
            MessageBox.Show($"První číslo v binární formě: " +
                $"{binary1}\nDruhé číslo v binární formě: {binary2}\nHammingova vzdálenost je: {hammingDistance}");
        }

        // Metoda pro kontrolu, jestli je vstup celé číslo
        private bool IsInteger(string input)
        {
            return Regex.IsMatch(input, @"^\d+$");
        }
    }
}