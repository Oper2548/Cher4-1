using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Cher
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // ตรวจสอบว่าเป็นตัวเลขหรือไม่
            if (!double.TryParse(textBox1.Text, out _) ||
                !double.TryParse(textBox2.Text, out _) ||
                !double.TryParse(textBox3.Text, out _))
            {
                MessageBox.Show("กรุณากรอกตัวเลขให้ถูกต้องในทุกช่อง", "ข้อผิดพลาด");
                return;
            }

            // ดึงค่าที่ผ่านการตรวจสอบ
            double num1 = double.Parse(textBox1.Text); // ตัวเลขตัวที่ 1
            double num2 = double.Parse(textBox2.Text); // ตัวเลขตัวที่ 2
            double num3 = double.Parse(textBox3.Text); // ตัวเลขตัวที่ 3

            // คำนวณค่าเฉลี่ย
            double average = CalculateAverage(num1, num2, num3);

            // คำนวณเปอร์เซ็นต์การเปลี่ยนแปลง
            double percentageChange = CalculatePercentageChange(num1, num2);

            // แสดงผลลัพธ์
            MessageBox.Show($"ค่าเฉลี่ยของ {num1}, {num2}, {num3} คือ: {average:F2}\n" +
                            $"เปอร์เซ็นต์การเปลี่ยนแปลงจาก {num1} เป็น {num2} คือ: {percentageChange:F2}%", "ผลลัพธ์");
        }

        private double CalculateAverage(double num1, double num2, double num3)
        {
            return (num1 + num2 + num3) / 3;
        }

        private double CalculatePercentageChange(double oldValue, double newValue)
        {
            return ((newValue - oldValue) / oldValue) * 100;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {           
            clearForm();
        }
        private void clearForm() //คำสั่งเครียหน้าจอ **เอาไว้ใช้ที่อื่นได้**
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
    }
}
