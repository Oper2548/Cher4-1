﻿namespace Cher
{
    partial class Form3
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
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(520, 169);
            button1.Name = "button1";
            button1.Size = new Size(111, 90);
            button1.TabIndex = 0;
            button1.Text = "คำนวณผลลัพธ์";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(303, 142);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(303, 202);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(303, 268);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(193, 149);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 4;
            label1.Text = "ตัวเลขตัวที่ 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(193, 209);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 5;
            label2.Text = "ตัวเลขตัวที่ 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(193, 275);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 6;
            label3.Text = "ตัวเลขตัวที่ 3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(282, 65);
            label4.Name = "label4";
            label4.Size = new Size(202, 20);
            label4.TabIndex = 7;
            label4.Text = "คำนวณเปอร์เซ็นต์การเปลี่ยนแปลง";
            // 
            // button2
            // 
            button2.Location = new Point(193, 365);
            button2.Name = "button2";
            button2.Size = new Size(170, 29);
            button2.TabIndex = 8;
            button2.Text = "คำนวณดอกเบี้ย";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(439, 365);
            button3.Name = "button3";
            button3.Size = new Size(170, 29);
            button3.TabIndex = 9;
            button3.Text = "แยกชื่อ-นามสกุล";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(520, 266);
            button4.Name = "button4";
            button4.Size = new Size(111, 29);
            button4.TabIndex = 10;
            button4.Text = "รีค่าเริ่มต้น";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "Form3";
            Text = "คำนวณเปอร์เซ็นต์การเปลี่ยนแปลง";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}