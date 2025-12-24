namespace Playfair_cipher
{
    partial class PlayfairCipher
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblKey = new Label();
            txtKey = new TextBox();
            txtPlaintext = new TextBox();
            lblPlaintext = new Label();
            txtCiphertext = new TextBox();
            lblCiphertext = new Label();
            lblMatrix = new Label();
            txtMatrix = new TextBox();
            btnEncrypt = new Button();
            btnDecrypt = new Button();
            btnClear = new Button();
            SuspendLayout();
            // 
            // lblKey
            // 
            lblKey.BackColor = SystemColors.ActiveCaption;
            lblKey.Font = new Font("Arial Narrow", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKey.ForeColor = SystemColors.ActiveCaptionText;
            lblKey.Location = new Point(12, 46);
            lblKey.Name = "lblKey";
            lblKey.Size = new Size(101, 31);
            lblKey.TabIndex = 1;
            lblKey.Text = "Key";
            lblKey.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtKey
            // 
            txtKey.AcceptsReturn = true;
            txtKey.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtKey.BackColor = SystemColors.ButtonFace;
            txtKey.Location = new Point(129, 46);
            txtKey.Name = "txtKey";
            txtKey.Size = new Size(761, 31);
            txtKey.TabIndex = 2;
            // 
            // txtPlaintext
            // 
            txtPlaintext.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtPlaintext.BackColor = SystemColors.ButtonFace;
            txtPlaintext.Location = new Point(129, 103);
            txtPlaintext.Multiline = true;
            txtPlaintext.Name = "txtPlaintext";
            txtPlaintext.ScrollBars = ScrollBars.Vertical;
            txtPlaintext.Size = new Size(761, 72);
            txtPlaintext.TabIndex = 3;
            // 
            // lblPlaintext
            // 
            lblPlaintext.BackColor = SystemColors.ActiveCaption;
            lblPlaintext.Font = new Font("Verdana", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblPlaintext.Location = new Point(12, 120);
            lblPlaintext.Name = "lblPlaintext";
            lblPlaintext.Size = new Size(101, 38);
            lblPlaintext.TabIndex = 4;
            lblPlaintext.Text = "Plaintext";
            lblPlaintext.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtCiphertext
            // 
            txtCiphertext.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtCiphertext.BackColor = SystemColors.ButtonFace;
            txtCiphertext.Location = new Point(129, 429);
            txtCiphertext.Multiline = true;
            txtCiphertext.Name = "txtCiphertext";
            txtCiphertext.ScrollBars = ScrollBars.Vertical;
            txtCiphertext.Size = new Size(761, 72);
            txtCiphertext.TabIndex = 6;
            txtCiphertext.TextChanged += txtCiphertext_TextChanged;
            // 
            // lblCiphertext
            // 
            lblCiphertext.BackColor = SystemColors.ActiveCaption;
            lblCiphertext.Font = new Font("Verdana", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblCiphertext.Location = new Point(12, 446);
            lblCiphertext.Name = "lblCiphertext";
            lblCiphertext.Size = new Size(101, 38);
            lblCiphertext.TabIndex = 8;
            lblCiphertext.Text = "Ciphertext";
            lblCiphertext.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMatrix
            // 
            lblMatrix.BackColor = SystemColors.ActiveCaption;
            lblMatrix.Font = new Font("Arial Narrow", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMatrix.Location = new Point(12, 256);
            lblMatrix.Name = "lblMatrix";
            lblMatrix.Size = new Size(101, 38);
            lblMatrix.TabIndex = 9;
            lblMatrix.Text = "Matrix 5x5";
            lblMatrix.TextAlign = ContentAlignment.MiddleCenter;
            lblMatrix.Click += lblMatrix_Click;
            // 
            // txtMatrix
            // 
            txtMatrix.Anchor = AnchorStyles.Left;
            txtMatrix.BackColor = SystemColors.ButtonFace;
            txtMatrix.Location = new Point(129, 195);
            txtMatrix.Multiline = true;
            txtMatrix.Name = "txtMatrix";
            txtMatrix.ReadOnly = true;
            txtMatrix.Size = new Size(210, 210);
            txtMatrix.TabIndex = 10;
            txtMatrix.TextChanged += txtMatrix_TextChanged;
            // 
            // btnEncrypt
            // 
            btnEncrypt.BackColor = Color.FromArgb(192, 192, 255);
            btnEncrypt.Location = new Point(429, 267);
            btnEncrypt.Name = "btnEncrypt";
            btnEncrypt.Size = new Size(129, 47);
            btnEncrypt.TabIndex = 11;
            btnEncrypt.Text = "Encrypt";
            btnEncrypt.UseVisualStyleBackColor = false;
            // 
            // btnDecrypt
            // 
            btnDecrypt.BackColor = Color.FromArgb(192, 192, 255);
            btnDecrypt.Location = new Point(564, 267);
            btnDecrypt.Name = "btnDecrypt";
            btnDecrypt.Size = new Size(129, 47);
            btnDecrypt.TabIndex = 12;
            btnDecrypt.Text = "Decrypt";
            btnDecrypt.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(255, 128, 128);
            btnClear.Location = new Point(771, 267);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(129, 47);
            btnClear.TabIndex = 13;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // PlayfairCipher
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._0f6d6f9ae4ae58928f7ac10b4f174bb3;
            ClientSize = new Size(951, 557);
            Controls.Add(btnClear);
            Controls.Add(btnDecrypt);
            Controls.Add(btnEncrypt);
            Controls.Add(txtMatrix);
            Controls.Add(lblMatrix);
            Controls.Add(lblCiphertext);
            Controls.Add(txtCiphertext);
            Controls.Add(lblPlaintext);
            Controls.Add(txtPlaintext);
            Controls.Add(txtKey);
            Controls.Add(lblKey);
            Name = "PlayfairCipher";
            Text = "PlayfairCipher";
            Load += PlayfairCipher_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblKey;
        private TextBox txtKey;
        private TextBox txtPlaintext;
        private Label lblPlaintext;
        private TextBox txtCiphertext;
        private Label lblCiphertext;
        private Label lblMatrix;
        private TextBox txtMatrix;
        private Button btnEncrypt;
        private Button btnDecrypt;
        private Button btnClear;
    }
}
