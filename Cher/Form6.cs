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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // ตรวจสอบจำนวนแถวว่าถูกต้องหรือไม่
            if (!int.TryParse(textBox1.Text, out int size) || size <= 0)
            {
                MessageBox.Show("กรุณาใส่จำนวนแถวที่มากกว่า 0", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // รับรูปแบบที่ผู้ใช้เลือกจาก ComboBox
            string patternType = comboBox1.Text;
            string TS = textBox2.Text;

            // สร้างและแสดงรูปแบบใน Label
            label1.Text = GeneratePattern(size, patternType,TS);
        }

        private string GeneratePattern(int size, string patternType, string TS)
        {
            StringBuilder sb = new StringBuilder();

            switch (patternType)
            {
                case "A": // รูปแบบขอบ
                    for (int i = 0; i < size; i++)
                    {
                        for (int j = 0; j < size; j++)
                        {
                            if (i == 0 || i == size - 1 || j == 0 || j == size - 1)
                                sb.Append(TS);
                            else
                                sb.Append("  ");
                        }
                        sb.AppendLine();
                    }
                    break;

                case "B": // รูปแบบขอบและตัวเลขเรียง
                    for (int i = 0; i < size; i++)
                    {
                        for (int j = 0; j < size; j++)
                        {
                            if (i == 0 || i == size - 1 || j == 0 || j == size - 1)
                                sb.Append(TS);
                            else
                                sb.Append(i + " "); // ตัวเลขที่เพิ่มขึ้นตามแถว
                        }
                        sb.AppendLine();
                    }
                    break;

                case "C": // รูปแบบสามเหลี่ยม
                    for (int i = 0; i < size; i++)
                    {
                        for (int j = 0; j <= i; j++)
                        {
                            sb.Append(TS);
                        }
                        sb.AppendLine();
                    }
                    break;

                default:
                    sb.Append("เลือกรูปแบบไม่ถูกต้อง");
                    break;
            }

            return sb.ToString();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            string[] t = { "A", "B", "C" };
            comboBox1.Items.AddRange(t);
        }
    }
}
