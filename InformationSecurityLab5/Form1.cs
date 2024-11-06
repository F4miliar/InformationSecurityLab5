using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InformationSecurityLab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonEncrypt_Click(object sender, EventArgs e)
        {
            textBoxEncrypted.Text = Scytale(ReadFile("Decrypted.txt"), (int)numericUpDownScytale.Value);
        }

        private string Scytale(string text, int columns)
        {
            string encrypted = Crypto(text, columns);
            encrypted = encrypted.Replace("\0", " ");
    
            WriteFile(encrypted);
            return encrypted;
        }

        private static string Crypto(string text, int columns)
        {
            int rows = (int)Math.Ceiling(((double)text.Length / (double)columns));
            char[,] matrix = new char[rows, columns];

            int currentColumn = 0;
            int currentRow = 0;
            foreach (char c in text)
            {
                matrix[currentRow, currentColumn] = c;
                currentColumn++;
                if (currentColumn == columns)
                {
                    currentColumn = 0;
                    currentRow++;
                }
            }
            string encrypted = "";
            for (int i = 0; i < columns; i++)
                for (int j = 0; j < rows; j++)
                    encrypted += matrix[j, i];

            return encrypted;
        }

        private string ReadFile(string url)
        {
            StreamReader reader;
            string text = "";
            try
            {
                reader = new StreamReader(url);

                text = reader.ReadToEnd();

                reader.Close();
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return text;
        }

        private string WriteFile(string file)
        {
            string text = "";
            try
            {
                string path = "Encrypted.txt";

                File.WriteAllText(path, file);
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return text;
        }

        private void buttonRead_Click(object sender, EventArgs e)
        {
            textBoxDecrypted.Text = ReadFile("Decrypted.txt").Replace("\0", String.Empty);
            numericUpDownScytale.Maximum = textBoxDecrypted.Text.Length;
        }

        private void buttonDecrypt_Click(object sender, EventArgs e)
        {
            textBoxEncrypted.Text = ScytaleDecrypt(ReadFile("Encrypted.txt"), (int)numericUpDownScytale.Value);
        }

        private string ScytaleDecrypt(string text, int columns)
        {
            string decrypted = "";

            int rows = (int)Math.Ceiling(((double)text.Length / (double)columns));
            for (int i = 0; i < rows; i++)
            {
                for (int j = i; j < text.Length; j+= rows)
                {
                    decrypted += text[j];
                }
            }

            WriteFile(decrypted.Replace("\0", String.Empty));
            return decrypted;
        }
    }
}
