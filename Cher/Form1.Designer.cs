namespace Cher
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
            txtFullname = new TextBox();
            txtTitle = new TextBox();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnSplitName = new Button();
            label5 = new Label();
            button1 = new Button();
            label6 = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            SuspendLayout();
            // 
            // txtFullname
            // 
            txtFullname.Location = new Point(255, 98);
            txtFullname.Name = "txtFullname";
            txtFullname.Size = new Size(367, 27);
            txtFullname.TabIndex = 0;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(255, 176);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(174, 27);
            txtTitle.TabIndex = 1;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(255, 225);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(174, 27);
            txtFirstName.TabIndex = 2;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(255, 278);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(174, 27);
            txtLastName.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(168, 101);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 4;
            label1.Text = "ชื่อ-นามสกุล";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(178, 186);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(168, 232);
            label3.Name = "label3";
            label3.Size = new Size(26, 20);
            label3.TabIndex = 6;
            label3.Text = "ชื่อ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(168, 285);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 7;
            label4.Text = "นามสกุล";
            // 
            // btnSplitName
            // 
            btnSplitName.Location = new Point(473, 155);
            btnSplitName.Name = "btnSplitName";
            btnSplitName.Size = new Size(149, 150);
            btnSplitName.TabIndex = 8;
            btnSplitName.Text = "แยกชื่อสกุล";
            btnSplitName.UseVisualStyleBackColor = true;
            btnSplitName.Click += btnSplitName_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(168, 179);
            label5.Name = "label5";
            label5.Size = new Size(66, 20);
            label5.TabIndex = 9;
            label5.Text = "คำนำหน้า";
            // 
            // button1
            // 
            button1.Location = new Point(168, 364);
            button1.Name = "button1";
            button1.Size = new Size(187, 29);
            button1.TabIndex = 10;
            button1.Text = "คำนวณดอกเบี้ย";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(362, 30);
            label6.Name = "label6";
            label6.Size = new Size(109, 20);
            label6.TabIndex = 11;
            label6.Text = " แยกชื่อ-นามสกุล";
            // 
            // button2
            // 
            button2.Location = new Point(425, 364);
            button2.Name = "button2";
            button2.Size = new Size(197, 29);
            button2.TabIndex = 12;
            button2.Text = "คำนวณการเปลี่ยนแปลง";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(657, 364);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 13;
            button3.Text = "รีหน้าจอ";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(674, 155);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 14;
            button4.Text = "นาย";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(674, 190);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 15;
            button5.Text = "เด็กชาย";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(674, 241);
            button6.Name = "button6";
            button6.Size = new Size(94, 29);
            button6.TabIndex = 16;
            button6.Text = "นศท.";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(674, 276);
            button7.Name = "button7";
            button7.Size = new Size(94, 29);
            button7.TabIndex = 17;
            button7.Text = "เด็กหญิง";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(btnSplitName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(txtTitle);
            Controls.Add(txtFullname);
            Name = "Form1";
            Text = " แยกชื่อ-นามสกุล";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFullname;
        private TextBox txtTitle;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnSplitName;
        private Label label5;
        private Button button1;
        private Label label6;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
    }
}
