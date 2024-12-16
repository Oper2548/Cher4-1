using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cher
{
    public partial class Form9 : Form
    {
        public Form9()
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

                // รับค่าเลือกวิธีการเรียงลำดับจาก RadioButton
                bool isDescending = mak.Checked;

                // เรียกใช้ Method สำหรับการเรียงลำดับ
                int[] sortedArray = SortArray(numbers, isDescending);

                // แสดงผลลัพธ์ใน Label
                label1.Text = "ผลลัพธ์: " + string.Join(", ", sortedArray);
            }
            catch (Exception ex)
            {
                // แสดงข้อความผิดพลาด
                MessageBox.Show("กรุณากรอกตัวเลขที่ถูกต้อง คั่นด้วยเครื่องหมายจุลภาค (,)", "เกิดข้อผิดพลาด" + ex.Message);
            }
        }

        // Method สำหรับการเรียงลำดับ
        private int[] SortArray(int[] array, bool descending)
        {
            if (descending)
            {
                // เรียงจากมากไปน้อย (Descending)
                return array.OrderByDescending(n => n).ToArray();
            }
            else
            {
                // เรียงจากน้อยไปมาก (Ascending)
                return array.OrderBy(n => n).ToArray();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}