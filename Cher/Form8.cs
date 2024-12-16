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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // รับค่าตัวเลขจาก TextBox (คั่นด้วย ,)
                string input = textBox1.Text;

                // แปลงข้อความเป็น Array ของตัวเลข
                int[] numbers = input.Split(',').Select(int.Parse).ToArray();

                // เรียกใช้ Method แบบ For และ Foreach
                double averageFor = CalculateAverageFor(numbers);
                double averageForeach = CalculateAverageForeach(numbers);

                // แสดงผลลัพธ์ใน Label
                label1.Text = $"ค่าเฉลี่ยแบบ For: {averageFor}\nค่าเฉลี่ยแบบ Foreach: {averageForeach}";
            }
            catch (Exception ex)
            {
                // แสดงข้อความผิดพลาด
                MessageBox.Show("กรุณากรอกตัวเลขที่ถูกต้อง คั่นด้วยเครื่องหมายจุลภาค (,)", "เกิดข้อผิดพลาด");
            }
     
        }

        // Method สำหรับหาค่าเฉลี่ยแบบ For
        private double CalculateAverageFor(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                throw new ArgumentException("Array ต้องมีข้อมูลอย่างน้อย 1 ค่า");
            }

            double sum = 0;

            // ใช้ลูป For เพื่อรวมค่าทั้งหมดใน Array
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            return sum / array.Length; // คืนค่าผลลัพธ์เป็นค่าเฉลี่ย
        }

        // Method สำหรับหาค่าเฉลี่ยแบบ Foreach
        private double CalculateAverageForeach(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                throw new ArgumentException("Array ต้องมีข้อมูลอย่างน้อย 1 ค่า");
            }

            double sum = 0;

            // ใช้ลูป Foreach เพื่อรวมค่าทั้งหมดใน Array
            foreach (int number in array)
            {
                sum += number;
            }

            return sum / array.Length; // คืนค่าผลลัพธ์เป็นค่าเฉลี่ย
        }
    }
}
