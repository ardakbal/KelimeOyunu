namespace ArdaNDP2
{
    partial class Form2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.DarkSlateBlue;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(35, 127);
            label1.Name = "label1";
            label1.Size = new Size(426, 89);
            label1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 107);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 5;
            label2.Text = "Soru";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 9);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 6;
            label3.Text = "Aşama";
            // 
            // label5
            // 
            label5.BackColor = Color.DodgerBlue;
            label5.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(35, 34);
            label5.Name = "label5";
            label5.Size = new Size(206, 58);
            label5.TabIndex = 8;
            // 
            // label6
            // 
            label6.BackColor = Color.BlueViolet;
            label6.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.ForeColor = Color.White;
            label6.Location = new Point(238, 34);
            label6.Name = "label6";
            label6.Size = new Size(223, 58);
            label6.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(35, 237);
            button1.Name = "button1";
            button1.Size = new Size(206, 89);
            button1.TabIndex = 10;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(247, 237);
            button2.Name = "button2";
            button2.Size = new Size(214, 89);
            button2.TabIndex = 11;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(35, 332);
            button3.Name = "button3";
            button3.Size = new Size(206, 89);
            button3.TabIndex = 12;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(247, 332);
            button4.Name = "button4";
            button4.Size = new Size(214, 89);
            button4.TabIndex = 13;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(420, 9);
            label7.Name = "label7";
            label7.Size = new Size(41, 20);
            label7.TabIndex = 15;
            label7.Text = "Puan";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(491, 433);
            Controls.Add(label7);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kelime Ezberleme Oyunu | Oyun Ekranı";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label7;
    }
}