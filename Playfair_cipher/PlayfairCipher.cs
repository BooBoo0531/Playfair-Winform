using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Playfair_cipher
{
    public partial class PlayfairCipher : Form
    {
        private char[,] matrix = new char[5, 5];

        public PlayfairCipher()
        {
            InitializeComponent();
        }

        private void PlayfairCipher_Load(object sender, EventArgs e)
        {
            if (txtMatrix != null)
            {
                txtMatrix.Font = new System.Drawing.Font("Courier New", 14F, System.Drawing.FontStyle.Bold);
                txtMatrix.TextAlign = HorizontalAlignment.Center;
            }

            btnEncrypt.Click += btnEncrypt_Click;
            btnDecrypt.Click += btnDecrypt_Click;
            btnClear.Click += btnClear_Click;
        }

  
        private void txtMatrix_TextChanged(object sender, EventArgs e)
        {
           
        }
        private void GenerateMatrix(string key)
        {
            key = key.ToUpper().Replace("J", "I");
            string alphabet = "ABCDEFGHIKLMNOPQRSTUVWXYZ"; 
            string matrixString = "";
            foreach (char c in key)
            {
                if (char.IsLetter(c) && !matrixString.Contains(c))
                {
                    matrixString += c;
                }
            }
            foreach (char c in alphabet)
            {
                if (!matrixString.Contains(c))
                {
                    matrixString += c;
                }
            }
            int index = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matrix[i, j] = matrixString[index++];
                }
            }

            DisplayMatrix();
        }

        private void DisplayMatrix()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    sb.Append(matrix[i, j] + " ");
                }
                sb.AppendLine();
            }
            txtMatrix.Text = sb.ToString();
        }

        private void FindPosition(char c, out int row, out int col)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (matrix[i, j] == c)
                    {
                        row = i;
                        col = j;
                        return;
                    }
                }
            }
            row = -1;
            col = -1;
        }

        private string PrepareText(string text)
        {
            text = text.ToUpper().Replace("J", "I").Replace(" ", "");
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {
                if (!char.IsLetter(text[i])) continue;

                result.Append(text[i]);

                if (i + 1 < text.Length && char.IsLetter(text[i + 1]))
                {
                    if (text[i] == text[i + 1])
                    {
                        result.Append('X'); 
                    }
                }
            }

            if (result.Length % 2 != 0)
            {
                result.Append('X');
            }

            return result.ToString();
        }

        private string Encrypt(string plaintext, string key)
        {
            GenerateMatrix(key);
            plaintext = PrepareText(plaintext);
            StringBuilder ciphertext = new StringBuilder();

            for (int i = 0; i < plaintext.Length; i += 2)
            {
                char a = plaintext[i];
                char b = plaintext[i + 1];

                FindPosition(a, out int row1, out int col1);
                FindPosition(b, out int row2, out int col2);

                if (row1 == row2) 
                {
                    ciphertext.Append(matrix[row1, (col1 + 1) % 5]);
                    ciphertext.Append(matrix[row2, (col2 + 1) % 5]);
                }
                else if (col1 == col2)
                {
                    ciphertext.Append(matrix[(row1 + 1) % 5, col1]);
                    ciphertext.Append(matrix[(row2 + 1) % 5, col2]);
                }
                else 
                {
                    ciphertext.Append(matrix[row1, col2]);
                    ciphertext.Append(matrix[row2, col1]);
                }
            }

            return ciphertext.ToString();
        }

       
        private string Decrypt(string ciphertext, string key)
        {
            GenerateMatrix(key);
            ciphertext = ciphertext.ToUpper().Replace(" ", "");
            StringBuilder plaintext = new StringBuilder();

            for (int i = 0; i < ciphertext.Length; i += 2)
            {
                if (i + 1 >= ciphertext.Length) break;

                char a = ciphertext[i];
                char b = ciphertext[i + 1];

                FindPosition(a, out int row1, out int col1);
                FindPosition(b, out int row2, out int col2);

                if (row1 == row2)
                {
                    plaintext.Append(matrix[row1, (col1 - 1 + 5) % 5]);
                    plaintext.Append(matrix[row2, (col2 - 1 + 5) % 5]);
                }
                else if (col1 == col2) 
                {
                    plaintext.Append(matrix[(row1 - 1 + 5) % 5, col1]);
                    plaintext.Append(matrix[(row2 - 1 + 5) % 5, col2]);
                }
                else 
                {
                    plaintext.Append(matrix[row1, col2]);
                    plaintext.Append(matrix[row2, col1]);
                }
            }

            return plaintext.ToString();
        }

    
        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            try
            {
                string key = txtKey.Text.Trim();
                string plaintext = txtPlaintext.Text.Trim();

                if (string.IsNullOrEmpty(key))
                {
                    MessageBox.Show("Vui lòng nhập khóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrEmpty(plaintext))
                {
                    MessageBox.Show("Vui lòng nhập văn bản gốc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string ciphertext = Encrypt(plaintext, key);
                txtCiphertext.Text = ciphertext;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            try
            {
                string key = txtKey.Text.Trim();
                string ciphertext = txtCiphertext.Text.Trim();

                if (string.IsNullOrEmpty(key))
                {
                    MessageBox.Show("Vui lòng nhập khóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrEmpty(ciphertext))
                {
                    MessageBox.Show("Vui lòng nhập văn bản mã hóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string plaintext = Decrypt(ciphertext, key);
                txtPlaintext.Text = plaintext;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtKey.Text = "";
            txtPlaintext.Text = "";
            txtCiphertext.Text = "";
            txtMatrix.Text = "";
        }

        private void lblMatrix_Click(object sender, EventArgs e)
        {

        }

        private void txtCiphertext_TextChanged(object sender, EventArgs e)
        {

        }
    }
}