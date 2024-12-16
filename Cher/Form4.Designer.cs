namespace Cher
{
    partial class Form4
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
            button2 = new Button();
            button4 = new Button();
            label1 = new Label();
            button5 = new Button();
            button7 = new Button();
            button8 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(50, 85);
            button1.Name = "button1";
            button1.Size = new Size(199, 64);
            button1.TabIndex = 0;
            button1.Text = "แยกชื่อ-นามสกุล";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(50, 286);
            button2.Name = "button2";
            button2.Size = new Size(199, 64);
            button2.TabIndex = 1;
            button2.Text = "คำนวณเปอร์เซ็นต์การเปลี่ยนแปลง";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.Location = new Point(50, 186);
            button4.Name = "button4";
            button4.Size = new Size(199, 64);
            button4.TabIndex = 3;
            button4.Text = "โปรแกรมคำนวณดอกเบี้ย";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.Location = new Point(386, 37);
            label1.Name = "label1";
            label1.Size = new Size(34, 31);
            label1.TabIndex = 4;
            label1.Text = "เมนู";
            // 
            // button5
            // 
            button5.Location = new Point(556, 186);
            button5.Name = "button5";
            button5.Size = new Size(199, 64);
            button5.TabIndex = 6;
            button5.Text = "รูปแบบ";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button7
            // 
            button7.Location = new Point(556, 85);
            button7.Name = "button7";
            button7.Size = new Size(199, 64);
            button7.TabIndex = 8;
            button7.Text = "หาค่าเฉลี่ยตัวเลขใน Array";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(556, 286);
            button8.Name = "button8";
            button8.Size = new Size(199, 64);
            button8.TabIndex = 9;
            button8.Text = "มากไปน้อย";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button5);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form4";
            Text = "เมนู";
            Load += Form4_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button4;
        private Label label1;
        private Button button5;
        private Button button7;
        private Button button8;
    }
}