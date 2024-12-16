namespace Cher
{
    partial class Form9
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
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            mak = new RadioButton();
            radioButton1 = new RadioButton();
            label2 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(496, 311);
            button1.Name = "button1";
            button1.Size = new Size(135, 83);
            button1.TabIndex = 0;
            button1.Text = "เริ่ม";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(273, 103);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(173, 27);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.GradientInactiveCaption;
            label1.Location = new Point(273, 207);
            label1.Name = "label1";
            label1.Size = new Size(173, 187);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // mak
            // 
            mak.AutoSize = true;
            mak.Location = new Point(273, 166);
            mak.Name = "mak";
            mak.Size = new Size(92, 24);
            mak.TabIndex = 3;
            mak.TabStop = true;
            mak.Text = "มากไปน้อย";
            mak.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(273, 136);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(92, 24);
            radioButton1.TabIndex = 4;
            radioButton1.TabStop = true;
            radioButton1.Text = "น้อยไปมาก";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(338, 51);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 5;
            label2.Text = "มากไปน้อย";
            // 
            // Form9
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(radioButton1);
            Controls.Add(mak);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "Form9";
            Text = "มากไปน้อย";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private RadioButton mak;
        private RadioButton radioButton1;
        private Label label2;
    }
}