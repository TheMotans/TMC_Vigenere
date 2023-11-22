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
            button1 = new Button();
            labelEncrypt = new Label();
            button2 = new Button();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            buttonIC = new Button();
            textBoxEncrypted = new TextBox();
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
            // button1
            // 
            button1.Location = new Point(439, 34);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Encrypt";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // labelEncrypt
            // 
            labelEncrypt.Location = new Point(92, 122);
            labelEncrypt.Name = "labelEncrypt";
            labelEncrypt.Size = new Size(53, 19);
            labelEncrypt.TabIndex = 4;
            labelEncrypt.Text = "CryptText";
            // 
            // button2
            // 
            button2.Location = new Point(439, 76);
            button2.Name = "button2";
            button2.Size = new Size(145, 23);
            button2.TabIndex = 3;
            button2.Text = "Decrypt_ForceBrute";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(520, 34);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 5;
            button3.Text = "Decrypt";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, Column1, Column2 });
            dataGridView1.Location = new Point(12, 170);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1031, 418);
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
            textBoxEncrypted.Location = new Point(157, 118);
            textBoxEncrypted.Name = "textBoxEncrypted";
            textBoxEncrypted.Size = new Size(267, 23);
            textBoxEncrypted.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1055, 600);
            Controls.Add(textBoxEncrypted);
            Controls.Add(buttonIC);
            Controls.Add(dataGridView1);
            Controls.Add(button3);
            Controls.Add(labelEncrypt);
            Controls.Add(button2);
            Controls.Add(button1);
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
        private Button button1;
        private Label labelEncrypt;
        private Button button2;
        private Button button3;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private Button buttonIC;
        private TextBox textBoxEncrypted;
    }
}