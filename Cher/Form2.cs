using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cher
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // ตรวจสอบว่าเป็นตัวเลขหรือไม่
            if (!double.TryParse(textBox1.Text, out _) ||
                !double.TryParse(textBox2.Text, out _) ||
                !int.TryParse(textBox3.Text, out _))
            {
                // แจ้งเตือนเมื่อกรอกข้อมูลไม่ถูกต้อง
                MessageBox.Show("กรุณากรอกตัวเลขให้ถูกต้องในทุกช่อง", "ข้อผิดพลาด");
                return;
            }

            // ดึงค่าที่ผ่านการตรวจสอบ
            double principal = double.Parse(textBox1.Text);
            double rate = double.Parse(textBox2.Text);
            int years = int.Parse(textBox3.Text);

            // คำนวณดอกเบี้ยทบต้น
            double compoundInterest = CalculateCompoundInterest(principal, rate, years);

            // แสดงผลลัพธ์
            MessageBox.Show($"ดอกเบี้ยทบต้นที่ได้คือ: {compoundInterest:F2}", "ผลลัพธ์");
        }


        //  คำนวณดอกเบี้ยทบต้น
        private double CalculateCompoundInterest(double principal, double rate, int years)
        {
            return principal * Math.Pow((1 + rate / 100), years);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
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


