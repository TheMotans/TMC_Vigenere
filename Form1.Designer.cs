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
            labelEncrypt.Location = new Point(93, 122);
            labelEncrypt.Name = "labelEncrypt";
            labelEncrypt.Size = new Size(331, 45);
            labelEncrypt.TabIndex = 4;
            labelEncrypt.Text = "label3";
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1055, 600);
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
    }
}