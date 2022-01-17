
namespace Agirman_Cryptage
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcrypt = new System.Windows.Forms.TextBox();
            this.txtdecrypt = new System.Windows.Forms.TextBox();
            this.cle = new System.Windows.Forms.TextBox();
            this.btnDecryptNet = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCrypter = new System.Windows.Forms.Button();
            this.btnDecrypter = new System.Windows.Forms.Button();
            this.btnSortir = new System.Windows.Forms.Button();
            this.btnCryptNet = new System.Windows.Forms.Button();
            this.txtCrypté = new System.Windows.Forms.TextBox();
            this.txtDecrypté = new System.Windows.Forms.TextBox();
            this.CleDecrypt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Texte à crypter:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(643, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Texte à décrypter:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Clé:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtcrypt
            // 
            this.txtcrypt.Location = new System.Drawing.Point(37, 106);
            this.txtcrypt.Name = "txtcrypt";
            this.txtcrypt.Size = new System.Drawing.Size(235, 22);
            this.txtcrypt.TabIndex = 6;
            // 
            // txtdecrypt
            // 
            this.txtdecrypt.Location = new System.Drawing.Point(648, 106);
            this.txtdecrypt.Name = "txtdecrypt";
            this.txtdecrypt.Size = new System.Drawing.Size(235, 22);
            this.txtdecrypt.TabIndex = 7;
            // 
            // cle
            // 
            this.cle.Location = new System.Drawing.Point(37, 281);
            this.cle.Name = "cle";
            this.cle.Size = new System.Drawing.Size(235, 22);
            this.cle.TabIndex = 8;
            // 
            // btnDecryptNet
            // 
            this.btnDecryptNet.BackColor = System.Drawing.Color.Red;
            this.btnDecryptNet.Location = new System.Drawing.Point(819, 359);
            this.btnDecryptNet.Name = "btnDecryptNet";
            this.btnDecryptNet.Size = new System.Drawing.Size(154, 54);
            this.btnDecryptNet.TabIndex = 10;
            this.btnDecryptNet.Text = "Décrypter-.Net";
            this.btnDecryptNet.UseVisualStyleBackColor = false;
            this.btnDecryptNet.Click += new System.EventHandler(this.btnDecryptNet_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 29);
            this.label4.TabIndex = 12;
            this.label4.Text = "Texte crypté:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(643, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 29);
            this.label5.TabIndex = 14;
            this.label5.Text = "Texte décrypté";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(643, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 29);
            this.label6.TabIndex = 15;
            this.label6.Text = "Clé:";
            // 
            // btnCrypter
            // 
            this.btnCrypter.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCrypter.Location = new System.Drawing.Point(63, 358);
            this.btnCrypter.Name = "btnCrypter";
            this.btnCrypter.Size = new System.Drawing.Size(132, 55);
            this.btnCrypter.TabIndex = 19;
            this.btnCrypter.Text = "Crypter-Personnel";
            this.btnCrypter.UseVisualStyleBackColor = false;
            this.btnCrypter.Click += new System.EventHandler(this.btnCrypter_Click);
            // 
            // btnDecrypter
            // 
            this.btnDecrypter.BackColor = System.Drawing.Color.SteelBlue;
            this.btnDecrypter.Location = new System.Drawing.Point(623, 358);
            this.btnDecrypter.Name = "btnDecrypter";
            this.btnDecrypter.Size = new System.Drawing.Size(151, 54);
            this.btnDecrypter.TabIndex = 20;
            this.btnDecrypter.Text = "Decrypter-Personnel";
            this.btnDecrypter.UseVisualStyleBackColor = false;
            this.btnDecrypter.Click += new System.EventHandler(this.btnDecrypter_Click);
            // 
            // btnSortir
            // 
            this.btnSortir.BackColor = System.Drawing.Color.Lime;
            this.btnSortir.Location = new System.Drawing.Point(418, 427);
            this.btnSortir.Name = "btnSortir";
            this.btnSortir.Size = new System.Drawing.Size(135, 51);
            this.btnSortir.TabIndex = 21;
            this.btnSortir.Text = "Sortir";
            this.btnSortir.UseVisualStyleBackColor = false;
            this.btnSortir.Click += new System.EventHandler(this.btnSortir_Click);
            // 
            // btnCryptNet
            // 
            this.btnCryptNet.BackColor = System.Drawing.Color.Red;
            this.btnCryptNet.Location = new System.Drawing.Point(252, 358);
            this.btnCryptNet.Name = "btnCryptNet";
            this.btnCryptNet.Size = new System.Drawing.Size(142, 54);
            this.btnCryptNet.TabIndex = 22;
            this.btnCryptNet.Text = "Crypter .Net";
            this.btnCryptNet.UseVisualStyleBackColor = false;
            this.btnCryptNet.Click += new System.EventHandler(this.btnCryptNet_Click);
            // 
            // txtCrypté
            // 
            this.txtCrypté.Location = new System.Drawing.Point(41, 189);
            this.txtCrypté.Name = "txtCrypté";
            this.txtCrypté.Size = new System.Drawing.Size(231, 22);
            this.txtCrypté.TabIndex = 23;
            // 
            // txtDecrypté
            // 
            this.txtDecrypté.Location = new System.Drawing.Point(648, 191);
            this.txtDecrypté.Name = "txtDecrypté";
            this.txtDecrypté.Size = new System.Drawing.Size(235, 22);
            this.txtDecrypté.TabIndex = 24;
            // 
            // CleDecrypt
            // 
            this.CleDecrypt.Location = new System.Drawing.Point(648, 281);
            this.CleDecrypt.Name = "CleDecrypt";
            this.CleDecrypt.Size = new System.Drawing.Size(223, 22);
            this.CleDecrypt.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 514);
            this.Controls.Add(this.CleDecrypt);
            this.Controls.Add(this.txtDecrypté);
            this.Controls.Add(this.txtCrypté);
            this.Controls.Add(this.btnCryptNet);
            this.Controls.Add(this.btnSortir);
            this.Controls.Add(this.btnDecrypter);
            this.Controls.Add(this.btnCrypter);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDecryptNet);
            this.Controls.Add(this.cle);
            this.Controls.Add(this.txtdecrypt);
            this.Controls.Add(this.txtcrypt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcrypt;
        private System.Windows.Forms.TextBox txtdecrypt;
        private System.Windows.Forms.TextBox cle;
        private System.Windows.Forms.Button btnDecryptNet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCrypter;
        private System.Windows.Forms.Button btnDecrypter;
        private System.Windows.Forms.Button btnSortir;
        private System.Windows.Forms.Button btnCryptNet;
        private System.Windows.Forms.TextBox txtCrypté;
        private System.Windows.Forms.TextBox txtDecrypté;
        private System.Windows.Forms.TextBox CleDecrypt;
    }
}

