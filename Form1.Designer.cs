namespace Test
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxMessage = new TextBox();
            label1 = new Label();
            textBoxKey = new TextBox();
            label2 = new Label();
            buttonCryptMessage = new Button();
            labelEncrypt = new Label();
            buttonAttackForceBrute = new Button();
            buttonDecrypt = new Button();
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            buttonIC = new Button();
            textBoxEncrypted = new TextBox();
            buttonFindKeyWithMIC = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBoxMessage
            // 
            textBoxMessage.Location = new Point(157, 34);
            textBoxMessage.Name = "textBoxMessage";
            textBoxMessage.Size = new Size(267, 23);
            textBoxMessage.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(92, 37);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 1;
            label1.Text = "Message";
            // 
            // textBoxKey
            // 
            textBoxKey.Location = new Point(157, 76);
            textBoxKey.Name = "textBoxKey";
            textBoxKey.Size = new Size(267, 23);
            textBoxKey.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(92, 79);
            label2.Name = "label2";
            label2.Size = new Size(26, 15);
            label2.TabIndex = 1;
            label2.Text = "Key";
            // 
            // buttonCryptMessage
            // 
            buttonCryptMessage.Location = new Point(439, 34);
            buttonCryptMessage.Name = "buttonCryptMessage";
            buttonCryptMessage.Size = new Size(75, 23);
            buttonCryptMessage.TabIndex = 3;
            buttonCryptMessage.Text = "Encrypt";
            buttonCryptMessage.UseVisualStyleBackColor = true;
            buttonCryptMessage.Click += buttonCryptMessage_Click;
            // 
            // labelEncrypt
            // 
            labelEncrypt.Location = new Point(92, 163);
            labelEncrypt.Name = "labelEncrypt";
            labelEncrypt.Size = new Size(53, 19);
            labelEncrypt.TabIndex = 4;
            labelEncrypt.Text = "CryptText";
            // 
            // buttonAttackForceBrute
            // 
            buttonAttackForceBrute.Location = new Point(439, 76);
            buttonAttackForceBrute.Name = "buttonAttackForceBrute";
            buttonAttackForceBrute.Size = new Size(145, 23);
            buttonAttackForceBrute.TabIndex = 3;
            buttonAttackForceBrute.Text = "Attack ForceBrute";
            buttonAttackForceBrute.UseVisualStyleBackColor = true;
            buttonAttackForceBrute.Click += buttonAttackForceBrute_Click;
            // 
            // buttonDecrypt
            // 
            buttonDecrypt.Location = new Point(520, 34);
            buttonDecrypt.Name = "buttonDecrypt";
            buttonDecrypt.Size = new Size(75, 23);
            buttonDecrypt.TabIndex = 5;
            buttonDecrypt.Text = "Decrypt";
            buttonDecrypt.UseVisualStyleBackColor = true;
            buttonDecrypt.Click += buttonDecrypt_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, Column1, Column2 });
            dataGridView1.Location = new Point(12, 239);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1031, 349);
            dataGridView1.TabIndex = 6;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // Column1
            // 
            Column1.HeaderText = "Column1";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Column2";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // buttonIC
            // 
            buttonIC.Location = new Point(590, 75);
            buttonIC.Name = "buttonIC";
            buttonIC.Size = new Size(171, 23);
            buttonIC.TabIndex = 7;
            buttonIC.Text = "IndexOfCoincedence";
            buttonIC.UseVisualStyleBackColor = true;
            buttonIC.Click += buttonIC_Click;
            // 
            // textBoxEncrypted
            // 
            textBoxEncrypted.Anchor = AnchorStyles.None;
            textBoxEncrypted.Location = new Point(157, 118);
            textBoxEncrypted.Multiline = true;
            textBoxEncrypted.Name = "textBoxEncrypted";
            textBoxEncrypted.Size = new Size(267, 115);
            textBoxEncrypted.TabIndex = 8;
            // 
            // buttonFindKeyWithMIC
            // 
            buttonFindKeyWithMIC.Location = new Point(788, 81);
            buttonFindKeyWithMIC.Name = "buttonFindKeyWithMIC";
            buttonFindKeyWithMIC.Size = new Size(75, 23);
            buttonFindKeyWithMIC.TabIndex = 9;
            buttonFindKeyWithMIC.Text = "FindKeyWithMIC";
            buttonFindKeyWithMIC.UseVisualStyleBackColor = true;
            buttonFindKeyWithMIC.Click += buttonFindKeyWithMIC_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1055, 600);
            Controls.Add(buttonFindKeyWithMIC);
            Controls.Add(textBoxEncrypted);
            Controls.Add(buttonIC);
            Controls.Add(dataGridView1);
            Controls.Add(buttonDecrypt);
            Controls.Add(labelEncrypt);
            Controls.Add(buttonAttackForceBrute);
            Controls.Add(buttonCryptMessage);
            Controls.Add(label2);
            Controls.Add(textBoxKey);
            Controls.Add(label1);
            Controls.Add(textBoxMessage);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxMessage;
        private Label label1;
        private TextBox textBoxKey;
        private Label label2;
        private Button buttonCryptMessage;
        private Label labelEncrypt;
        private Button buttonAttackForceBrute;
        private Button buttonDecrypt;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private Button buttonIC;
        private TextBox textBoxEncrypted;
        private Button buttonFindKeyWithMIC;
    }
}