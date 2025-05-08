namespace ArdaNDP2
{
    partial class Form1
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
            label1 = new Label();
            yukleButton = new Button();
            baslaButton = new Button();
            cikisButton = new Button();
            sozlukBox1 = new ComboBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(296, 18);
            label1.TabIndex = 1;
            label1.Text = "Kelime Ezberleme Oyununa Hoşgeldiniz!\r\n";
            // 
            // yukleButton
            // 
            yukleButton.Location = new Point(271, 121);
            yukleButton.Name = "yukleButton";
            yukleButton.Size = new Size(94, 29);
            yukleButton.TabIndex = 2;
            yukleButton.Text = "Yükle";
            yukleButton.UseVisualStyleBackColor = true;
            yukleButton.Click += yukleButton_Click;
            // 
            // baslaButton
            // 
            baslaButton.Location = new Point(371, 121);
            baslaButton.Name = "baslaButton";
            baslaButton.Size = new Size(94, 29);
            baslaButton.TabIndex = 3;
            baslaButton.Text = "Başla";
            baslaButton.UseVisualStyleBackColor = true;
            baslaButton.Click += baslaButton_Click;
            // 
            // cikisButton
            // 
            cikisButton.Location = new Point(473, 121);
            cikisButton.Name = "cikisButton";
            cikisButton.Size = new Size(94, 29);
            cikisButton.TabIndex = 4;
            cikisButton.Text = "Çıkış";
            cikisButton.UseVisualStyleBackColor = true;
            cikisButton.Click += cikisButton_Click;
            // 
            // sozlukBox1
            // 
            sozlukBox1.FormattingEnabled = true;
            sozlukBox1.Location = new Point(40, 66);
            sozlukBox1.Name = "sozlukBox1";
            sozlukBox1.Size = new Size(527, 28);
            sozlukBox1.TabIndex = 5;
            sozlukBox1.Click += sozlukBox1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(40, 43);
            label2.Name = "label2";
            label2.Size = new Size(189, 20);
            label2.TabIndex = 6;
            label2.Text = "Kelime sözlüğünüzü seçiniz";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 64);
            ClientSize = new Size(579, 178);
            Controls.Add(label2);
            Controls.Add(sozlukBox1);
            Controls.Add(cikisButton);
            Controls.Add(baslaButton);
            Controls.Add(yukleButton);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kelime Ezber Oyunu | Giriş";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button yukleButton;
        private Button baslaButton;
        private Button cikisButton;
        private ComboBox sozlukBox1;
        private Label label2;
    }
}
