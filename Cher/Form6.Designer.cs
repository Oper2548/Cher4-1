namespace Cher
{
    partial class Form6
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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            comboBox1 = new ComboBox();
            textBox2 = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(440, 117);
            button1.Name = "button1";
            button1.Size = new Size(127, 76);
            button1.TabIndex = 0;
            button1.Text = "เริ่ม";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.InactiveCaption;
            label1.Location = new Point(254, 201);
            label1.Name = "label1";
            label1.Size = new Size(171, 204);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(376, 39);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 2;
            label2.Text = "รูปแบบ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(236, 86);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 3;
            textBox1.Text = "1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(137, 90);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 4;
            label3.Text = "จำนวนแถว";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(148, 160);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 6;
            label4.Text = "รูปแบบ";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(236, 152);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 7;
            comboBox1.Text = "A";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(236, 119);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 8;
            textBox2.Text = "#";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(148, 126);
            label5.Name = "label5";
            label5.Size = new Size(57, 20);
            label5.TabIndex = 9;
            label5.Text = "ตัวอักษร";
            // 
            // Form6
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(textBox2);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form6";
            Text = "รูปแบบ";
            Load += Form6_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private Label label4;
        private ComboBox comboBox1;
        private TextBox textBox2;
        private Label label5;
    }
}