using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agirman_Cryptage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string hash = "Xebat";
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void btnCrypter_Click(object sender, EventArgs e)
        {
            StringBuilder s = new StringBuilder(txtcrypt.Text);
            string key = cle.Text;
            CryptagePerso.VigenereCryptage(ref s, key);
            txtCrypté.Text = Convert.ToString(s);
        }

        private void btnDecrypter_Click(object sender, EventArgs e)
        {
            StringBuilder s = new StringBuilder(txtdecrypt.Text);
            string key = CleDecrypt.Text;
            CryptagePerso.VigenereDecryptage(ref s, key);
            txtDecrypté.Text = Convert.ToString(s);
        }

        private void btnSortir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnCryptNet_Click(object sender, EventArgs e)
        {
            byte[] data = UTF8Encoding.UTF8.GetBytes(txtcrypt.Text);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
               
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateEncryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    txtCrypté.Text = Convert.ToBase64String(results, 0, results.Length);
                }
            }
        }

        private void btnDecryptNet_Click(object sender, EventArgs e)
        {
           
            byte[] data = Convert.FromBase64String(txtCrypté.Text);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
              
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateDecryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    txtDecrypté.Text = UTF8Encoding.UTF8.GetString(results);
                }
            }
        }
    }
}
