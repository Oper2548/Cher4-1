namespace Cher
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
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            button2 = new Button();
            label7 = new Label();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(510, 170);
            button1.Name = "button1";
            button1.Size = new Size(142, 85);
            button1.TabIndex = 0;
            button1.Text = "คำนวณดอกเบี้ย";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(273, 120);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(273, 196);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(153, 127);
            label1.Name = "label1";
            label1.Size = new Size(68, 20);
            label1.TabIndex = 3;
            label1.Text = "จำนวนเงิน";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(153, 199);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 4;
            label2.Text = "อัตราดอกเบี้ย";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(153, 274);
            label3.Name = "label3";
            label3.Size = new Size(59, 20);
            label3.TabIndex = 5;
            label3.Text = "ระยะเวลา";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(415, 127);
            label4.Name = "label4";
            label4.Size = new Size(34, 20);
            label4.TabIndex = 6;
            label4.Text = "บาท";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(273, 267);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(415, 203);
            label5.Name = "label5";
            label5.Size = new Size(21, 20);
            label5.TabIndex = 8;
            label5.Text = "%";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(415, 274);
            label6.Name = "label6";
            label6.Size = new Size(18, 20);
            label6.TabIndex = 9;
            label6.Text = "ปี";
            // 
            // button2
            // 
            button2.Location = new Point(135, 369);
            button2.Name = "button2";
            button2.Size = new Size(223, 29);
            button2.TabIndex = 10;
            button2.Text = "แยกชื่อ-นามสกุล";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(328, 46);
            label7.Name = "label7";
            label7.Size = new Size(152, 20);
            label7.TabIndex = 11;
            label7.Text = "โปรแกรมคำนวณดอกเบี้ย";
            // 
            // button3
            // 
            button3.Location = new Point(415, 369);
            button3.Name = "button3";
            button3.Size = new Size(223, 29);
            button3.TabIndex = 12;
            button3.Text = "คำนวณเปอร์เซ็นต์การเปลี่ยนแปลง";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(510, 265);
            button4.Name = "button4";
            button4.Size = new Size(142, 29);
            button4.TabIndex = 13;
            button4.Text = "คืนค่าเริ่มต้น";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label7);
            Controls.Add(button2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "Form2";
            Text = "โปรแกรมคำนวณดอกเบี้ย";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox3;
        private Label label5;
        private Label label6;
        private Button button2;
        private Label label7;
        private Button button3;
        private Button button4;
    }
}